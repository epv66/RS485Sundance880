using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Timers;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.ConstrainedExecution;

namespace Modbus_Poll_CS
{
    class frame
    {
        private byte length;
        private byte channel;
        private byte type;
        private string rawframe;
        private byte crc;
        private List<byte> data;
        private List<byte> value;

        public byte Length { get => length; set => length = value; }
        public byte Channel { get => channel; set => channel = value; }
        public byte Type { get => type; set => type = value; }
        public string Rawframe { get => rawframe; set => rawframe = value; }
        public List<byte> Data { get => data; set => data = value; }
        public List<byte> Value { get => value; set => this.value = value; }
        public byte Crc { get => crc; set => crc = value; }
    }
    class Order
    {
        private Dictionary<int, byte> dictOrderTemp = new Dictionary<int, byte>()
        {
            { 190, 0xAF },
            { 195, 0xAF },
            { 200, 0xAF },
            { 205, 0xAF },
            { 210, 0xAF },
            { 215, 0xAF },
            { 220, 0xAF },
            { 225, 0xAF },
            { 230, 0xAF },
            { 235, 0xAF },
            { 240, 0xAF },
            { 245, 0xAF },
            { 250, 0xAF },
            { 255, 0xAF },
            { 260, 0xAF },
            { 265, 0xAF },
            { 270, 0xAF },
            { 275, 0xAF },
            { 280, 0xAF },
            { 285, 0xAF },
            { 290, 0xAF },
            { 295, 0xAF },
            { 300, 0xAF },
            { 305, 0xAF },
            { 310, 0xAF },
            { 315, 0xAF },
            { 320, 0xAF },
            { 325, 0xAF },
            { 330, 0xAF },
            { 335, 0xAF },
            { 340, 0xAF },
            { 345, 0xAF },
            { 350, 0xAF },
            { 355, 0xAF },
            { 360, 0xAF },
            { 365, 0xAF },
            { 370, 0xAF },
            { 375, 0xAF },
            { 380, 0xAF },
            { 385, 0xAF },
            { 390, 0xAF },
            { 395, 0xAF },
            { 400, 0xAF }
         };
        private int tempOrder;
        public int TempOrder { get => tempOrder; set => tempOrder = value; }

        public byte Get_TempOrder_Byte()
        {
            if(dictOrderTemp.ContainsKey(tempOrder))
            {
                return dictOrderTemp[tempOrder];
            }
            return 0x00;
        }
    }
    class Status
    {
        private string day;
        private string month;
        private string year;
        private string hour;
        private string minute;
        private string setTemp;
        private string temp;
        private string pump1;
        private string pump2;
        private string blower;
        private string circulation;
        private string circulationMode;
        private string heat;
        private string heatMode;
        private string flowswitch;
        private string display;
        private string clearray;
        private string filter2;

        private string lightBrightnes;
        private string lightMode;
        private string lightR;
        private string lightG;
        private string lightB;
        private string lightCycleTime;

        public string Day { get => day; set => day = value; }
        public string Month { get => month; set => month = value; }
        public string Hour { get => hour; set => hour = value; }
        public string Minute { get => minute; set => minute = value; }
        public string SetTemp { get => setTemp; set => setTemp = value; }
        public string Temp { get => temp; set => temp = value; }
        public string Pump1 { get => pump1; set => pump1 = value; }
        public string Pump2 { get => pump2; set => pump2 = value; }
        public string Blower { get => blower; set => blower = value; }
        public string Circulation { get => circulation; set => circulation = value; }
        public string CirculationMode { get => circulationMode; set => circulationMode = value; }
        public string Heat { get => heat; set => heat = value; }
        public string Flowswitch { get => flowswitch; set => flowswitch = value; }
        public string HeatMode { get => heatMode; set => heatMode = value; }
        public string Display { get => display; set => display = value; }
        public string Year { get => year; set => year = value; }
        public string Clearray { get => clearray; set => clearray = value; }
        public string LightBrightnes { get => lightBrightnes; set => lightBrightnes = value; }
        public string LightMode { get => lightMode; set => lightMode = value; }
        public string LightR { get => lightR; set => lightR = value; }
        public string LightG { get => lightG; set => lightG = value; }
        public string LightB { get => lightB; set => lightB = value; }
        public string LightCycleTime { get => lightCycleTime; set => lightCycleTime = value; }
        public string Filter2 { get => filter2; set => filter2 = value; }
    }
    class SundanceRs485
    {
        public enum CC_request{ Pump1, Pump2, CircPump, TempIncrease,TempDecrease, Blower, SetTemp, SetYear, SetTempUnit  }
      
