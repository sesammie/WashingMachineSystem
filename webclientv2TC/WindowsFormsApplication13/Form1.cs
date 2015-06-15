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
        /// <summary>
        /// /TODO  TESTEN
        /// </summary>
         Serialclass serialbinclass;
       Serialclass serialcardclass;
        ServiceReference1.Service1Client proxy;
        int seconds;
        public Form1()
        {
            InitializeComponent();
            serialbinclass=new Serialclass(null);
            serialcardclass=new Serialclass(this);
            proxy = new ServiceReference1.Service1Client();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ///
            //TESTSTE
            listBox2.Items.Clear();
            int index = 0;
            label2.Text = proxy.GetWash().program.Name;
          
            while (index < proxy.GetWash().Garmentlist.Count())
            {
                listBox2.Items.Add(proxy.GetWash().Garmentlist[index].GarmentId);
                index++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            
            timer1.Enabled = true;
            seconds = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            serialbinclass.StartSerialConnection(textBox1.Text);
              
        }

        private void button6_Click(object sender, EventArgs e)
        {
            serialbinclass.StartSerialConnection(textBox2.Text);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            while (index < proxy.GetAllPrograms().Count())
            {
                listBox1.Items.Add(proxy.GetAllPrograms()[index].Name);
                index++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = 0;
            while(index<proxy.GetAllPrograms().Count())
            {
                listBox1.Items.Add(proxy.GetAllPrograms()[index].Name);
                index++;
            }
        }
        public void sendclothdata(string data)
        {
            Console.WriteLine(data);
            proxy.SendReceivedString(data,"Washer");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (seconds < 60)
            {
                if (seconds == 0)
                {
                    serialbinclass.SerialWrite("#DEURSLOT_AAN%");
                   
                }
                if (seconds == 1)
                {
                    serialbinclass.SerialWrite("#WATERSLOT_AAN%");

                }
                if (seconds == 2)
                {
                    serialbinclass.SerialWrite("#WATERPOMP_AAN%");
                   
                }
                if (seconds == 10)
                {
                    serialbinclass.SerialWrite("#WATERPOMP_UIT%");
                    
                }
                if (seconds == 11)
                {
                    serialbinclass.SerialWrite("#WATERSLOT_UIT%");
                    
                }
                if (seconds == 12)
                {
                    serialbinclass.SerialWrite("#MOTOR_AAN%");
//serialbinclass.SerialWrite("#ZEEPKLEUR%");
                  //  serialbinclass.SerialWrite("#zeep_wit_uit%");
                    
                }
                if (seconds == 13)
                {

                    serialbinclass.SerialWrite("#VERWARMINGSELEMENT_AAN%");
                }
                if(seconds == 20)
                {
                  
                    serialbinclass.SerialWrite("#VERWARMINGSELEMENT_UIT%");
                   
                }
                 if(seconds == 21)
                {
                      serialbinclass.SerialWrite("#MOTOR_UIT%");
                    
                 }
                 if (seconds == 25)
                {
                    serialbinclass.SerialWrite("#DEURSLOT_UIT");
                }
                seconds++;
            }
            else
            {
                seconds = 0;
                timer1.Enabled = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
