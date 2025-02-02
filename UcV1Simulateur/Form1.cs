using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Modbus_Poll_CS;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Globalization;
using static Modbus_Poll_CS.SundanceRs485;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Net.Mime.MediaTypeNames;


namespace UcV1Simulateur
{
    public partial class Form1 : Form
    {
        bool serialConnected = false;
        serial sr;
        int nbFrame = 0;
        SundanceRs485 sun;
        List<byte> filter;
        string file2;
        string subPath;

        public Form1()
        {
            InitializeComponent();
            sr = new serial();
            sun = new SundanceRs485();


            search_serialport();
            init_paramport();
            if (checkBox_Save.Checked) create_file();
            for (int i = 0; i < checkedListBoxFilter.Items.Count; i++)
            {
                if (checkedListBoxFilter.Items[i].ToString() != "0x00" && checkedListBoxFilter.Items[i].ToString() != "0x06" && checkedListBoxFilter.Items[i].ToString() != "0x07")
                {
                    checkedListBoxFilter.SetItemChecked(i, true);
                }
            }
            get_Filter();
            timer1.Start();
            init_sendFrame();
            constructData();
        }
        private void get_Filter()
        {
            filter = new List<byte>();
            for (int i = 0; i < checkedListBoxFilter.Items.Count; i++)
            {
                if (checkedListBoxFilter.GetItemChecked(i))
                {
                    string val = checkedListBoxFilter.Items[i].ToString().Split('x')[1];
                    byte bt = byte.Parse(val, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
                    filter.Add(bt);
                }
            }
        }
        private void buttonSerialConnect_Click(object sender, EventArgs e)
        {
            if (!serialConnected)
            {
                sr.Open(
                    comboBoxPort.SelectedItem.ToString(),
                    int.Parse(comboBoxBaudrate.SelectedItem.ToString()),
                    int.Parse(comboBoxDatabits.SelectedItem.ToString()),
                    (Parity)Enum.Parse(typeof(Parity), comboBoxParity.SelectedItem.ToString()),
                    (StopBits)Enum.Parse(typeof(StopBits), comboBoxStop.SelectedItem.ToString()));
                buttonSerialConnect.Text = "Connecté";
                panel_serial.BackColor = Color.LightGreen;

                serialConnected = true;
                buttonOrder.Visible = true;
            }
            else
            {
                sr.Close();
                buttonSerialConnect.Text = "Connexion";
                panel_serial.BackColor = Color.LightCoral;
                serialConnected = false;
                buttonOrder.Visible = false;
            }
            groupBoxKeyboard.Visible = serialConnected;
            //groupBoxStatus.Visible = serialConnected;
        }


        private void create_file()
        {
            if (checkBox_Save.Checked)
            {
                subPath = @"c:\000";
                buttonFolderSave.Text = subPath;
                bool exists = System.IO.Directory.Exists(subPath);

                if (!exists)
                    System.IO.Directory.CreateDirectory(subPath);

                file2 = "sundance_";
                file2 += DateTime.Now.ToString("yyyyMMdd_HHmmss");
                textBoxFilename.Text = file2;
            }
        }
        private void init_paramport()
        {
            comboBoxParity.DataSource = Enum.GetValues(typeof(Parity));
            comboBoxStop.DataSource = Enum.GetValues(typeof(StopBits));
            comboBoxBaudrate.Text = "115200";
            comboBoxParity.SelectedItem = Parity.None;
            comboBoxDatabits.Text = "8";
            comboBoxStop.SelectedItem = StopBits.One;
        }
        private void search_serialport()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPort.Items.Clear();
            foreach (string s in ports)
            {
                comboBoxPort.Items.Add(s);
            }
            if (ports.Length != 0)
            {
                comboBoxPort.SelectedIndex = 0;
            }
        }
        private void buttonPort_Click(object sender, EventArgs e)
        {
            search_serialport();
        }

        private void comboBoxPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSerialConnect.Visible = comboBoxPort.SelectedItem.ToString() != string.Empty;
        }


