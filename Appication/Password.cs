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
    public partial class Password :MetroFramework.Forms.MetroForm
    {
        private char c;
        //private int Id;
        string id;
        string query;
        public Password(char Check,string Id,string q)
        {
           
            InitializeComponent();
            this.c = Check;
            this.id = Id;
            this.query = q;

        }

        private void Password_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            label8.Visible = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string id=txtId.Text;

            string password=null;
            string q=null;
            if (this.txtPassword.Text == this.txtConfirmPassword.Text)
            {

                if (this.c == 'A')
                {
                    try
                    {
                        q = "Insert into Bus.dbo.Login Values('" + this.id + "','" + this.txtPassword.Text + "');";
                        int a = DataAccess.DataAccess.ExecuteQuery(q);
                        if (a >= 1) MessageBox.Show("Password successfull");
                        else MessageBox.Show("Error");
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                }
                else
                {

                    password = this.txtPassword.Text;
                    string i = null;
                    try
                    {
                        int count = DataAccess.DataAccess.ExecuteQuery(this.query);
                         i = DataAccess.DataAccess.GetId("[Bus].[dbo].[Customers]");
                        if (c == 'c') q = "Insert into Bus.dbo.Login values( '" + i + "','" + password + "');";
                        count = DataAccess.DataAccess.ExecuteQuery(q);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    //count = DataAccess.DataAccess.ExecuteQuery(this.query);

                    MessageBox.Show("Your Account Created Successfully");
                    txtConfirmPassword.Visible = false;
                    txtPassword.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    txtId.Text = i;
                    txtId.Visible = true;
                    label8.Visible = true;
                    btnSave.Visible = false;
                }
            }



        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            new Login(this).Visible = true;
            this.Visible = false;
        }
    }
}
