namespace ABCEventManagementSystem
{
    partial class FormAddEvent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaxAttendees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxVenue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxEvent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label3.Size = new System.Drawing.Size(245, 49);
            this.label3.TabIndex = 7;
            this.label3.Text = "Add Event";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblMessage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.textBoxMaxAttendees);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxVenue);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBoxEvent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 500);
            this.panel1.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(3, 365);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1290, 26);
            this.lblMessage.TabIndex = 23;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date of Event:";
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "";
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(582, 150);
            this.datePicker.MinDate = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(120, 26);
            this.datePicker.TabIndex = 2;
            this.datePicker.Value = new System.DateTime(2020, 12, 1, 15, 22, 25, 0);
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "hh:mm tt";
            this.timePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(582, 204);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(120, 26);
            this.timePicker.TabIndex = 3;
            this.timePicker.Value = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            // 
            // textBoxMaxAttendees
            // 
            this.textBoxMaxAttendees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaxAttendees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxMaxAttendees.Location = new System.Drawing.Point(582, 258);
            this.textBoxMaxAttendees.MaxLength = 7;
            this.textBoxMaxAttendees.Name = "textBoxMaxAttendees";
            this.textBoxMaxAttendees.Size = new System.Drawing.Size(120, 26);
            this.textBoxMaxAttendees.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Max Attendees:";
            // 
            // textBoxVenue
            // 
            this.textBoxVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVenue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxVenue.Location = new System.Drawing.Point(582, 96);
            this.textBoxVenue.MaxLength = 24;
            this.textBoxVenue.Name = "textBoxVenue";
            this.textBoxVenue.Size = new System.Drawing.Size(318, 26);
            this.textBoxVenue.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Venue Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Time of Event:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(599, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(111, 34);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 76);
            this.panel2.TabIndex = 8;
            // 
            // textBoxEvent
            // 
            this.textBoxEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxEvent.Location = new System.Drawing.Point(582, 39);
            this.textBoxEvent.MaxLength = 24;
            this.textBoxEvent.Name = "textBoxEvent";
            this.textBoxEvent.Size = new System.Drawing.Size(318, 26);
            this.textBoxEvent.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event Name:";
            // 
            // FormAddEvent
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1296, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEvent";
            this.Text = "FormAddEvent";
            this.Load += new System.EventHandler(this.FormAddEvent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxAttendees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxVenue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMessage;
    }
}