        Status statusSundance;
        Order orderSundance;
        frame sendFrame;
        public Status StatusSundance { get => statusSundance; set => statusSundance = value; }
        public frame SendFrame { get => sendFrame; set => sendFrame = value; }
        internal Order OrderSundance { get => orderSundance; set => orderSundance = value; }

        public SundanceRs485()
        {
            orderSundance = new Order();
        }
        public void Set_Crc()
        {
            int crc = 0xb5;
            int bit;
            int length = 0;
            for(int k = 1; k < SendFrame.Data.Count(); k++)
            {
                byte b = SendFrame.Data[k];
                if (k == 1)
                {
                    length = b;
                }
                if(k >= length)
                {
                    break;
                }
                for (int i = 0; i < 8; i++)
                {
                    bit = crc & 0x80;
                    crc = ((crc << 1) & 0xff) | ((b >> (7 - i)) & 0x01);
                    if (bit > 0)
                    {
                        crc = crc ^ 0x07;
                    }
                }
                crc &= 0xff;
            }
            for (int j = 0; j < 8; j++)
            {
                bit = crc & 0x80;
                crc = (crc << 1) & 0xff;
                if (bit > 0)
                {
                    crc = crc ^ 0x07;
                }
            }
            SendFrame.Crc = (byte)(crc ^ 0x02);
        }

        public void requestFrame(CC_request ccreq, int val)
        {
            SendFrame = new frame();
            SendFrame.Data = new List<byte>();
            SendFrame.Data.Add(0x7E);
            SendFrame.Data.Add(0x07);
            SendFrame.Data.Add(0x10);
            SendFrame.Data.Add(0xBF);
            switch (ccreq)
            {
                case CC_request.Pump1:
                    SendFrame.Data.Add(0xCC);
                    SendFrame.Data.Add(0xE4);
                    break;
                case CC_request.Pump2:
                    SendFrame.Data.Add(0xCC);
                    SendFrame.Data.Add(0xE5);
                    break;
                case CC_request.Blower:
                    SendFrame.Data.Add(0xCC);
                    SendFrame.Data.Add(0xEC);
                    break;
                case CC_request.CircPump:
                    SendFrame.Data.Add(0xCC);
                    SendFrame.Data.Add(0xEF);
                    break;
                case CC_request.TempIncrease:
                    SendFrame.Data.Add(0xC6);
                    SendFrame.Data.Add(0xE1);
                    break;
                case CC_request.TempDecrease:
                    SendFrame.Data.Add(0xC6);
                    SendFrame.Data.Add(0xA4);
                    break;
                case CC_request.SetTemp:
                    SendFrame.Data.Add(0xC6);
                    SendFrame.Data.Add(Convert.ToByte(orderSundance.Get_TempOrder_Byte()));
                    break;
                    case CC_request.SetYear:
                    int year = val - 1871;
                    SendFrame.Data.Add(0xCB);
                    SendFrame.Data.Add(0x67);
                    SendFrame.Data.Add(0x00);
                    SendFrame.Data.Add(0x9B);
                    SendFrame.Data.Add(0x00);
                    SendFrame.Data.Add(Convert.ToByte(year));
                    SendFrame.Data.Add(0x00);
                    break;
                case CC_request.SetTempUnit:

                    SendFrame.Data.Add(0xCC);
                    if(val == 1)
                    {
                        //celcius
                        SendFrame.Data.Add(0xC9);
                    }
                    else
                    {
                        //farhenheit
                        SendFrame.Data.Add(0xC8);
                    }
                    SendFrame.Data.Add(0x00);
                    break;
            }
            SendFrame.Data.Add(0x00);
            Set_Crc();
            SendFrame.Data.Add(SendFrame.Crc);
            SendFrame.Data.Add(0x7E);
            foreach(byte b in SendFrame.Data)
            {
                SendFrame.Rawframe += b.ToString("X2");
            }
        }
        
