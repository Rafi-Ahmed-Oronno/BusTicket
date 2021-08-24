using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appication
{
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        Form a;
        public Admin(Form a)
        {
            InitializeComponent();
            this.a = a;

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            rtxtAdmin.ReadOnly = true;

            string data = rtxtAdmin.Text;
            string q = "update Bus.dbo.Customers set Notice ='" + data + "' where ID like 'C-1';";
            int a = DataAccess.DataAccess.ExecuteQuery(q);
            q = "update Bus.dbo.Driver set Notice ='" + data + "' where ID like 'D-1';";
            a = DataAccess.DataAccess.ExecuteQuery(q);
            q = "update Bus.dbo.SuperVisor set Notice ='" + data + "' where ID like 'S-1';";
            a = DataAccess.DataAccess.ExecuteQuery(q);


        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Profile(this,null,4).Visible = true;
            this.Visible = false;
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EmployeeInformation(this).Visible = true;
            this.Visible = false;
        }

        private void SheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Shedule(this).Visible = true;
            this.Visible = false;
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword(this,"").Visible = true;
            this.Visible = false;

        }

        private void ReturnTickeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Return_Ticket(this).Visible = true;
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.rtxtAdmin.ReadOnly = false;
        }

        private void RtxtAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
