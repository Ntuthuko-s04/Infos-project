namespace PhumlaKamnandiSystem.Presentation
{
    partial class CancelBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookingIDtxt = new System.Windows.Forms.TextBox();
            this.bookingView = new System.Windows.Forms.ListView();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter BookingID";
            // 
            // bookingIDtxt
            // 
            this.bookingIDtxt.Location = new System.Drawing.Point(311, 62);
            this.bookingIDtxt.Name = "bookingIDtxt";
            this.bookingIDtxt.Size = new System.Drawing.Size(131, 20);
            this.bookingIDtxt.TabIndex = 1;
            // 
            // bookingView
            // 
            this.bookingView.HideSelection = false;
            this.bookingView.Location = new System.Drawing.Point(168, 138);
            this.bookingView.Name = "bookingView";
            this.bookingView.Size = new System.Drawing.Size(432, 97);
            this.bookingView.TabIndex = 2;
            this.bookingView.UseCompatibleStateImageBehavior = false;
            this.bookingView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(311, 271);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(141, 23);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel Booking";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(311, 99);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(131, 23);
            this.showBtn.TabIndex = 4;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.bookingView);
            this.Controls.Add(this.bookingIDtxt);
            this.Controls.Add(this.label1);
            this.Name = "CancelBooking";
            this.Text = "CancelBooking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookingIDtxt;
        private System.Windows.Forms.ListView bookingView;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button showBtn;
    }
}