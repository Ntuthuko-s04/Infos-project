using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiSystem
{
    public partial class Desktop_Form : Form
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
            this.createBookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryBookingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBookingToolStripMenuItem1
            // 
            this.createBookingToolStripMenuItem1.Name = "createBookingToolStripMenuItem1";
            this.createBookingToolStripMenuItem1.Size = new System.Drawing.Size(125, 28);
            this.createBookingToolStripMenuItem1.Text = "Create booking";
            this.createBookingToolStripMenuItem1.Click += new System.EventHandler(this.createBookingToolStripMenuItem1_Click);
            // 
            // changeBookingToolStripMenuItem
            // 
            this.changeBookingToolStripMenuItem.Name = "changeBookingToolStripMenuItem";
            this.changeBookingToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.changeBookingToolStripMenuItem.Text = "Change Booking";
            // 
            // queryBookingToolStripMenuItem1
            // 
            this.queryBookingToolStripMenuItem1.Name = "queryBookingToolStripMenuItem1";
            this.queryBookingToolStripMenuItem1.Size = new System.Drawing.Size(121, 28);
            this.queryBookingToolStripMenuItem1.Text = "Query Booking";
            // 
            // modifyBookingToolStripMenuItem
            // 
            this.modifyBookingToolStripMenuItem.Name = "modifyBookingToolStripMenuItem";
            this.modifyBookingToolStripMenuItem.Size = new System.Drawing.Size(129, 28);
            this.modifyBookingToolStripMenuItem.Text = "Modify Booking";
            this.modifyBookingToolStripMenuItem.Click += new System.EventHandler(this.modifyBookingToolStripMenuItem_Click);
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(132, 28);
            this.generateReportToolStripMenuItem.Text = "Generate Report";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBookingToolStripMenuItem1,
            this.changeBookingToolStripMenuItem,
            this.queryBookingToolStripMenuItem1,
            this.modifyBookingToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.generateReportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip.Size = new System.Drawing.Size(778, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(85, 28);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(778, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // Desktop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 521);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Desktop_Form";
            this.Text = "Desktop_Form";
            this.Load += new System.EventHandler(this.Desktop_Form_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem createBookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryBookingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}