        public void Parse_0xC4_Status(frame f)
        {
            statusSundance = new Status();
            int val;
            statusSundance.Day = (f.Value[7] >> 3).ToString();//ok

            statusSundance.Month = (f.Value[7] & 0x07).ToString();
            statusSundance.Year = (2000 + f.Value[9]).ToString();//a tester

            statusSundance.Hour = (f.Value[0] ^ 6).ToString();//ok
            statusSundance.Minute = (f.Value[11] & 0x3F).ToString();//a tester


            statusSundance.SetTemp = ((f.Value[8] >> 1) & 0x3F).ToString();//ok
            int dec = f.Value[8] & 0x01;
            if (dec == 1) statusSundance.SetTemp += ".5"; else statusSundance.SetTemp += ".0";
            statusSundance.Temp = ((float)(f.Value[5] ^ 2) / 2.0).ToString();//ok

            statusSundance.Pump1 = ((f.Value[2] >> 4) & 0x01).ToString();//ok
            statusSundance.Pump2 = ((f.Value[1] >> 2) & 0x01).ToString();//ok

            statusSundance.Blower = (f.Value[7] & 0x01) == 0 ? "1" : "0";//ok
            statusSundance.Circulation = ((f.Value[1] >> 6) & 0x01).ToString();//ok
            val = (f.Value[1] >> 6) & 0x03;
            statusSundance.CirculationMode = val == 0x03 ? "Manuel" : val == 0x01 ? "Auto" : "Stop";//ok
            statusSundance.Heat = ((f.Value[10] >> 6) & 0x01).ToString();
            val = f.Value[6];
            statusSundance.HeatMode = val == 0x20 ? "Auto" : val == 0x22 ? "Eco" : val == 0x24 ? "Jour" : "---";
            statusSundance.Flowswitch = "---";
            statusSundance.Display = "---";
            val = ((f.Value[11] & 0x01) << 8) + f.Value[13];
            statusSundance.Clearray = val.ToString();

            val = (f.Value[7] & 0x06) >> 1;
            StatusSundance.Filter2 = val == 0 ? "Eliminer": val == 1 ? "Rare" : val == 2 ? "Fréquent" : "---";
        }

        public void Parse_0xCA_Light(frame f)
        {
            statusSundance = new Status();
            int val;
            //statusSundance.LightBrightnes = f.Value[0].ToString();
            statusSundance.LightBrightnes   = f.Value[1].ToString();
            statusSundance.LightB           = f.Value[2].ToString();
            //statusSundance.LightBrightnes = f.Value[3].ToString();
            statusSundance.LightMode        = f.Value[4].ToString();
            //statusSundance.LightBrightnes = f.Value[5].ToString();
            statusSundance.LightG           = f.Value[6].ToString();
            //statusSundance.LightBrightnes = f.Value[7].ToString();
            statusSundance.LightR           = f.Value[8].ToString();
            statusSundance.LightCycleTime   = f.Value[9].ToString();
        }
    }
    class serial
    {
        frame _frame;
        int index = 0;
        private List<frame> frameList;

        private SerialPort sp = new SerialPort();

        public SerialPort SerialPort { get => sp; set => sp = value; }


