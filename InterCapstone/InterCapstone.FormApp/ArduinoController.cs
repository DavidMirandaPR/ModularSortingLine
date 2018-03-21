using System;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace InterCapstone.FormApp
{
    public class ArduinoController
    {

        public SerialPort currentPort;
        public string[] ports;
        public bool portFound;

        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

        public void SetComPort()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                this.ports = ports;
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, 9600);
                    if (DetectArduino())
                    {
                        portFound = true;
                        break;
                    }
                    else
                    {
                        portFound = false;
                    }
                }
            }
            catch (Exception e)
            {
            }
        }

        public bool DetectArduino()
        {
            int bufferSize = 10;
            byte[] buffer = new byte[] { Convert.ToByte(16), Convert.ToByte(128), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0) };

            try
            {
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                this.currentPort.Open();
                this.currentPort.Write(buffer, 0, bufferSize);
                Thread.Sleep(1000);
                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                var PortName = returnMessage;
                currentPort.Close();
                if (returnMessage.Contains("CONNECTED"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool SendCommandToArduino()
        {
            return true;
        }
        public bool SendCommandToPin(string COMMAND, int PIN)
        {
            int bufferSize = 10;
            byte[] buffer = new byte[bufferSize];
            switch (COMMAND)
            {
                case "HIGH":
                    buffer = new byte[] { Convert.ToByte(16), Convert.ToByte(127), Convert.ToByte(4), Convert.ToByte(255), Convert.ToByte(PIN), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0) };
                    break;
                case "LOW":
                    buffer = new byte[] { Convert.ToByte(16), Convert.ToByte(127), Convert.ToByte(4), Convert.ToByte(0), Convert.ToByte(PIN), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0), Convert.ToByte(0) };
                    break;
            }
            try
            {
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                this.currentPort.Open();
                this.currentPort.Write(buffer, 0, bufferSize);
                Thread.Sleep(1000);
                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }
                var PortName = returnMessage;
                currentPort.Close();
                if (returnMessage.Contains("READY TO RECEIVE"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }


    }
}