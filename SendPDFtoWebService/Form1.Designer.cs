namespace SendPDFtoWebService
{
    partial class Destination
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Receipt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passWord = new System.Windows.Forms.TextBox();
            this.SenderFaxNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FaxRequestDateTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSeqNumber = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxDocumentId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboDocumentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "SendPDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "+441923396735";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "C:\\pdf-sample.pdf";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "UserName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(124, 18);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(170, 20);
            this.uName.TabIndex = 4;
            this.uName.TextChanged += new System.EventHandler(this.uName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Destination";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Receipt
            // 
            this.Receipt.Location = new System.Drawing.Point(124, 126);
            this.Receipt.Name = "Receipt";
            this.Receipt.Size = new System.Drawing.Size(170, 20);
            this.Receipt.TabIndex = 10;
            this.Receipt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Receipt";
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(124, 99);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(170, 21);
            this.comboPriority.TabIndex = 11;
            this.comboPriority.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Priority";
            // 
            // passWord
            // 
            this.passWord.Location = new System.Drawing.Point(124, 44);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(170, 20);
            this.passWord.TabIndex = 6;
            this.passWord.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SenderFaxNumber
            // 
            this.SenderFaxNumber.Location = new System.Drawing.Point(124, 152);
            this.SenderFaxNumber.Name = "SenderFaxNumber";
            this.SenderFaxNumber.Size = new System.Drawing.Size(170, 20);
            this.SenderFaxNumber.TabIndex = 13;
            this.SenderFaxNumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged_2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sender";
            // 
            // FaxRequestDateTime
            // 
            this.FaxRequestDateTime.Location = new System.Drawing.Point(124, 178);
            this.FaxRequestDateTime.Name = "FaxRequestDateTime";
            this.FaxRequestDateTime.Size = new System.Drawing.Size(170, 20);
            this.FaxRequestDateTime.TabIndex = 15;
            this.FaxRequestDateTime.TextChanged += new System.EventHandler(this.textBox3_TextChanged_3);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "FaxRequestDateTime";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Document";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboSeqNumber
            // 
            this.comboSeqNumber.FormattingEnabled = true;
            this.comboSeqNumber.Location = new System.Drawing.Point(127, 230);
            this.comboSeqNumber.Name = "comboSeqNumber";
            this.comboSeqNumber.Size = new System.Drawing.Size(170, 21);
            this.comboSeqNumber.TabIndex = 17;
            this.comboSeqNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "SeqNumber";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(300, 204);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "C:\\pdf-sample1.pdf";
            // 
            // textBoxDocumentId
            // 
            this.textBoxDocumentId.Location = new System.Drawing.Point(127, 257);
            this.textBoxDocumentId.Name = "textBoxDocumentId";
            this.textBoxDocumentId.Size = new System.Drawing.Size(170, 20);
            this.textBoxDocumentId.TabIndex = 21;
            this.textBoxDocumentId.Text = "001";
            this.textBoxDocumentId.TextChanged += new System.EventHandler(this.textBoxDocumentId_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "DocumentId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "DocumentType";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboDocumentType
            // 
            this.comboDocumentType.FormattingEnabled = true;
            this.comboDocumentType.Location = new System.Drawing.Point(127, 287);
            this.comboDocumentType.Name = "comboDocumentType";
            this.comboDocumentType.Size = new System.Drawing.Size(170, 21);
            this.comboDocumentType.TabIndex = 23;
            this.comboDocumentType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // Destination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.comboDocumentType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDocumentId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboSeqNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FaxRequestDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SenderFaxNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.Receipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Destination";
            this.Text = "CMG";
            this.Load += new System.EventHandler(this.Destination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Receipt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.TextBox SenderFaxNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FaxRequestDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboSeqNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxDocumentId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboDocumentType;
    }
}

