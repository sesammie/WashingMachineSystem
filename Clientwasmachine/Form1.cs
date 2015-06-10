using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {

       // public List<ServiceReference1.Program> Procuctlist = new List<WebshopContract.Item>();
        ServiceReference1.Service1Client proxy = new ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            Console.WriteLine( Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            ModeLabel.Text = "Mode: Manual";
            WashtypelistBox.Items.Clear();
           
            
            for (int i = 0; i < proxy.GetAllPrograms().Count(); i++)
            {

                //SoaplistBox.Items.Add(proxy.GetDetergentList()[i]);
                WashtypelistBox.Items.Add(proxy.GetAllPrograms()[i].Name);
            }
             /*
            for (int i = 0; i < proxy.count; i++)
            {
                ProgramListBox.Items.Add();
            }
            for (int i = 0; i < proxy.count; i++)
            {
                ProgramListBox.Items.Add();
            }
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeLabel.Text = "Mode: Automatic";
            btnStart.Enabled = true;
            WashtypelistBox.Items.Clear();
             
         
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void SoaplistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
     
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
namespace serial
{
    class SerialClass
    {
        SerialPort serialPort;

        public void StartSerialConnection(string portName)
        {
            serialPort = new SerialPort();
            serialPort.PortName = portName;
            serialPort.BaudRate = 9600;
            serialPort.Open();
        }
        public void SerialWrite(string Message)
        {
            Console.WriteLine("sended");
            if(serialPort!=null)
            {
            serialPort.Write(Message);
            }
        }
        public void ReceiveMsg()
        {
            Console.WriteLine("received");
            if (serialPort.BytesToRead > 0)
            {
                string s = serialPort.ReadLine();
                Console.WriteLine(s);
            }
        }

    }
}

*/