        byte[] message;
        public string Message
        {
            get { return BitConverter.ToString(message); }
        }

        byte[] response;
        public string Response
        {
            get { return BitConverter.ToString(response); }
        }

        public List<frame> FrameList { get => frameList; set => frameList = value; }

        bool start = false;

        #region Constructor / Deconstructor
        public serial()
        {
            frameList = new List<frame>();
        }
        ~serial()
        {
        }
        #endregion
        
        public bool Open(string portName, int baudRate, int databits, Parity parity, StopBits stopBits)
        {
            //Ensure port isn't already opened:
            if (!sp.IsOpen)
            {
                //Assign desired settings to the serial port:
                sp.PortName = portName;
                sp.BaudRate = baudRate;
                sp.DataBits = databits;
                sp.Parity = parity;
                sp.StopBits = stopBits;
                //These timeouts are default and cannot be editted through the class at this point:
                sp.ReadTimeout = 1000;
                sp.WriteTimeout = 1000;

                try
                {
                    sp.Open();
                }
                catch (Exception err)
                {
                    return false;
                }

                sp.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Close()
        {
            //Ensure port is opened before attempting to close:
            if (sp.IsOpen)
            {
                try
                {
                    sp.DataReceived -= new SerialDataReceivedEventHandler(port_DataReceived);
                    sp.Close();
                }
                catch (Exception err)
                {
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp.IsOpen)
            {
                GetFrame();
            }
        }
        #region Get Response
        public void GetFrame()
        {
            char c;
            string hexString;
            while (sp.BytesToRead > 0)
            {
                c = (char)sp.ReadByte();
                hexString = Convert.ToByte(c).ToString("x2").ToUpper();
                if (c == 0x7E && start == false && index == 0)
                {
                    _frame = new frame();
                    start = true;
                    index++;
                    _frame.Rawframe = hexString;
                    _frame.Rawframe += ";";
                }
                else if (c == 0x7E && start == true && index == _frame.Length + 1 && _frame.Length > 0)
                {
                    start = false;
                    index = 0;
                    _frame.Rawframe += hexString;
                    frame addframe = new frame();
                    addframe.Data = new List<byte>();
                    addframe.Value = new List<byte>();
                    addframe.Type = _frame.Type;
                    addframe.Length = _frame.Length;
                    addframe.Channel = _frame.Channel;
                    addframe.Rawframe = _frame.Rawframe;
                    if (_frame.Length > 5)
                    {
                        _frame.Value = new List<byte>();
                        int l = _frame.Data.Count();
                        for (int i = 0; i < l - 1; i += 2)
                        {
                            addframe.Data.Add(_frame.Data[i]);
                            addframe.Data.Add(_frame.Data[i + 1]);
                            int val1 = _frame.Data[i];
                            int val2 = _frame.Data[i + 1];
                            int val = val1 ^ val2 ^ 1;
                            addframe.Value.Add(Convert.ToByte(val));
                        }
                    }
                    frameList.Add(addframe);
                }
                else if (start == true && index == 1)
                {
                    _frame.Length = Convert.ToByte(c);
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index == 2)
                {
                    _frame.Channel = Convert.ToByte(c);
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index == 4)
                {
                    _frame.Type = Convert.ToByte(c);
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index == _frame.Length)
                {
                    _frame.Crc = Convert.ToByte(c);
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index > _frame.Length + 1)
                {
                    start = false;
                    index = 0;
                }
                else if (start == true && index == 5)
                {
                    _frame.Data = new List<byte>();
                    _frame.Data.Add(Convert.ToByte(c));
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index == _frame.Length)
                {
                    _frame.Crc = Convert.ToByte(c);
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true && index > 5)
                {
                    _frame.Data.Add(Convert.ToByte(c));
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
                else if (start == true)
                {
                    _frame.Rawframe += hexString;
                    _frame.Rawframe += ";";
                    index++;
                }
            }
        }

        #endregion

    }
}
