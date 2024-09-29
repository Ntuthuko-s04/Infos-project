namespace PhumlaKamnandiSystem.Presentation
{
    partial class Payments_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PaymentDatedateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtInvoiceID = new System.Windows.Forms.TextBox();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnDisplayPayment = new System.Windows.Forms.Button();
            this.btnDisplayPay = new System.Windows.Forms.Button();
            this.CardDetails = new System.Windows.Forms.GroupBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblExpiriyDate = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.btnValidateCardInfo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.CardDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.PaymentDatedateTimePicker1);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtInvoiceID);
            this.groupBox1.Controls.Add(this.txtGuestName);
            this.groupBox1.Controls.Add(this.lblPaymentMethod);
            this.groupBox1.Controls.Add(this.lblPaymentDate);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblInvoiceID);
            this.groupBox1.Controls.Add(this.lblGuestName);
            this.groupBox1.Location = new System.Drawing.Point(24, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(440, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payments";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Credit Card",
            "Cash",
            "Loyalty Points"});
            this.comboBox1.Location = new System.Drawing.Point(172, 166);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // PaymentDatedateTimePicker1
            // 
            this.PaymentDatedateTimePicker1.Location = new System.Drawing.Point(172, 133);
            this.PaymentDatedateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PaymentDatedateTimePicker1.Name = "PaymentDatedateTimePicker1";
            this.PaymentDatedateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.PaymentDatedateTimePicker1.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(172, 96);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(68, 22);
            this.txtAmount.TabIndex = 7;
            // 
            // txtInvoiceID
            // 
            this.txtInvoiceID.Location = new System.Drawing.Point(172, 65);
            this.txtInvoiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceID.Name = "txtInvoiceID";
            this.txtInvoiceID.Size = new System.Drawing.Size(68, 22);
            this.txtInvoiceID.TabIndex = 6;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(172, 31);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(68, 22);
            this.txtGuestName.TabIndex = 5;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(15, 166);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(108, 16);
            this.lblPaymentMethod.TabIndex = 4;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(15, 133);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(92, 16);
            this.lblPaymentDate.TabIndex = 3;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(15, 96);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(52, 16);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Location = new System.Drawing.Point(15, 65);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(66, 16);
            this.lblInvoiceID.TabIndex = 1;
            this.lblInvoiceID.Text = "Invoice ID";
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(11, 31);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(82, 16);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(24, 282);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(436, 174);
            this.txtOutput.TabIndex = 1;
            // 
            // btnDisplayPayment
            // 
            this.btnDisplayPayment.Location = new System.Drawing.Point(39, 250);
            this.btnDisplayPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayPayment.Name = "btnDisplayPayment";
            this.btnDisplayPayment.Size = new System.Drawing.Size(144, 28);
            this.btnDisplayPayment.TabIndex = 2;
            this.btnDisplayPayment.Text = "Process Payment";
            this.btnDisplayPayment.UseVisualStyleBackColor = true;
            // 
            // btnDisplayPay
            // 
            this.btnDisplayPay.Location = new System.Drawing.Point(304, 250);
            this.btnDisplayPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayPay.Name = "btnDisplayPay";
            this.btnDisplayPay.Size = new System.Drawing.Size(89, 27);
            this.btnDisplayPay.TabIndex = 3;
            this.btnDisplayPay.Text = "Display Button";
            this.btnDisplayPay.UseVisualStyleBackColor = true;
            // 
            // CardDetails
            // 
            this.CardDetails.Controls.Add(this.txtCVV);
            this.CardDetails.Controls.Add(this.txtExpiryDate);
            this.CardDetails.Controls.Add(this.txtCardNumber);
            this.CardDetails.Controls.Add(this.lblCVV);
            this.CardDetails.Controls.Add(this.lblExpiriyDate);
            this.CardDetails.Controls.Add(this.lblCardNo);
            this.CardDetails.Location = new System.Drawing.Point(523, 18);
            this.CardDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardDetails.Name = "CardDetails";
            this.CardDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CardDetails.Size = new System.Drawing.Size(248, 128);
            this.CardDetails.TabIndex = 4;
            this.CardDetails.TabStop = false;
            this.CardDetails.Text = "Card Details";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(137, 105);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(68, 22);
            this.txtCVV.TabIndex = 5;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(137, 65);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(68, 22);
            this.txtExpiryDate.TabIndex = 4;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(137, 30);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(68, 22);
            this.txtCardNumber.TabIndex = 3;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(13, 92);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(34, 16);
            this.lblCVV.TabIndex = 2;
            this.lblCVV.Text = "CVV";
            // 
            // lblExpiriyDate
            // 
            this.lblExpiriyDate.AutoSize = true;
            this.lblExpiriyDate.Location = new System.Drawing.Point(13, 65);
            this.lblExpiriyDate.Name = "lblExpiriyDate";
            this.lblExpiriyDate.Size = new System.Drawing.Size(111, 16);
            this.lblExpiriyDate.TabIndex = 1;
            this.lblExpiriyDate.Text = "Card Expiriy Date";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(13, 33);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(87, 16);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "Card Number";
            // 
            // btnValidateCardInfo
            // 
            this.btnValidateCardInfo.Location = new System.Drawing.Point(565, 162);
            this.btnValidateCardInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidateCardInfo.Name = "btnValidateCardInfo";
            this.btnValidateCardInfo.Size = new System.Drawing.Size(179, 32);
            this.btnValidateCardInfo.TabIndex = 5;
            this.btnValidateCardInfo.Text = "Validate Card Details";
            this.btnValidateCardInfo.UseVisualStyleBackColor = true;
            // 
            // Payments_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 473);
            this.Controls.Add(this.btnValidateCardInfo);
            this.Controls.Add(this.CardDetails);
            this.Controls.Add(this.btnDisplayPay);
            this.Controls.Add(this.btnDisplayPayment);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payments_Form";
            this.Text = "Payments Form";
            this.Load += new System.EventHandler(this.Payments_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CardDetails.ResumeLayout(false);
            this.CardDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker PaymentDatedateTimePicker1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtInvoiceID;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnDisplayPayment;
        private System.Windows.Forms.Button btnDisplayPay;
        private System.Windows.Forms.GroupBox CardDetails;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.Label lblExpiriyDate;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Button btnValidateCardInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}