        private void buttonFolderSave_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSave.ShowDialog() == DialogResult.OK)
            {
                buttonFolderSave.Text = folderBrowserDialogSave.SelectedPath;
                subPath = folderBrowserDialogSave.SelectedPath;
            }

        }

        private void checkBox_Save_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Save.Checked) create_file();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            write_frame();
        }

        private void write_frame()
        {
            string line = string.Empty;
            string data = string.Empty;
            while (sr.FrameList.Count() > 0)
            {
                frame f = sr.FrameList[0];
                line = f.Rawframe;
                /*line += "data;";
                foreach (var val in f.Data)
                {
                    line += val.ToString("x2").ToUpper();
                    line += ";";
                }*/
                var res = filter.Where(x => x == f.Type);
                if (res.Count() > 0 || checkBoxAllFrame.Checked)
                {
                    if (checkBox_Save.Checked)
                    {
                        nbFrame++;
                        richTextBoxFrame.AppendText(line + "\r\n");
                        richTextBoxFrame.ScrollToCaret();

                        if (checkBoxValue.Checked)
                        {
                            line = "value;";
                            foreach (var val in f.Value)
                            {
                                line += val.ToString("x2").ToUpper();
                                line += ";";
                            }
                            richTextBoxFrame.AppendText(line + "\r\n");
                            richTextBoxFrame.ScrollToCaret();
                        }
                    }
                    if (f.Type == 0xC4)
                    {
                        sun.Parse_0xC4_Status(f);
                        affect_Status();
                    }
                    else if (f.Type == 0xCA)
                    {
                        sun.Parse_0xCA_Light(f);
                        affect_Light();
                    }
                }
                sr.FrameList.RemoveAt(0);
            }
            label_nbframe.Text = nbFrame.ToString();
        }

        private void affect_Status()
        {
            textBoxStatusHour.Text = sun.StatusSundance.Hour;
            textBoxStatusMinut.Text = sun.StatusSundance.Minute;
            textBoxStatusDay.Text = sun.StatusSundance.Day;
            textBoxStatusMonth.Text = sun.StatusSundance.Month;
            textBoxStatusPump1.Text = sun.StatusSundance.Pump1;
            textBoxStatusPump2.Text = sun.StatusSundance.Pump2;
            textBoxStatusBlower.Text = sun.StatusSundance.Blower;
            textBoxStatusCircul.Text = sun.StatusSundance.Circulation;
            textBoxStatusCircMode.Text = sun.StatusSundance.CirculationMode;
            textBoxStatusHeat.Text = sun.StatusSundance.Heat;
            textBoxStatusSettemp.Text = sun.StatusSundance.SetTemp;
            textBoxStatusTemp.Text = sun.StatusSundance.Temp;
            textBoxStatusClearray.Text = sun.StatusSundance.Clearray;
            textBoxStatusYear.Text = sun.StatusSundance.Year;
            textBoxStatusFilter2.Text = sun.StatusSundance.Filter2;
        }

        private void affect_Light()
        {
            textBoxLightR.Text = sun.StatusSundance.LightR;
            textBoxLightG.Text = sun.StatusSundance.LightG;
            textBoxLightB.Text = sun.StatusSundance.LightB;
            textBoxLightBrightnes.Text = sun.StatusSundance.LightBrightnes;
            textBoxLightCycle.Text = sun.StatusSundance.LightCycleTime;
            textBoxLightMode.Text = sun.StatusSundance.LightMode;
        }

        private void buttonCmdPump1_Click(object sender, EventArgs e)
        {
            sun.requestFrame(SundanceRs485.CC_request.Pump1, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void buttonCmdPump2_Click(object sender, EventArgs e)
        {
            sun.requestFrame(SundanceRs485.CC_request.Pump2, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void buttonCmdBlower_Click(object sender, EventArgs e)
        {
            sun.requestFrame(SundanceRs485.CC_request.Blower, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void buttonCircpump_Click(object sender, EventArgs e)
        {
            sun.requestFrame(SundanceRs485.CC_request.CircPump, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void buttonTempup_Click(object sender, EventArgs e)
        {
            sun.OrderSundance.TempOrder = (int)(numericUpDownTempOrder.Value * 10);
            sun.requestFrame(SundanceRs485.CC_request.TempIncrease, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void buttonTempdown_Click(object sender, EventArgs e)
        {
            sun.requestFrame(SundanceRs485.CC_request.TempDecrease, 0);
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }

        private void checkedListBoxFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            get_Filter();
        }

        private void buttonSaveRTB_Click(object sender, EventArgs e)
        {
            if (textBoxFilename.Text == string.Empty)
            {
                textBoxFilename.Text = file2;
            }
            richTextBoxFrame.SaveFile(buttonFolderSave.Text + @"\" + textBoxFilename.Text + ".txt", RichTextBoxStreamType.PlainText);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            constructData();
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.SelectionStart = richTextBoxFrame.TextLength;
            richTextBoxFrame.SelectionLength = 0;

            richTextBoxFrame.SelectionColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.SelectionColor = richTextBoxFrame.BackColor;
            richTextBoxFrame.ScrollToCaret();
        }
        private void init_sendFrame()
        {
            sun = new SundanceRs485();
            sun.StatusSundance = new Status();
            sun.OrderSundance.TempOrder = (int)(numericUpDownTempOrder.Value * 10);
            sun.SendFrame = new frame();
        }

        private void constructData()
        {
            sun.SendFrame.Data = new List<byte>();
            string[] b = labelOrderLength.Text.Split(' ');
            foreach (string l in b)
            {
                if (l != string.Empty)
                {
                    sun.SendFrame.Data.Add(Convert.ToByte(l, 16));
                }
            }
            sun.SendFrame.Data.Add(Convert.ToByte(textBoxorderChannel.Text, 16));
            sun.SendFrame.Data.Add(Convert.ToByte(labelOrderType.Text, 16));
            sun.SendFrame.Data.Add(Convert.ToByte(textBoxOrderCommand.Text, 16));
            b = textBoxOrderData.Text.Split(' ');
            foreach (string data in b)
            {
                if (data != string.Empty)
                {
                    sun.SendFrame.Data.Add(Convert.ToByte(data, 16));
                }
            }
            b = labelOrderCrc.Text.Split(' ');
            foreach (string c in b)
            {
                if (c != string.Empty)
                {
                    sun.SendFrame.Data.Add(Convert.ToByte(c, 16));
                }
            }
        }
        private void constructOrderFrame()
        {
            int l = textBoxOrderData.Text.Replace(" ", "").Length;
            if (l % 2 == 0)
            {
                int length = 5 + textBoxOrderData.Text.Replace(" ", "").Length / 2;
                labelOrderLength.Text = "7E " + length.ToString("X2");
                constructData();
                sun.Set_Crc();
                labelOrderCrc.Text = sun.SendFrame.Crc.ToString("X2") + " 7E";
                labelOrderCrc.Refresh();
                constructData();
            }
        }

        private void textBoxorderChannel_TextChanged(object sender, EventArgs e)
        {
            constructOrderFrame();
        }

        private void textBoxOrderCommand_TextChanged(object sender, EventArgs e)
        {
            constructOrderFrame();
        }

        private void textBoxOrderData_TextChanged(object sender, EventArgs e)
        {
             constructOrderFrame();
        }

        private void buttonFrameRaz_Click(object sender, EventArgs e)
        {
            richTextBoxFrame.Clear();
        }

        private void buttonLighton_Click(object sender, EventArgs e)
        {

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {

        }

        private void buttonLightSpeed_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonOutLigthOff_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOutLigthOn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOutLigthOn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonOutTimer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOrderYear_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrderUnitTemp_Click(object sender, EventArgs e)
        {
            if(comboBoxOrderUnitTemp.SelectedText == "Celcius")
            {
                sun.requestFrame(SundanceRs485.CC_request.SetTempUnit, 1);
            }
            else
            {
                sun.requestFrame(SundanceRs485.CC_request.SetTempUnit, 0);
            }
            sr.SerialPort.Write(sun.SendFrame.Data.ToArray(), 0, sun.SendFrame.Data.Count());
            richTextBoxFrame.BackColor = Color.Yellow;
            richTextBoxFrame.AppendText(sun.SendFrame.Rawframe + "\r\n");
            richTextBoxFrame.ScrollToCaret();
        }
    }
}

