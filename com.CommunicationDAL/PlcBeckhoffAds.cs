using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace com.CommunicationDAL
{
   //倍福
   public class PlcBeckhoffAds
    {
        private SerialPort FX;

        private int M_timeout;

        public int BaudRate
        {
            get
            {
                return this.FX.BaudRate;
            }
            set
            {
                this.FX.BaudRate = value;
            }
        }

        public int TimeOut
        {
            get
            {
                return this.FX.ReadTimeout;
            }
            set
            {
                this.FX.ReadTimeout = value;
                this.FX.WriteTimeout = value;
                this.M_timeout = checked((int)Math.Round((double)value / 2.0));
            }
        }

        public bool PortOpenState
        {
            get
            {
                return this.FX.IsOpen;
            }
        }

        public int CommPort
        {
            get
            {
                return checked((int)Math.Round(Conversion.Val(Strings.Mid(this.FX.PortName, 4, 1))));
            }
            set
            {
                if (this.FX.IsOpen)
                {
                    Information.Err().Raise(544, "", "The port has  opened !", null, null);
                }
                this.FX.PortName = "COM" + value.ToString();
            }
        }

        public PlcBeckhoffAds()
        {
            this.FX = new SerialPort();
            this.FX.ReadTimeout = 1000;
            this.FX.WriteTimeout = 1000;
            this.M_timeout = 500;
            this.FX.BaudRate = 9600;
            this.FX.Parity = Parity.Even;
            this.FX.DataBits = 7;
            this.FX.StopBits = StopBits.One;
            this.FX.ReadBufferSize = 1024;
            this.FX.WriteBufferSize = 1024;
            this.FX.PortName = "COM1";
        }

        public void ClosePort()
        {
            if (this.FX.IsOpen)
            {
                this.FX.Close();
            }
        }

        public void OpenPort()
        {
            if (Mydog.IsPasswordWrong())
            {
                throw new ArgumentException("密码错误");
            }
            if (!this.FX.IsOpen)
            {
                this.FX.Open();
            }
        }

        public void Send(string Xstring)
        {
            if (!this.FX.IsOpen)
            {
                Information.Err().Raise(549, "", "ComPort Is Not Opened", null, null);
            }
            short num;
            byte[] array;
            short arg_4C_0;
            short num2;
            checked
            {
                num = (short)Strings.Len(Xstring);
                array = new byte[(int)(num + 3 + 1)];
                array[0] = 2;
                array[(int)(num + 1)] = 3;
                arg_4C_0 = 1;
                num2 = num;
            }
            for (short num3 = arg_4C_0; num3 <= num2; num3 += 1)
            {
                array[(int)num3] = checked((byte)Strings.Asc(Strings.Mid(Xstring, (int)num3, 1)));
            }
            int num4 = 0;
            short arg_74_0 = 1;
            //   short num5 = checked(num + 1);
            //for (short num3 = arg_74_0; num3 <= num5; num3 += 1)
            //{
            //    num4 = (checked(num4 + (int)array[(int)num3]) & 255);
            //}
            string str = string.Format("{0:X2}", num4);
            checked
            {
                array[(int)(num + 2)] = (byte)Strings.Asc(Strings.Mid(str, 1, 1));
                array[(int)(num + 3)] = (byte)Strings.Asc(Strings.Mid(str, 2, 1));
                this.FX.Write(array, 0, (int)(num + 4));
            }
        }

        private bool CheckSumError(ref byte[] datain, short n)
        {
            byte[] array = new byte[2];
            int num = 0;
            for (short num2 = 1; num2 <= n; num2 += 1)
            {
                num = (checked(num + (int)datain[(int)num2]) & 255);
            }
            string str = string.Format("{0:X2}", num);
            checked
            {
                array[0] = (byte)Strings.Asc(Strings.Mid(str, 1, 1));
                array[1] = (byte)Strings.Asc(Strings.Mid(str, 2, 1));
                return (array[0] == datain[(int)(n + 1)] & array[1] == datain[(int)(n + 2)]) && false;
            }
        }

        private string Exchange(string str1)
        {
            return Strings.Mid(str1, 3, 1) + Strings.Mid(str1, 4, 1) + Strings.Mid(str1, 1, 1) + Strings.Mid(str1, 2, 1);
        }

        private string DecToBinary(short Ascii)
        {
            int i = Conversions.ToInteger("&H" + Conversions.ToString(Strings.Chr((int)Ascii)));
            string text = "";
            while (i > 0)
            {
                text = (i % 2).ToString() + text;
                i /= 2;
            }
            int num = Strings.Len(text);
            if (num < 4)
            {
                text = new string('0', checked(4 - num)) + text;
            }
            return text;
        }

        private string TransAd(int type_, int Address_)
        {
            int num = Address_;
            checked
            {
                switch (type_)
                {
                    case 0:
                        {
                            string text = string.Format("{0:X4}", num);
                            return this.Exchange(text);
                        }
                    case 1:
                        {
                            if (num > 77)
                            {
                                num -= 20;
                            }
                            int num2 = (int)Math.Round(unchecked(Conversion.Fix((double)num / 10.0) * 2.0));
                            num = num + 4608 - num2;
                            string text = string.Format("{0:X4}", num);
                            return this.Exchange(text);
                        }
                    case 2:
                        {
                            if (num > 77)
                            {
                                num -= 20;
                            }
                            int num2 = (int)Math.Round(unchecked(Conversion.Fix((double)num / 10.0) * 2.0));
                            num = num + 3072 - num2;
                            string text = string.Format("{0:X4}", num);
                            return this.Exchange(text);
                        }
                    case 3:
                        {
                            string text;
                            if (num < 8000)
                            {
                                num = num * 2 + 16384;
                                text = string.Format("{0:X4}", num);
                            }
                            else
                            {
                                num -= 8000;
                                num = num * 2 + 3584;
                                text = string.Format("{0:X4}", num);
                            }
                            return text;
                        }
                    default:
                        return "";
                }
            }
        }

        private string TransAdForRead(int bittype, int bitad)
        {
            int num = bitad;
            checked
            {
                switch (bittype)
                {
                    case 0:
                        num = (int)Math.Round(Conversion.Fix((double)num / 8.0));
                        return string.Format("{0:X4}", num);
                    case 1:
                        if (num > 77)
                        {
                            num -= 20;
                        }
                        num = (int)Math.Round(Conversion.Fix((double)num / 10.0));
                        num += 576;
                        return string.Format("{0:X4}", num);
                    case 2:
                        if (num > 77)
                        {
                            num -= 20;
                        }
                        num = (int)Math.Round(Conversion.Fix((double)num / 10.0));
                        num += 384;
                        return string.Format("{0:X4}", num);
                    default:
                        return "";
                }
            }
        }

        public void Cwrite32(int Ad, int Data)
        {
            SerialPort fX = this.FX;
            lock (fX)
            {
                this.FX.DiscardInBuffer();
                this.FX.DiscardOutBuffer();
                short num = checked((short)((Ad - 200) * 4 + 3072));
                string text = string.Format("{0:X4}", num);
                string str = string.Format("{0:X8}", Data);
                string xstring = string.Concat(new string[]
                {
                    "E10",
                    text,
                    "04",
                    this.Exchange(Strings.Mid(str, 5, 4)),
                    this.Exchange(Strings.Left(str, 4))
                });
                this.Send(xstring);
                xstring = this.FX.ReadTo("\u0006");
                xstring = this.FX.ReadExisting();
            }
        }

        public void Dwrite16(int Ad, short Data)
        {
            SerialPort fX = this.FX;
            lock (fX)
            {
                this.FX.DiscardInBuffer();
                this.FX.DiscardOutBuffer();
                string str = string.Format("{0:X4}", Data);
                string xstring = "E10" + this.TransAd(3, Ad) + "02" + this.Exchange(str);
                this.Send(xstring);
                xstring = this.FX.ReadTo("\u0006");
                xstring = this.FX.ReadExisting();
            }
        }

        public void Dwrite32(int Ad, int Data)
        {
            SerialPort fX = this.FX;
            lock (fX)
            {
                this.FX.DiscardInBuffer();
                this.FX.DiscardOutBuffer();
                string str = string.Format("{0:X8}", Data);
                string xstring = string.Concat(new string[]
                {
                    "E10",
                    this.TransAd(3, Ad),
                    "04",
                    this.Exchange(Strings.Mid(str, 5, 4)),
                    this.Exchange(Strings.Left(str, 4))
                });
                this.Send(xstring);
                xstring = this.FX.ReadTo("\u0006");
                xstring = this.FX.ReadExisting();
            }
        }

        public void BitWrite(int BitType, int BitAd, bool AtOn)
        {
            SerialPort fX = this.FX;
            lock (fX)
            {
                this.FX.DiscardInBuffer();
                this.FX.DiscardOutBuffer();
                string xstring;
                if (AtOn)
                {
                    xstring = "E7" + this.TransAd(BitType, BitAd);
                }
                else
                {
                    xstring = "E8" + this.TransAd(BitType, BitAd);
                }
                this.Send(xstring);
                xstring = this.FX.ReadTo("\u0006");
                xstring = this.FX.ReadExisting();
            }
        }

        public int Dread32(int Ad)
        {
            SerialPort fX = this.FX;
            checked
            {
                int result;
                lock (fX)
                {
                    byte[] array = new byte[12];
                    int num = 0;
                    this.FX.DiscardInBuffer();
                    this.FX.DiscardOutBuffer();
                    string text = "E00" + this.TransAd(3, Ad) + "04";
                    this.Send(text);
                    do
                    {
                        Thread.Sleep(2);
                        num++;
                        if (num > this.M_timeout)
                        {
                            Information.Err().Raise(531, "", "Communication Err", null, null);
                        }
                    }
                    while (this.FX.BytesToRead < 12);
                    this.FX.Read(array, 0, 12);
                    text = Conversions.ToString(Strings.Chr((int)array[3])) + Conversions.ToString(Strings.Chr((int)array[4])) + Conversions.ToString(Strings.Chr((int)array[1])) + Conversions.ToString(Strings.Chr((int)array[2]));
                    text = string.Concat(new string[]
                    {
                        Conversions.ToString(Strings.Chr((int)array[7])),
                        Conversions.ToString(Strings.Chr((int)array[8])),
                        Conversions.ToString(Strings.Chr((int)array[5])),
                        Conversions.ToString(Strings.Chr((int)array[6])),
                        text
                    });
                    result = Convert.ToInt32(text, 16);
                }
                return result;
            }
        }

        public short Dread16(int Ad)
        {
            SerialPort fX = this.FX;
            checked
            {
                short result;
                lock (fX)
                {
                    byte[] array = new byte[8];
                    int num = 0;
                    this.FX.DiscardInBuffer();
                    this.FX.DiscardOutBuffer();
                    string text = "E00" + this.TransAd(3, Ad) + "02";
                    this.Send(text);
                    do
                    {
                        Thread.Sleep(2);
                        num++;
                        if (num > this.M_timeout)
                        {
                            Information.Err().Raise(531, "", "Communication Err", null, null);
                        }
                    }
                    while (this.FX.BytesToRead < 8);
                    this.FX.Read(array, 0, 8);
                    if (this.CheckSumError(ref array, 5))
                    {
                        Information.Err().Raise(531, "", "Communication Err", null, null);
                    }
                    text = Conversions.ToString(Strings.Chr((int)array[3])) + Conversions.ToString(Strings.Chr((int)array[4])) + Conversions.ToString(Strings.Chr((int)array[1])) + Conversions.ToString(Strings.Chr((int)array[2]));
                    result = Convert.ToInt16(text, 16);
                }
                return result;
            }
        }

        public bool BitRead(int BitType, int BitAd)
        {
            SerialPort fX = this.FX;
            checked
            {
                bool result;
                lock (fX)
                {
                    byte[] array = new byte[6];
                    int num = 0;
                    this.FX.DiscardInBuffer();
                    this.FX.DiscardOutBuffer();
                    this.Send("E00" + this.TransAdForRead(BitType, BitAd) + "01");
                    do
                    {
                        Thread.Sleep(2);
                        num++;
                        if (num > this.M_timeout)
                        {
                            Information.Err().Raise(531, "", "Communication Err", null, null);
                        }
                    }
                    while (this.FX.BytesToRead < 6);
                    this.FX.Read(array, 0, 6);
                    string str = this.DecToBinary((short)array[1]) + this.DecToBinary((short)array[2]);
                    short num2;
                    if (BitType == 0)
                    {
                        num2 = (short)(BitAd % 8);
                    }
                    else
                    {
                        num2 = (short)Math.Round(Conversion.Val(Strings.Right(Conversions.ToString(BitAd), 1)));
                    }
                    result = Conversions.ToBoolean(Strings.Mid(str, (int)(8 - num2), 1));
                }
                return result;
            }
        }

    }
}
