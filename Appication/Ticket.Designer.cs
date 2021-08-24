namespace Appication
{
    partial class Ticket
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
            this.pReturn = new System.Windows.Forms.Panel();
            this.txtReturnTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pTicket = new System.Windows.Forms.Panel();
            this.btBuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn02 = new System.Windows.Forms.Button();
            this.btn01 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.pReturn.SuspendLayout();
            this.pTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(245, 345);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 34);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // pReturn
            // 
            this.pReturn.Controls.Add(this.txtReturnTicket);
            this.pReturn.Controls.Add(this.label5);
            this.pReturn.Controls.Add(this.btnReturn);
            this.pReturn.Controls.Add(this.label4);
            this.pReturn.Location = new System.Drawing.Point(94, 166);
            this.pReturn.Name = "pReturn";
            this.pReturn.Size = new System.Drawing.Size(405, 151);
            this.pReturn.TabIndex = 51;
            // 
            // txtReturnTicket
            // 
            this.txtReturnTicket.Location = new System.Drawing.Point(85, 67);
            this.txtReturnTicket.Name = "txtReturnTicket";
            this.txtReturnTicket.Size = new System.Drawing.Size(220, 20);
            this.txtReturnTicket.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(2, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(396, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "NB:-> You Can\'t Return Ticket Before 1 Day";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(124, 93);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 31);
            this.btnReturn.TabIndex = 37;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ticket With Date";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(255, 129);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(91, 31);
            this.btnConfirm.TabIndex = 50;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(114, 94);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(101, 21);
            this.cmbRoute.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Date & Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Route";
            // 
            // pTicket
            // 
            this.pTicket.Controls.Add(this.btBuy);
            this.pTicket.Controls.Add(this.label3);
            this.pTicket.Controls.Add(this.btn02);
            this.pTicket.Controls.Add(this.btn01);
            this.pTicket.Controls.Add(this.btnA1);
            this.pTicket.Controls.Add(this.btnA2);
            this.pTicket.Controls.Add(this.btnC4);
            this.pTicket.Controls.Add(this.btnB1);
            this.pTicket.Controls.Add(this.btnC3);
            this.pTicket.Controls.Add(this.btnB2);
            this.pTicket.Controls.Add(this.btnB4);
            this.pTicket.Controls.Add(this.btnC1);
            this.pTicket.Controls.Add(this.btnB3);
            this.pTicket.Controls.Add(this.btnC2);
            this.pTicket.Controls.Add(this.btnA4);
            this.pTicket.Controls.Add(this.btnA3);
            this.pTicket.Location = new System.Drawing.Point(499, 74);
            this.pTicket.Name = "pTicket";
            this.pTicket.Size = new System.Drawing.Size(208, 216);
            this.pTicket.TabIndex = 45;
            // 
            // btBuy
            // 
            this.btBuy.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuy.Location = new System.Drawing.Point(63, 185);
            this.btBuy.Name = "btBuy";
            this.btBuy.Size = new System.Drawing.Size(91, 31);
            this.btBuy.TabIndex = 36;
            this.btBuy.Text = "Buy";
            this.btBuy.UseVisualStyleBackColor = true;
            this.btBuy.Click += new System.EventHandler(this.BtBuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Available Seats";
            // 
            // btn02
            // 
            this.btn02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn02.Location = new System.Drawing.Point(170, 55);
            this.btn02.Name = "btn02";
            this.btn02.Size = new System.Drawing.Size(35, 25);
            this.btn02.TabIndex = 28;
            this.btn02.Text = "02";
            this.btn02.UseVisualStyleBackColor = false;
            this.btn02.Click += new System.EventHandler(this.Btn02_Click);
            // 
            // btn01
            // 
            this.btn01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn01.Location = new System.Drawing.Point(129, 55);
            this.btn01.Name = "btn01";
            this.btn01.Size = new System.Drawing.Size(35, 25);
            this.btn01.TabIndex = 27;
            this.btn01.Text = "01";
            this.btn01.UseVisualStyleBackColor = false;
            this.btn01.Click += new System.EventHandler(this.Btn01_Click);
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(6, 86);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(35, 25);
            this.btnA1.TabIndex = 0;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.BtnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(47, 86);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(35, 25);
            this.btnA2.TabIndex = 2;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.BtnA2_Click);
            // 
            // btnC4
            // 
            this.btnC4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC4.Location = new System.Drawing.Point(170, 148);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(35, 25);
            this.btnC4.TabIndex = 17;
            this.btnC4.Text = "C4";
            this.btnC4.UseVisualStyleBackColor = false;
            this.btnC4.Click += new System.EventHandler(this.BtnC4_Click);
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(6, 117);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(35, 25);
            this.btnB1.TabIndex = 4;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = false;
            this.btnB1.Click += new System.EventHandler(this.BtnB1_Click);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(129, 148);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(35, 25);
            this.btnC3.TabIndex = 16;
            this.btnC3.Text = "C3";
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.Click += new System.EventHandler(this.BtnC3_Click);
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(47, 117);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(35, 25);
            this.btnB2.TabIndex = 5;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.Click += new System.EventHandler(this.BtnB2_Click);
            // 
            // btnB4
            // 
            this.btnB4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB4.Location = new System.Drawing.Point(170, 117);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(35, 25);
            this.btnB4.TabIndex = 15;
            this.btnB4.Text = "B4";
            this.btnB4.UseVisualStyleBackColor = false;
            this.btnB4.Click += new System.EventHandler(this.BtnB4_Click);
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(6, 148);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(35, 25);
            this.btnC1.TabIndex = 6;
            this.btnC1.Text = "C1";
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.Click += new System.EventHandler(this.BtnC1_Click);
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(129, 117);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(35, 25);
            this.btnB3.TabIndex = 14;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.Click += new System.EventHandler(this.BtnB3_Click);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(47, 148);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(35, 25);
            this.btnC2.TabIndex = 7;
            this.btnC2.Text = "C2";
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.Click += new System.EventHandler(this.BtnC2_Click);
            // 
            // btnA4
            // 
            this.btnA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA4.Location = new System.Drawing.Point(170, 86);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(35, 25);
            this.btnA4.TabIndex = 13;
            this.btnA4.Text = "A4";
            this.btnA4.UseVisualStyleBackColor = false;
            this.btnA4.Click += new System.EventHandler(this.BtnA4_Click);
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(129, 86);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(35, 25);
            this.btnA3.TabIndex = 12;
            this.btnA3.Text = "A3";
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.Click += new System.EventHandler(this.BtnA3_Click);
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(378, 94);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 21);
            this.cmbTime.TabIndex = 53;
            // 
            // cmbDate
            // 
            this.cmbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(245, 94);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(121, 21);
            this.cmbDate.TabIndex = 54;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pReturn);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.cmbRoute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pTicket);
            this.Name = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.pReturn.ResumeLayout(false);
            this.pReturn.PerformLayout();
            this.pTicket.ResumeLayout(false);
            this.pTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pTicket;
        private System.Windows.Forms.Button btBuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn02;
        private System.Windows.Forms.Button btn01;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.TextBox txtReturnTicket;
    }
}