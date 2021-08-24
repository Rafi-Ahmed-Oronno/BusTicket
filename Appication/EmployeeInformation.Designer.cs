namespace Appication
{
    partial class EmployeeInformation
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
            this.pType = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnSuperVisor = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnDriver = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJoingDate = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvShedule = new System.Windows.Forms.DataGridView();
            this.btnSuperVisor = new System.Windows.Forms.RadioButton();
            this.btnDriver = new System.Windows.Forms.RadioButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Joining_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(334, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 34);
            this.btnBack.TabIndex = 50;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pType
            // 
            this.pType.Controls.Add(this.label3);
            this.pType.Controls.Add(this.cmbBus);
            this.pType.Controls.Add(this.btnSave);
            this.pType.Controls.Add(this.txtPhoneNo);
            this.pType.Controls.Add(this.txtName);
            this.pType.Controls.Add(this.rbtnSuperVisor);
            this.pType.Controls.Add(this.label2);
            this.pType.Controls.Add(this.v);
            this.pType.Controls.Add(this.label10);
            this.pType.Controls.Add(this.txtBonus);
            this.pType.Controls.Add(this.label4);
            this.pType.Controls.Add(this.rbtnDriver);
            this.pType.Controls.Add(this.txtAddress);
            this.pType.Controls.Add(this.label5);
            this.pType.Controls.Add(this.label6);
            this.pType.Controls.Add(this.label9);
            this.pType.Controls.Add(this.txtJoingDate);
            this.pType.Controls.Add(this.txtAge);
            this.pType.Controls.Add(this.txtSalary);
            this.pType.Location = new System.Drawing.Point(2, 16);
            this.pType.Name = "pType";
            this.pType.Size = new System.Drawing.Size(508, 183);
            this.pType.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "BusId";
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(135, 103);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(100, 21);
            this.cmbBus.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(206, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(364, 15);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 21;
            // 
            // rbtnSuperVisor
            // 
            this.rbtnSuperVisor.AutoSize = true;
            this.rbtnSuperVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSuperVisor.Location = new System.Drawing.Point(3, 162);
            this.rbtnSuperVisor.Name = "rbtnSuperVisor";
            this.rbtnSuperVisor.Size = new System.Drawing.Size(103, 20);
            this.rbtnSuperVisor.TabIndex = 1;
            this.rbtnSuperVisor.TabStop = true;
            this.rbtnSuperVisor.Text = "SuperVisor";
            this.rbtnSuperVisor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.v.Location = new System.Drawing.Point(299, 110);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(59, 19);
            this.v.TabIndex = 18;
            this.v.Text = "Bonus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(260, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Joing Date";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(364, 110);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "PhoneNo";
            // 
            // rbtnDriver
            // 
            this.rbtnDriver.AutoSize = true;
            this.rbtnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDriver.Location = new System.Drawing.Point(3, 145);
            this.rbtnDriver.Name = "rbtnDriver";
            this.rbtnDriver.Size = new System.Drawing.Size(68, 20);
            this.rbtnDriver.TabIndex = 0;
            this.rbtnDriver.TabStop = true;
            this.rbtnDriver.Text = "Driver";
            this.rbtnDriver.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(136, 77);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Age";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Salary";
            // 
            // txtJoingDate
            // 
            this.txtJoingDate.Location = new System.Drawing.Point(364, 48);
            this.txtJoingDate.Name = "txtJoingDate";
            this.txtJoingDate.Size = new System.Drawing.Size(100, 20);
            this.txtJoingDate.TabIndex = 16;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(135, 45);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(364, 80);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Magneto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(414, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(287, 219);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 46;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dgvShedule
            // 
            this.dgvShedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Joining_Date,
            this.Address,
            this.Name,
            this.Age,
            this.Phone,
            this.Salary,
            this.Bonus,
            this.BusId});
            this.dgvShedule.Location = new System.Drawing.Point(2, 245);
            this.dgvShedule.Name = "dgvShedule";
            this.dgvShedule.Size = new System.Drawing.Size(797, 150);
            this.dgvShedule.TabIndex = 45;
            this.dgvShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellContentClick);
            this.dgvShedule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvShedule_CellDoubleClick);
            // 
            // btnSuperVisor
            // 
            this.btnSuperVisor.AutoSize = true;
            this.btnSuperVisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperVisor.Location = new System.Drawing.Point(530, 219);
            this.btnSuperVisor.Name = "btnSuperVisor";
            this.btnSuperVisor.Size = new System.Drawing.Size(103, 20);
            this.btnSuperVisor.TabIndex = 30;
            this.btnSuperVisor.TabStop = true;
            this.btnSuperVisor.Text = "SuperVisor";
            this.btnSuperVisor.UseVisualStyleBackColor = true;
            this.btnSuperVisor.CheckedChanged += new System.EventHandler(this.BtnSuperVisor_CheckedChanged);
            // 
            // btnDriver
            // 
            this.btnDriver.AutoSize = true;
            this.btnDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.Location = new System.Drawing.Point(530, 202);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(68, 20);
            this.btnDriver.TabIndex = 29;
            this.btnDriver.TabStop = true;
            this.btnDriver.Text = "Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.CheckedChanged += new System.EventHandler(this.BtnDriver_CheckedChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Joining_Date
            // 
            this.Joining_Date.DataPropertyName = "Joining_Date";
            this.Joining_Date.HeaderText = "Join";
            this.Joining_Date.Name = "Joining_Date";
            this.Joining_Date.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Add";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            // 
            // Bonus
            // 
            this.Bonus.DataPropertyName = "Bonus";
            this.Bonus.HeaderText = "Bonus";
            this.Bonus.Name = "Bonus";
            // 
            // BusId
            // 
            this.BusId.DataPropertyName = "BusId";
            this.BusId.HeaderText = "BusID";
            this.BusId.Name = "BusId";
            // 
            // EmployeeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuperVisor);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvShedule);
           //this.Name = "EmployeeInformation";
            this.Load += new System.EventHandler(this.EmployeeInformation_Load);
            this.pType.ResumeLayout(false);
            this.pType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnSuperVisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnDriver;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJoingDate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvShedule;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton btnSuperVisor;
        private System.Windows.Forms.RadioButton btnDriver;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Joining_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusId;
    }
}