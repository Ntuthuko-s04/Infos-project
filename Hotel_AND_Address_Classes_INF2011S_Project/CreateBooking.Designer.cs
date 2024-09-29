namespace PhumlaKamnandiSystem.Presentation
{
    partial class Create_Booking
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
            this.RoomType = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbStandard = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBabysitting = new System.Windows.Forms.RadioButton();
            this.rdbLaundry = new System.Windows.Forms.RadioButton();
            this.rdbRoomService = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCellphoneNo = new System.Windows.Forms.TextBox();
            this.txtMembershipID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCellphoneNo = new System.Windows.Forms.Label();
            this.lblMembershipID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Dates = new System.Windows.Forms.GroupBox();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckIndateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hotelbtn = new System.Windows.Forms.Button();
            this.RoomType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomType
            // 
            this.RoomType.Controls.Add(this.button1);
            this.RoomType.Controls.Add(this.textBox1);
            this.RoomType.Controls.Add(this.label1);
            this.RoomType.Controls.Add(this.chbStandard);
            this.RoomType.Location = new System.Drawing.Point(599, 286);
            this.RoomType.Margin = new System.Windows.Forms.Padding(4);
            this.RoomType.Name = "RoomType";
            this.RoomType.Padding = new System.Windows.Forms.Padding(4);
            this.RoomType.Size = new System.Drawing.Size(373, 161);
            this.RoomType.TabIndex = 0;
            this.RoomType.TabStop = false;
            this.RoomType.Text = "RoomType";
            this.RoomType.Enter += new System.EventHandler(this.RoomType_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 65);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Check Room Availibility";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Room ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chbStandard
            // 
            this.chbStandard.AutoSize = true;
            this.chbStandard.Location = new System.Drawing.Point(9, 37);
            this.chbStandard.Margin = new System.Windows.Forms.Padding(4);
            this.chbStandard.Name = "chbStandard";
            this.chbStandard.Size = new System.Drawing.Size(84, 20);
            this.chbStandard.TabIndex = 0;
            this.chbStandard.Text = "Standard";
            this.chbStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBabysitting);
            this.groupBox1.Controls.Add(this.rdbLaundry);
            this.groupBox1.Controls.Add(this.rdbRoomService);
            this.groupBox1.Location = new System.Drawing.Point(599, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(228, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra Services";
            // 
            // rdbBabysitting
            // 
            this.rdbBabysitting.AutoSize = true;
            this.rdbBabysitting.Location = new System.Drawing.Point(9, 82);
            this.rdbBabysitting.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBabysitting.Name = "rdbBabysitting";
            this.rdbBabysitting.Size = new System.Drawing.Size(94, 20);
            this.rdbBabysitting.TabIndex = 2;
            this.rdbBabysitting.TabStop = true;
            this.rdbBabysitting.Text = "Babysitting";
            this.rdbBabysitting.UseVisualStyleBackColor = true;
            // 
            // rdbLaundry
            // 
            this.rdbLaundry.AutoSize = true;
            this.rdbLaundry.Location = new System.Drawing.Point(9, 54);
            this.rdbLaundry.Margin = new System.Windows.Forms.Padding(4);
            this.rdbLaundry.Name = "rdbLaundry";
            this.rdbLaundry.Size = new System.Drawing.Size(76, 20);
            this.rdbLaundry.TabIndex = 1;
            this.rdbLaundry.TabStop = true;
            this.rdbLaundry.Text = "Laundry";
            this.rdbLaundry.UseVisualStyleBackColor = true;
            // 
            // rdbRoomService
            // 
            this.rdbRoomService.AutoSize = true;
            this.rdbRoomService.Location = new System.Drawing.Point(9, 25);
            this.rdbRoomService.Margin = new System.Windows.Forms.Padding(4);
            this.rdbRoomService.Name = "rdbRoomService";
            this.rdbRoomService.Size = new System.Drawing.Size(114, 20);
            this.rdbRoomService.TabIndex = 0;
            this.rdbRoomService.TabStop = true;
            this.rdbRoomService.Text = "Room Service";
            this.rdbRoomService.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCellphoneNo);
            this.groupBox2.Controls.Add(this.txtMembershipID);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.lblCellphoneNo);
            this.groupBox2.Controls.Add(this.lblMembershipID);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.lblSurname);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Location = new System.Drawing.Point(39, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(362, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // txtCellphoneNo
            // 
            this.txtCellphoneNo.Location = new System.Drawing.Point(167, 148);
            this.txtCellphoneNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCellphoneNo.Name = "txtCellphoneNo";
            this.txtCellphoneNo.Size = new System.Drawing.Size(135, 22);
            this.txtCellphoneNo.TabIndex = 9;
            this.txtCellphoneNo.TextChanged += new System.EventHandler(this.txtCellphoneNo_TextChanged);
            // 
            // txtMembershipID
            // 
            this.txtMembershipID.Location = new System.Drawing.Point(167, 117);
            this.txtMembershipID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMembershipID.Name = "txtMembershipID";
            this.txtMembershipID.Size = new System.Drawing.Size(68, 22);
            this.txtMembershipID.TabIndex = 8;
            this.txtMembershipID.TextChanged += new System.EventHandler(this.txtMembershipID_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(167, 87);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(167, 57);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(135, 22);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(167, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblCellphoneNo
            // 
            this.lblCellphoneNo.AutoSize = true;
            this.lblCellphoneNo.Location = new System.Drawing.Point(11, 148);
            this.lblCellphoneNo.Name = "lblCellphoneNo";
            this.lblCellphoneNo.Size = new System.Drawing.Size(119, 16);
            this.lblCellphoneNo.TabIndex = 4;
            this.lblCellphoneNo.Text = "Cellphone Number";
            // 
            // lblMembershipID
            // 
            this.lblMembershipID.AutoSize = true;
            this.lblMembershipID.Location = new System.Drawing.Point(11, 117);
            this.lblMembershipID.Name = "lblMembershipID";
            this.lblMembershipID.Size = new System.Drawing.Size(98, 16);
            this.lblMembershipID.TabIndex = 3;
            this.lblMembershipID.Text = "Membership ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 87);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(11, 57);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // Dates
            // 
            this.Dates.Controls.Add(this.CheckOutDateTimePicker);
            this.Dates.Controls.Add(this.CheckIndateTimePicker1);
            this.Dates.Controls.Add(this.lblCheckOutDate);
            this.Dates.Controls.Add(this.lblCheckInDate);
            this.Dates.Location = new System.Drawing.Point(432, 31);
            this.Dates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dates.Name = "Dates";
            this.Dates.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dates.Size = new System.Drawing.Size(413, 119);
            this.Dates.TabIndex = 3;
            this.Dates.TabStop = false;
            this.Dates.Text = "Dates";
            this.Dates.Enter += new System.EventHandler(this.Dates_Enter);
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(115, 79);
            this.CheckOutDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(277, 22);
            this.CheckOutDateTimePicker.TabIndex = 3;
            this.CheckOutDateTimePicker.ValueChanged += new System.EventHandler(this.CheckOutDateTimePicker_ValueChanged);
            // 
            // CheckIndateTimePicker1
            // 
            this.CheckIndateTimePicker1.Location = new System.Drawing.Point(115, 37);
            this.CheckIndateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckIndateTimePicker1.Name = "CheckIndateTimePicker1";
            this.CheckIndateTimePicker1.Size = new System.Drawing.Size(267, 22);
            this.CheckIndateTimePicker1.TabIndex = 2;
            this.CheckIndateTimePicker1.ValueChanged += new System.EventHandler(this.CheckIndateTimePicker1_ValueChanged);
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(5, 82);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(101, 16);
            this.lblCheckOutDate.TabIndex = 1;
            this.lblCheckOutDate.Text = "Check-Out Date";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(5, 37);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(89, 16);
            this.lblCheckInDate.TabIndex = 0;
            this.lblCheckInDate.Text = "Check-In date";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 546);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create Booking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 260);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(553, 315);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // hotelbtn
            // 
            this.hotelbtn.Location = new System.Drawing.Point(421, 210);
            this.hotelbtn.Name = "hotelbtn";
            this.hotelbtn.Size = new System.Drawing.Size(171, 23);
            this.hotelbtn.TabIndex = 6;
            this.hotelbtn.Text = "See Hotels";
            this.hotelbtn.UseVisualStyleBackColor = true;
            this.hotelbtn.Click += new System.EventHandler(this.hotelbtn_Click);
            // 
            // Create_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 587);
            this.Controls.Add(this.hotelbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dates);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RoomType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Create_Booking";
            this.Text = "Create_Booking";
            this.Load += new System.EventHandler(this.Create_Booking_Load);
            this.RoomType.ResumeLayout(false);
            this.RoomType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Dates.ResumeLayout(false);
            this.Dates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RoomType;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbStandard;
        private System.Windows.Forms.RadioButton rdbLaundry;
        private System.Windows.Forms.RadioButton rdbRoomService;
        private System.Windows.Forms.RadioButton rdbBabysitting;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCellphoneNo;
        private System.Windows.Forms.Label lblMembershipID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCellphoneNo;
        private System.Windows.Forms.TextBox txtMembershipID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox Dates;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckIndateTimePicker1;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button hotelbtn;
    }
}