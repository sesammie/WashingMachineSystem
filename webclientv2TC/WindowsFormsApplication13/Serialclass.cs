using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
namespace WindowsFormsApplication13
{
    class Serialclass
    {

        SerialPort serialPort;
        Form1 form;
        public Serialclass(Form1 form)
        {
            this.form = form;
        }
        public void StartSerialConnection(string portName)
        {
            serialPort = new SerialPort();
            serialPort.PortName = portName;
            serialPort.BaudRate = 9600;
            serialPort.Open();
            if (serialPort.IsOpen)
            {
                Console.WriteLine("open");

            }
            else
            {
                Console.WriteLine("notopen");
            }

            serialPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

        }
        public void SerialWrite(string Message)
        {
           
            if (serialPort != null)
            {
                Console.WriteLine("sended");
                serialPort.Write(Message);
            }
        }
 

        public void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.BytesToRead > 0)
            {
                string s = serialPort.ReadLine();
              //  Console.WriteLine(s);
                if(form!=null)
                {
                    Console.WriteLine(s);
                    form.sendclothdata(s);
                }
            }

        }
    }
}
