
namespace VMExpertiseXMLGenerator
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.xmlsoap.org/soap/envelope/", IsNullable = false)]
    public partial class Envelope
    {

        private object headerField;

        private EnvelopeBody bodyField;

        /// <remarks/>
        public object Header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public EnvelopeBody Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public partial class EnvelopeBody
    {

        private SendFAX sendFAXField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/SendFaxGatewayWebService/1.0")]
        public SendFAX SendFAX
        {
            get
            {
                return this.sendFAXField;
            }
            set
            {
                this.sendFAXField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/SendFaxGatewayWebService/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/SendFaxGatewayWebService/1.0", IsNullable = false)]
    public partial class SendFAX
    {

        private SendOutboundFAX sendOutboundFAXField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0")]
        public SendOutboundFAX SendOutboundFAX
        {
            get
            {
                return this.sendOutboundFAXField;
            }
            set
            {
                this.sendOutboundFAXField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0", IsNullable = false)]
    public partial class SendOutboundFAX
    {

        private string userNameField;

        private string passWordField;

        private string destinationField;

        private string priorityField;

        private string receiptField;

        private string senderField;

        private string faxRequestDateTimeField;

        private SendOutboundFAXDocument[] documentsField;

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string PassWord
        {
            get
            {
                return this.passWordField;
            }
            set
            {
                this.passWordField = value;
            }
        }

        /// <remarks/>
        public string Destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public string Receipt
        {
            get
            {
                return this.receiptField;
            }
            set
            {
                this.receiptField = value;
            }
        }

        /// <remarks/>
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        public string FaxRequestDateTime
        {
            get
            {
                return this.faxRequestDateTimeField;
            }
            set
            {
                this.faxRequestDateTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Document", IsNullable = false)]
        public SendOutboundFAXDocument[] Documents
        {
            get
            {
                return this.documentsField;
            }
            set
            {
                this.documentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.childmaintenance.gsi.gov.uk/futurescheme/outboundCorrespondence/faxgateway/1.0")]
    public partial class SendOutboundFAXDocument
    {

        private string seqNumberField;

        private string documentIdField;

        private string documentTypeField;

        private byte[] documentContentField;

        /// <remarks/>
        public string SeqNumber
        {
            get
            {
                return this.seqNumberField;
            }
            set
            {
                this.seqNumberField = value;
            }
        }

        /// <remarks/>
        public string DocumentId
        {
            get
            {
                return this.documentIdField;
            }
            set
            {
                this.documentIdField = value;
            }
        }

        /// <remarks/>
        public string DocumentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        public byte[] DocumentContent
        {
            get
            {
                return this.documentContentField;
            }
            set
            {
                this.documentContentField = value;
            }
        }
    }

}