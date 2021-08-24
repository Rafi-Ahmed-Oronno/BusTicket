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
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        Form a;
        private bool name, age, address, mobileNo; 
        public Signup(Form a)
        {
            InitializeComponent();
            this.a = a;

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string i = null;
            try
            {
                 i = DataAccess.DataAccess.GetId("[Bus].[dbo].[Customers]");
                // txtId.Text = i.ToString();
                i = i.Substring(2, 1);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            int Id = 0;
            if (i == null) Id = 0;


            else Id = Int32.Parse(i);
            Id++;
            string q = null;
            try
            {
                if (Validation.Validation.IsValid(name, age, address, mobileNo))
                {
                    q = "Insert into Bus.dbo.Customers values('C-" + Id + "','" + txtName.Text + "','" + txtAddress.Text + "'," + txtMobileNo.Text + "," + txtAge.Text + "," + "null" + "," + "null" + "," + "null" + "," + "null" + "," + "null" + "," + "null" + ")";
                    new Password('c', null, q).Visible = true;
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                name = Validation.Validation.IsStringValid(txtName.Text);
                if (name == false)
                {
                    MessageBox.Show("Name is not valid Retry");

                }
                age = Validation.Validation.IsAgeValid(txtAge.Text);
                if (age == false)
                {
                    MessageBox.Show("Age is not valid Retry");

                }

                address = Validation.Validation.IsStringValid(txtAddress.Text);
                if (address == false)
                {
                    MessageBox.Show("Address is not valid Retry");

                }
                mobileNo = Validation.Validation.IsMobileNoValid(txtMobileNo.Text);
                if (mobileNo == false)
                {
                    MessageBox.Show("Mobile Number is not valid Retry");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
            
            // int Count = DataAccess.DataAccess.ExecuteQuery(q);
            // MessageBox.Show("Row Return"+Count);
           
        }

        
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }

        
    }
}
