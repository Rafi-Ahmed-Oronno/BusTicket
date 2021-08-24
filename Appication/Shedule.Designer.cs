namespace Appication
{
    partial class Shedule
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
            this.pShowShedule = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvShedule = new System.Windows.Forms.DataGridView();
            this.pCreateShedule = new System.Windows.Forms.Panel();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.cmbBusStatus = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pShowShedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).BeginInit();
            this.pCreateShedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(297, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 28);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pShowShedule
            // 
            this.pShowShedule.Controls.Add(this.btnDelete);
            this.pShowShedule.Controls.Add(this.dgvShedule);
            this.pShowShedule.Location = new System.Drawing.Point(3, 207);
            this.pShowShedule.Name = "pShowShedule";
            this.pShowShedule.Size = new System.Drawing.Size(794, 194);
            this.pShowShedule.TabIndex = 28;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(284, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvShedule
            // 
            this.dgvShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SID,
            this.Date,
            this.Time,
            this.Route,
            this.BusID,
            this.seatStatus,
            this.busStatus});
            this.dgvShedule.Location = new System.Drawing.Point(3, 37);
            this.dgvShedule.Name = "dgvShedule";
            this.dgvShedule.Size = new System.Drawing.Size(788, 150);
            this.dgvShedule.TabIndex = 17;
            this.dgvShedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellClick);
            this.dgvShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellContentClick);
            this.dgvShedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellDoubleClick);
            // 
            // pCreateShedule
            // 
            this.pCreateShedule.Controls.Add(this.cmbRoute);
            this.pCreateShedule.Controls.Add(this.cmbBusStatus);
            this.pCreateShedule.Controls.Add(this.cmbTime);
            this.pCreateShedule.Controls.Add(this.btnShow);
            this.pCreateShedule.Controls.Add(this.dateTimePicker1);
            this.pCreateShedule.Controls.Add(this.label7);
            this.pCreateShedule.Controls.Add(this.label6);
            this.pCreateShedule.Controls.Add(this.cmbSupervisor);
            this.pCreateShedule.Controls.Add(this.label5);
            this.pCreateShedule.Controls.Add(this.btnCreate);
            this.pCreateShedule.Controls.Add(this.label4);
            this.pCreateShedule.Controls.Add(this.cmbDriver);
            this.pCreateShedule.Controls.Add(this.label3);
            this.pCreateShedule.Controls.Add(this.label2);
            this.pCreateShedule.Controls.Add(this.label1);
            this.pCreateShedule.Controls.Add(this.cmbBus);
            this.pCreateShedule.Location = new System.Drawing.Point(51, 16);
            this.pCreateShedule.Name = "pCreateShedule";
            this.pCreateShedule.Size = new System.Drawing.Size(608, 193);
            this.pCreateShedule.TabIndex = 27;
            this.pCreateShedule.Click += new System.EventHandler(this.PCreateShedule_Click);
            this.pCreateShedule.Paint += new System.Windows.Forms.PaintEventHandler(this.PCreateShedule_Paint);
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(453, 35);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(121, 21);
            this.cmbRoute.TabIndex = 32;
            this.cmbRoute.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // cmbBusStatus
            // 
            this.cmbBusStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusStatus.FormattingEnabled = true;
            this.cmbBusStatus.Location = new System.Drawing.Point(261, 82);
            this.cmbBusStatus.Name = "cmbBusStatus";
            this.cmbBusStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbBusStatus.TabIndex = 31;
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(317, 35);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 36);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 9, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.Value = new System.DateTime(2019, 9, 19, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Bus Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Time";
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(134, 82);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(121, 21);
            this.cmbSupervisor.TabIndex = 21;
            this.cmbSupervisor.SelectedIndexChanged += new System.EventHandler(this.CmbSupervisor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(144, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "SuperVisor";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(246, 120);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select Driver";
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(7, 82);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(121, 21);
            this.cmbDriver.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "RouteName (S-D)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select Bus";
            // 
            // cmbBus
            // 
            this.cmbBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbBus.Location = new System.Drawing.Point(55, 36);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(121, 21);
            this.cmbBus.TabIndex = 13;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(372, 120);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(96, 23);
            this.btnShow.TabIndex = 26;
            this.btnShow.Text = "Update";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // SID
            // 
            this.SID.DataPropertyName = "ID";
            this.SID.HeaderText = "ID";
            this.SID.Name = "SID";
            this.SID.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.BusID.HeaderText = "BusID";
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
            // Shedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pShowShedule);
            this.Controls.Add(this.pCreateShedule);
            this.Name = "Shedule";
            this.Load += new System.EventHandler(this.Shedule_Load);
            this.Click += new System.EventHandler(this.Shedule_Click);
            this.pShowShedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).EndInit();
            this.pCreateShedule.ResumeLayout(false);
            this.pCreateShedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pShowShedule;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvShedule;
        private System.Windows.Forms.Panel pCreateShedule;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbBusStatus;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn SID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn busStatus;
    }
}