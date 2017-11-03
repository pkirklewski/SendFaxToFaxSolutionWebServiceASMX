using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SendPDFtoWebService;
using System.IO;


namespace SendPDFtoWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendPDFtoWebService.SendPdfToWebService.SendFaxGateway spdf = new SendPdfToWebService.SendFaxGateway();
            
           // object[] docBytes = new object[1];
            var doc = File.ReadAllBytes(textBox2.Text);
            
            var res = spdf.CaptureFile(textBox1.Text, doc);
            int x = 1;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
