namespace Appication
{
    partial class Employee
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvShedule = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNotice = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(304, 409);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 34);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(217, 55);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(169, 26);
            this.btnProfile.TabIndex = 50;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Your Shedule";
            // 
            // dgvShedule
            // 
            this.dgvShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Route,
            this.BusID,
            this.seatStatus,
            this.busStatus});
            this.dgvShedule.Location = new System.Drawing.Point(23, 284);
            this.dgvShedule.Name = "dgvShedule";
            this.dgvShedule.Size = new System.Drawing.Size(731, 119);
            this.dgvShedule.TabIndex = 48;
            this.dgvShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellContentClick);
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.DataPropertyName = "Time";
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Route
            // 
            this.Route.DataPropertyName = "Route";
            this.Route.HeaderText = "Route";
            this.Route.Name = "Route";
            this.Route.ReadOnly = true;
            // 
            // BusID
            // 
            this.BusID.DataPropertyName = "BusId";
            this.BusID.HeaderText = "BudID";
            this.BusID.Name = "BusID";
            this.BusID.ReadOnly = true;
            // 
            // seatStatus
            // 
            this.seatStatus.DataPropertyName = "Seat_Status";
            this.seatStatus.HeaderText = "Seat Status";
            this.seatStatus.Name = "seatStatus";
            this.seatStatus.ReadOnly = true;
            // 
            // busStatus
            // 
            this.busStatus.DataPropertyName = "Bus_Status";
            this.busStatus.HeaderText = "Bus Status";
            this.busStatus.Name = "busStatus";
            this.busStatus.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Notice";
            // 
            // txtNotice
            // 
            this.txtNotice.Location = new System.Drawing.Point(514, 41);
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.ReadOnly = true;
            this.txtNotice.Size = new System.Drawing.Size(263, 232);
            this.txtNotice.TabIndex = 46;
            this.txtNotice.Text = "Oronno Ahmed";
            this.txtNotice.TextChanged += new System.EventHandler(this.TxtNotice_TextChanged);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvShedule);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNotice);
            this.Name = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvShedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtNotice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn busStatus;
    }
}