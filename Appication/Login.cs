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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        Form a;
        public Login(Form a)
        {
            InitializeComponent();
            this.a = a;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string tempId = txtId.Text;
            string q = null;
            bool ans = false;
            if (txtId.Text == "Rafi" && txtPassword.Text == "2446")
            {
                new Admin(this).Visible = true;
                this.Visible = false;
                ans = true;
            }
            try
            {
                q = "Select * from Bus.dbo.Login where ID like'" + txtId.Text + "' AND Password like '" + txtPassword.Text + "';";
                DataTable dt = DataAccess.DataAccess.GetDataTable(q);
                //txtId.Text = count.ToString();

                if (dt.Rows[0] != null)
                {
                    string Id = tempId;
                    tempId = Id.Substring(0, 1);
                    if (tempId == "D" || tempId == "S")
                    {
                        txtId.Text = Id;
                        new Employee(this,Id).Visible = true;
                    }
                    else
                    {
                        new Customer(this,Id).Visible = true;
                        this.Visible = false;
                    }

                }
            }
            catch(Exception ex)
            {
                if (ans == true) { }
                else  MessageBox.Show("Error");
            }
            
           
            if (txtId.Text == "Oronno" && txtPassword.Text == "2446")
            {
                new Customer(this,null).Visible = true;
                this.Visible = false;
            }
            if (txtId.Text == "Ahmed" && txtPassword.Text == "2446")
            {
                new Employee(this,null).Visible = true;
                this.Visible = false;
            }
            
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
