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
    public partial class Destination : Form
    {
        public Destination()
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
            using (ENGIEWebClient client = new ENGIEWebClient())
            {
                client.Headers.Add("SOAPAction", "\"http://tempuri.org/CaptureFile\"");
                client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
                //client.Headers.Add("Host", "localhost");

                var payload = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body><CaptureFile xmlns=\"http://tempuri.org/\"><faxNumber>" + faxNumber + "</faxNumber><DocumentContent>" + doc + "</DocumentContent></CaptureFile></soap:Body></soap:Envelope>";
                var data = Encoding.UTF8.GetBytes(payload);

                //To call other server, please change the url on the App Settings: <add key="webService" value="http://localhost:8087/SendFaxGateway.asmx"/>
                var result = client.UploadData(System.Configuration.ConfigurationManager.AppSettings["webService"], data);
                if (client.StatusCode() == HttpStatusCode.OK)
                {
                    MessageBox.Show(Encoding.Default.GetString(result));
                }

            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //<xs:documentation>Description: This identifies the list of documents to be sent as FAX.</xs:documentation>
            // < xs:element minOccurs = "1" maxOccurs = "1" name = "Documents" type = "fax:Documents" />
            //<xs:element name="Document" type="fax:Document" minOccurs="1" maxOccurs="unbounded"/>

            if (textBox2.Text.Contains(".pdf")) 
            {
                comboDocumentType.SelectedIndex = 0;
            }

            if (textBox2.Text.Contains(".xhtml"))
            {
                comboDocumentType.SelectedIndex = 1;
            }

            if (textBox2.Text.Contains(".doc"))
            {
                comboDocumentType.SelectedIndex = 2;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uName_TextChanged(object sender, EventArgs e)
        {
            //Description: This identifies the username assigned to CMEC Account. 
            //<xs:element minOccurs="0" maxOccurs="1" name="UserName" type="xs:string">
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "0" maxOccurs = "1" name = "PassWord" type = "xs:string" >
            // Description: This identifies the password corresponding to username.</ xs:documentation >
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            //<xs:element minOccurs="1" maxOccurs="1" name="Destination" type="xs:string">
            // < xs:documentation > Description: This identifies the destination FAX number.</ xs:documentation >


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "0" maxOccurs = "1" name = "Receipt" type = "xs:string" >
            //< xs:documentation > Description: This is a placeholder.</ xs:documentation >

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "0" maxOccurs = "1" name = "Priority" type = "fax:PriorityType" >
            //< xs:documentation > Description: This identifies the priority of FAX. The allowed values are from 1 - 9, where 1 is highest priority and 9 is lowest priority. </ xs:documentation >
        }

        private void Destination_Load(object sender, EventArgs e)
        {
            comboPriority.Items.Add(1);
            comboPriority.Items.Add(2);
            comboPriority.Items.Add(3);
            comboPriority.Items.Add(4);
            comboPriority.Items.Add(5);
            comboPriority.Items.Add(6);
            comboPriority.Items.Add(7);
            comboPriority.Items.Add(8);
            comboPriority.Items.Add(9);
            comboPriority.SelectedIndex = 0;


            comboSeqNumber.Items.Add(1);
            comboSeqNumber.Items.Add(2);
            comboSeqNumber.Items.Add(3);
            comboSeqNumber.Items.Add(4);
            comboSeqNumber.Items.Add(5);
            comboSeqNumber.Items.Add(6);
            comboSeqNumber.Items.Add(7);
            comboSeqNumber.Items.Add(8);
            comboSeqNumber.Items.Add(9);
            comboSeqNumber.SelectedIndex = 0;


            comboDocumentType.Items.Add("PDF");
            comboDocumentType.Items.Add("xHTML");
            comboDocumentType.Items.Add("MS-Doc");
            comboDocumentType.SelectedIndex = 0;

        }

        private void textBox3_TextChanged_2(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "1" maxOccurs = "1" name = "Sender" type = "xs:string" >
            //< xs:documentation > Description: This identifies the Sender FAX number. </ xs:documentation >
        }

        private void textBox3_TextChanged_3(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "1" maxOccurs = "1" name = "FaxRequestDateTime" type = "xs:string" >
            //< xs:documentation > Description: This identifies the Date and Time when FAX has sent to Contractor from CMEC.

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //< xs:element minOccurs = "1" maxOccurs = "1" name = "SeqNumber" type = "xs:positiveInteger" >
            //< xs:documentation > Description: This identifies the sequence of the document to be sent. The allowed value is of type xs: positiveInteger and starts from 1.
            //The order of printing is from lowest seq number to highest seq number, ie. The document having lowest sequence number need to be printed first and so on.  </ xs:documentation >
        }

        private void textBoxDocumentId_TextChanged(object sender, EventArgs e)
        {
                        //< xs:element minOccurs = "1" maxOccurs = "1" name = "DocumentId" type = "xs:string" >
                        //< xs:documentation > Description: This identifies the identification number of an individual document.</ xs:documentation >
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
