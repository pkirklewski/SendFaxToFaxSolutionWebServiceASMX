using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using Microsoft.Xml.XMLGen;

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

                var doc = File.ReadAllBytes(textBoxDoc1.Text);

                callWebService(textBoxDestination.Text, Convert.ToBase64String(doc));
                //spdf.CaptureFileAsync(textBox1.Text, doc,"");

                int x = 1;
            }
        }

        private void callWebService(string faxNumber, string doc)
        {
            using (ENGIEWebClient client = new ENGIEWebClient())
            { //
                client.Headers.Add("SOAPAction", "\"http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0/SendFAX");
                client.Headers.Add("Content-Type", "text/xml; charset=utf-8");
                //client.Headers.Add("Host", "localhost");

                var payload = "<?xml version=\"1.0\" encoding=\"utf-8\"?><soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\"><soap:Body><SendFAX xmlns=\"http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0/\"><faxNumber>" + faxNumber + "</faxNumber><DocumentContent>" + doc + "</DocumentContent></SendFAX></soap:Body></soap:Envelope>";
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

            if (textBoxDoc1.Text.Contains(".pdf")) 
            {
                comboDocumentType.SelectedIndex = 0;
            }

            if (textBoxDoc1.Text.Contains(".xhtml"))
            {
                comboDocumentType.SelectedIndex = 1;
            }

            if (textBoxDoc1.Text.Contains(".doc"))
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

            comboSeqNumber1.Items.Add(1);
            comboSeqNumber1.Items.Add(2);
            comboSeqNumber1.Items.Add(3);
            comboSeqNumber1.Items.Add(4);
            comboSeqNumber1.Items.Add(5);
            comboSeqNumber1.Items.Add(6);
            comboSeqNumber1.Items.Add(7);
            comboSeqNumber1.Items.Add(8);
            comboSeqNumber1.Items.Add(9);
            comboSeqNumber1.SelectedIndex = comboSeqNumber.SelectedIndex + 1;

            comboDocumentType.Items.Add("PDF");
            comboDocumentType.Items.Add("xHTML");
            comboDocumentType.Items.Add("MSDOC");
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
           //comboSeqNumber1.SelectedIndex = comboSeqNumber.SelectedIndex + 1;
            //comboSeqNumber1.Refresh();
            
            //< xs:element minOccurs = "1" maxOccurs = "1" name = "SeqNumber" type = "xs:positiveInteger" >
            //< xs:documentation > Description: This identifies the sequence of the document to be sent. The allowed value is of type xs: positiveInteger and starts from 1.
            //The order of printing is from lowest seq number to highest seq number, ie. The document having lowest sequence number need to be printed first and so on.  </ xs:documentation >
        }

        private void comboSeqNumber_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //comboSeqNumber1.SelectedIndex = comboSeqNumber.SelectedIndex + 1;

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
            //MessageBox.Show(comboDocumentType.SelectedIndex.ToString());
            //MessageBox.Show(comboDocumentType.SelectedItem.ToString());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string t1 = DateTime.Now.ToString().Replace(@"/", "").Replace(" ", "").Replace(":", "");
            XmlTextWriter textWriter = new XmlTextWriter(t1 + ".xml", null);
            textWriter.Formatting = Formatting.Indented;
            XmlQualifiedName  qname = new XmlQualifiedName("SendFAX", "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0");
            XmlSampleGenerator generator = new XmlSampleGenerator("..\\..\\XSDs\\FAXGateway.xsd", qname);
            generator.WriteXml(textWriter);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendOutboundFAXType sendOutboundFAX = new SendOutboundFAXType();
            sendOutboundFAX.UserName = uName.Text;
            sendOutboundFAX.PassWord = passWord.Text;
            sendOutboundFAX.Destination = textBoxDestination.Text.ToString();
            sendOutboundFAX.Priority = comboPriority.SelectedText.ToString();
            sendOutboundFAX.Receipt = Receipt.Text;
            sendOutboundFAX.Sender = SenderFaxNumber.ToString();
            sendOutboundFAX.FaxRequestDateTime = FaxRequestDateTime.ToString();
            //sendOutboundFAX.Documents = textBoxDoc1.Text;
            Document doc01 = new Document();
            doc01.SeqNumber = comboSeqNumber.SelectedItem.ToString();
            doc01.DocumentId = textBoxDocumentId.Text.ToString();
            // doc01.DocumentType ========================================================
            if (comboDocumentType.SelectedItem.Equals(0))
            {
                doc01.DocumentType = DocumentType.PDF;
            }
            if (comboDocumentType.SelectedItem.Equals(1))
            {
                doc01.DocumentType = DocumentType.xHTML;
            }
            if (comboDocumentType.SelectedItem.Equals(2))
            {
                doc01.DocumentType = DocumentType.MSDOC;
            }
            // doc01.DocumentType ========================================================
            doc01.DocumentContent = File.ReadAllBytes(textBoxDoc1.Text);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SendOutboundFAXType sof = new SendOutboundFAXType();

            sof.UserName = uName.Text;
            sof.PassWord = passWord.Text;
            sof.Destination = textBoxDestination.Text.ToString();
            sof.Priority = comboPriority.SelectedItem.ToString();
            sof.Receipt = Receipt.Text;
            sof.Sender = SenderFaxNumber.Text.ToString();
            sof.FaxRequestDateTime = FaxRequestDateTime.ToString();

            Document doc01 = new Document();
            doc01.SeqNumber = comboSeqNumber.SelectedItem.ToString();
            doc01.DocumentId = textBoxDocumentId.Text.ToString();

            // doc01.DocumentType ========================================================
            if (comboDocumentType.SelectedItem.Equals(0))
            {
                doc01.DocumentType =  DocumentType.PDF;
            }
            if (comboDocumentType.SelectedItem.Equals(1))
            {
                doc01.DocumentType = DocumentType.xHTML;
            }
            if (comboDocumentType.SelectedItem.Equals(2))
            {
                doc01.DocumentType = DocumentType.MSDOC;
            }
            // doc01.DocumentType ========================================================

            doc01.DocumentContent = File.ReadAllBytes(textBoxDoc1.Text);
            sof.Documents = new[] {

                doc01
            };

            //MessageBox.Show(doc01.DocumentContent.ToString());
            //int a = 1;

            int i = 1;


        }

        private void comboSeqNumber1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboSeqNumber1.SelectedIndex = comboSeqNumber.SelectedIndex + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboSeqNumber.Refresh();
            comboSeqNumber1.Refresh();
        }
    }
}




