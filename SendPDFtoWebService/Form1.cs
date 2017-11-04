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
using System.Net;
using System.Xml;

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
            using (SendPDFtoWebService.SendPdfToWebService.SendFaxGateway spdf = new SendPdfToWebService.SendFaxGateway())
            {

                // object[] docBytes = new object[1];

                var doc = File.ReadAllBytes(textBox2.Text);

                callWebService(textBox1.Text, Convert.ToBase64String(doc));
                //spdf.CaptureFileAsync(textBox1.Text, doc,"");

                int x = 1;
            }
        }

        


        private void callWebService(string faxNumber, string doc)
        {
            using (VMExpertiseWebClient client = new VMExpertiseWebClient())
            {
                client.Headers.Add("SOAPAction", "\"http://tempuri.org/CaptureFile\"");
                client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
                //client.Headers.Add("Host", "localhost");

                var payload = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body><CaptureFile xmlns=\"http://tempuri.org/\"><faxNumber>"+faxNumber+"</faxNumber><DocumentContent>"+doc+"</DocumentContent></CaptureFile></soap:Body></soap:Envelope>";
                var data = Encoding.UTF8.GetBytes(payload);
                var result = client.UploadData("http://localhost:8087/SendFaxGateway.asmx", data);
                if (client.StatusCode() == HttpStatusCode.OK)
                {

                }
                                
            }
        }
        
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
