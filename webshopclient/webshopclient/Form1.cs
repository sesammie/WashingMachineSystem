using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webshopclient
{  
    public partial class Form1 : Form
    {
        private Service.Service1Client proxy;
        public Form1()
        {
            InitializeComponent();
            proxy = new Service.Service1Client();
        }

        private void BtnAddClothes_Click(object sender, EventArgs e)
        {
            proxy.x();
        }


    }
}
