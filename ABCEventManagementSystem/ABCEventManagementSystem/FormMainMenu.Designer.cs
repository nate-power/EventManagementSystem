namespace ABCEventManagementSystem
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelRsvpSubMenu = new System.Windows.Forms.Panel();
            this.btnViewRsvp = new System.Windows.Forms.Button();
            this.btnRsvpEvent = new System.Windows.Forms.Button();
            this.btnRsvp = new System.Windows.Forms.Button();
            this.panelEventSubMenu = new System.Windows.Forms.Panel();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.btnViewEventDetails = new System.Windows.Forms.Button();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnEvents = new System.Windows.Forms.Button();
            this.panelCusSubMenu = new System.Windows.Forms.Panel();
            this.btnDelCus = new System.Windows.Forms.Button();
            this.btnViewCusDetails = new System.Windows.Forms.Button();
            this.btnViewCus = new System.Windows.Forms.Button();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelRsvpSubMenu.SuspendLayout();
            this.panelEventSubMenu.SuspendLayout();
            this.panelCusSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.panelRsvpSubMenu);
            this.panelMenu.Controls.Add(this.btnRsvp);
            this.panelMenu.Controls.Add(this.panelEventSubMenu);
            this.panelMenu.Controls.Add(this.btnEvents);
            this.panelMenu.Controls.Add(this.panelCusSubMenu);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 601);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogout.Location = new System.Drawing.Point(0, 558);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(238, 43);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // panelRsvpSubMenu
            // 
            this.panelRsvpSubMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelRsvpSubMenu.Controls.Add(this.btnViewRsvp);
            this.panelRsvpSubMenu.Controls.Add(this.btnRsvpEvent);
            this.panelRsvpSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRsvpSubMenu.Location = new System.Drawing.Point(0, 499);
            this.panelRsvpSubMenu.Name = "panelRsvpSubMenu";
            this.panelRsvpSubMenu.Size = new System.Drawing.Size(238, 59);
            this.panelRsvpSubMenu.TabIndex = 15;
            // 
            // btnViewRsvp
            // 
            this.btnViewRsvp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewRsvp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRsvp.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRsvp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewRsvp.Location = new System.Drawing.Point(0, 29);
            this.btnViewRsvp.Name = "btnViewRsvp";
            this.btnViewRsvp.Size = new System.Drawing.Size(238, 29);
            this.btnViewRsvp.TabIndex = 16;
            this.btnViewRsvp.Text = "View All RSVPs";
            this.btnViewRsvp.UseVisualStyleBackColor = true;
            this.btnViewRsvp.Click += new System.EventHandler(this.btnViewRsvp_Click_1);
            // 
            // btnRsvpEvent
            // 
            this.btnRsvpEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRsvpEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsvpEvent.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsvpEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRsvpEvent.Location = new System.Drawing.Point(0, 0);
            this.btnRsvpEvent.Name = "btnRsvpEvent";
            this.btnRsvpEvent.Size = new System.Drawing.Size(238, 29);
            this.btnRsvpEvent.TabIndex = 15;
            this.btnRsvpEvent.Text = "RSVP For Event";
            this.btnRsvpEvent.UseVisualStyleBackColor = true;
            this.btnRsvpEvent.Click += new System.EventHandler(this.btnRsvpEvent_Click_1);
            // 
            // btnRsvp
            // 
            this.btnRsvp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRsvp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRsvp.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsvp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRsvp.Location = new System.Drawing.Point(0, 454);
            this.btnRsvp.Name = "btnRsvp";
            this.btnRsvp.Size = new System.Drawing.Size(238, 45);
            this.btnRsvp.TabIndex = 14;
            this.btnRsvp.Text = "RSVP";
            this.btnRsvp.UseVisualStyleBackColor = true;
            this.btnRsvp.Click += new System.EventHandler(this.btnRsvp_Click_1);
            // 
            // panelEventSubMenu
            // 
            this.panelEventSubMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelEventSubMenu.Controls.Add(this.btnDelEvent);
            this.panelEventSubMenu.Controls.Add(this.btnViewEventDetails);
            this.panelEventSubMenu.Controls.Add(this.btnViewEvents);
            this.panelEventSubMenu.Controls.Add(this.btnAddEvent);
            this.panelEventSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEventSubMenu.Location = new System.Drawing.Point(0, 337);
            this.panelEventSubMenu.Name = "panelEventSubMenu";
            this.panelEventSubMenu.Size = new System.Drawing.Size(238, 117);
            this.panelEventSubMenu.TabIndex = 13;
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEvent.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelEvent.Location = new System.Drawing.Point(0, 87);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(238, 29);
            this.btnDelEvent.TabIndex = 15;
            this.btnDelEvent.Text = "Delete Event";
            this.btnDelEvent.UseVisualStyleBackColor = true;
            this.btnDelEvent.Click += new System.EventHandler(this.btnDelEvent_Click);
            // 
            // btnViewEventDetails
            // 
            this.btnViewEventDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewEventDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEventDetails.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEventDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewEventDetails.Location = new System.Drawing.Point(0, 58);
            this.btnViewEventDetails.Name = "btnViewEventDetails";
            this.btnViewEventDetails.Size = new System.Drawing.Size(238, 29);
            this.btnViewEventDetails.TabIndex = 14;
            this.btnViewEventDetails.Text = "VIew Event Details";
            this.btnViewEventDetails.UseVisualStyleBackColor = true;
            this.btnViewEventDetails.Click += new System.EventHandler(this.btnViewEventDetails_Click_1);
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEvents.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewEvents.Location = new System.Drawing.Point(0, 29);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(238, 29);
            this.btnViewEvents.TabIndex = 13;
            this.btnViewEvents.Text = "View All Events";
            this.btnViewEvents.UseVisualStyleBackColor = true;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click_1);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddEvent.Location = new System.Drawing.Point(0, 0);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(238, 29);
            this.btnAddEvent.TabIndex = 12;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click_1);
            // 
            // btnEvents
            // 
            this.btnEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvents.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEvents.Location = new System.Drawing.Point(0, 292);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(238, 45);
            this.btnEvents.TabIndex = 12;
            this.btnEvents.Text = "EVENTS";
            this.btnEvents.UseVisualStyleBackColor = true;
            this.btnEvents.Click += new System.EventHandler(this.btnEvents_Click_1);
            // 
            // panelCusSubMenu
            // 
            this.panelCusSubMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCusSubMenu.Controls.Add(this.btnDelCus);
            this.panelCusSubMenu.Controls.Add(this.btnViewCusDetails);
            this.panelCusSubMenu.Controls.Add(this.btnViewCus);
            this.panelCusSubMenu.Controls.Add(this.btnAddCus);
            this.panelCusSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCusSubMenu.Location = new System.Drawing.Point(0, 175);
            this.panelCusSubMenu.Name = "panelCusSubMenu";
            this.panelCusSubMenu.Size = new System.Drawing.Size(238, 117);
            this.panelCusSubMenu.TabIndex = 11;
            // 
            // btnDelCus
            // 
            this.btnDelCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCus.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDelCus.Location = new System.Drawing.Point(0, 87);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(238, 29);
            this.btnDelCus.TabIndex = 11;
            this.btnDelCus.Text = "Delete Customer";
            this.btnDelCus.UseVisualStyleBackColor = true;
            this.btnDelCus.Click += new System.EventHandler(this.btnDelCus_Click_1);
            // 
            // btnViewCusDetails
            // 
            this.btnViewCusDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCusDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCusDetails.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCusDetails.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewCusDetails.Location = new System.Drawing.Point(0, 58);
            this.btnViewCusDetails.Name = "btnViewCusDetails";
            this.btnViewCusDetails.Size = new System.Drawing.Size(238, 29);
            this.btnViewCusDetails.TabIndex = 10;
            this.btnViewCusDetails.Text = "View Customer Details";
            this.btnViewCusDetails.UseVisualStyleBackColor = true;
            this.btnViewCusDetails.Click += new System.EventHandler(this.btnViewCusDetails_Click_1);
            // 
            // btnViewCus
            // 
            this.btnViewCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCus.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnViewCus.Location = new System.Drawing.Point(0, 29);
            this.btnViewCus.Name = "btnViewCus";
            this.btnViewCus.Size = new System.Drawing.Size(238, 29);
            this.btnViewCus.TabIndex = 9;
            this.btnViewCus.Text = "View Customers";
            this.btnViewCus.UseVisualStyleBackColor = true;
            this.btnViewCus.Click += new System.EventHandler(this.btnViewCus_Click_1);
            // 
            // btnAddCus
            // 
            this.btnAddCus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCus.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddCus.Location = new System.Drawing.Point(0, 0);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(238, 29);
            this.btnAddCus.TabIndex = 8;
            this.btnAddCus.Text = "Add Customer";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click_1);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomers.Location = new System.Drawing.Point(0, 130);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(238, 45);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "CUSTOMERS";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(238, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event Management System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(238, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1296, 601);
            this.panelChildForm.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1534, 601);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 640);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Event Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelRsvpSubMenu.ResumeLayout(false);
            this.panelEventSubMenu.ResumeLayout(false);
            this.panelCusSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Panel panelEventSubMenu;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Panel panelCusSubMenu;
        private System.Windows.Forms.Button btnRsvp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelRsvpSubMenu;
        private System.Windows.Forms.Button btnDelCus;
        private System.Windows.Forms.Button btnViewCusDetails;
        private System.Windows.Forms.Button btnViewCus;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnViewRsvp;
        private System.Windows.Forms.Button btnRsvpEvent;
        private System.Windows.Forms.Button btnViewEventDetails;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnDelEvent;
    }
}

