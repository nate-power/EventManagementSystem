namespace ABCEventManagementSystem
{
    partial class FormViewCusDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnShowCustomers = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.labelBookingsInfo = new System.Windows.Forms.Label();
            this.labelPhoneInfo = new System.Windows.Forms.Label();
            this.labelNameInfo = new System.Windows.Forms.Label();
            this.labelNumberInfo = new System.Windows.Forms.Label();
            this.labelBookings = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(514, 49);
            this.label3.TabIndex = 4;
            this.label3.Text = "View Customer Details";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnShowCustomers);
            this.panel.Controls.Add(this.btnSubmit);
            this.panel.Controls.Add(this.textBoxId);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.labelBookings);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 101);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1296, 500);
            this.panel.TabIndex = 8;
            // 
            // btnShowCustomers
            // 
            this.btnShowCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustomers.Location = new System.Drawing.Point(1124, 11);
            this.btnShowCustomers.Name = "btnShowCustomers";
            this.btnShowCustomers.Size = new System.Drawing.Size(160, 27);
            this.btnShowCustomers.TabIndex = 2;
            this.btnShowCustomers.Text = "Show All Customers";
            this.btnShowCustomers.UseVisualStyleBackColor = true;
            this.btnShowCustomers.Click += new System.EventHandler(this.btnShowCustomers_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(382, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(72, 27);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(265, 10);
            this.textBoxId.MaxLength = 9;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(111, 26);
            this.textBoxId.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter a customer ID:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.labelBookingsInfo);
            this.panel1.Controls.Add(this.labelPhoneInfo);
            this.panel1.Controls.Add(this.labelNameInfo);
            this.panel1.Controls.Add(this.labelNumberInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 412);
            this.panel1.TabIndex = 7;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(-1, 159);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1296, 26);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBookingsInfo
            // 
            this.labelBookingsInfo.AutoSize = true;
            this.labelBookingsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookingsInfo.Location = new System.Drawing.Point(1085, 13);
            this.labelBookingsInfo.Name = "labelBookingsInfo";
            this.labelBookingsInfo.Size = new System.Drawing.Size(0, 20);
            this.labelBookingsInfo.TabIndex = 11;
            // 
            // labelPhoneInfo
            // 
            this.labelPhoneInfo.AutoSize = true;
            this.labelPhoneInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneInfo.Location = new System.Drawing.Point(794, 13);
            this.labelPhoneInfo.Name = "labelPhoneInfo";
            this.labelPhoneInfo.Size = new System.Drawing.Size(0, 20);
            this.labelPhoneInfo.TabIndex = 10;
            // 
            // labelNameInfo
            // 
            this.labelNameInfo.AutoSize = true;
            this.labelNameInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameInfo.Location = new System.Drawing.Point(193, 13);
            this.labelNameInfo.Name = "labelNameInfo";
            this.labelNameInfo.Size = new System.Drawing.Size(0, 20);
            this.labelNameInfo.TabIndex = 9;
            // 
            // labelNumberInfo
            // 
            this.labelNumberInfo.AutoSize = true;
            this.labelNumberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberInfo.Location = new System.Drawing.Point(48, 13);
            this.labelNumberInfo.Name = "labelNumberInfo";
            this.labelNumberInfo.Size = new System.Drawing.Size(0, 20);
            this.labelNumberInfo.TabIndex = 8;
            // 
            // labelBookings
            // 
            this.labelBookings.AutoSize = true;
            this.labelBookings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookings.Location = new System.Drawing.Point(1085, 61);
            this.labelBookings.Name = "labelBookings";
            this.labelBookings.Size = new System.Drawing.Size(0, 26);
            this.labelBookings.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(794, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "First and Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number";
            // 
            // FormViewCusDetails
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1296, 601);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViewCusDetails";
            this.Text = "ViewCusDetails";
            this.Load += new System.EventHandler(this.FormViewCusDetails_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelBookings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBookingsInfo;
        private System.Windows.Forms.Label labelPhoneInfo;
        private System.Windows.Forms.Label labelNameInfo;
        private System.Windows.Forms.Label labelNumberInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowCustomers;
        private System.Windows.Forms.Label lblMessage;
    }
}