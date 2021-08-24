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
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        //private char check;
        Form a;
        string Id;
        int Check;
        public Profile(Form a,string id,int check)
        {
            InitializeComponent();
            this.a = a;
            this.Id = id;
            this.Check = check;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            if(this.Check==1)
            {
                try
                {
                    string q = "Select * from Bus.dbo.Customers where Id like '" + Id + "';";
                    DataTable dt = DataAccess.DataAccess.GetDataTable(q);
                    DataRow Row = dt.Rows[0];
                    this.txtId.Text = Row["ID"].ToString();
                    this.txtAge.Text = Row["Age"].ToString();
                    this.txtMobileNo.Text = Row["Phone"].ToString();
                    this.txtName.Text = Row["Name"].ToString();
                    string i = Row["Ticket_Information"].ToString() + " " + Row["Journey_Date"].ToString();
                    this.txtTicket.Text = i;
                    this.txtAddress.Text = Row["Address"].ToString();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            if (this.Check == 2)
            {
                try
                {
                    string q = "Select * from Bus.dbo.Driver where Id like '" + Id + "';";
                    DataTable dt = DataAccess.DataAccess.GetDataTable(q);
                    DataRow Row = dt.Rows[0];
                    this.txtId.Text = Row["ID"].ToString();
                    this.txtAge.Text = Row["Age"].ToString();
                    this.txtMobileNo.Text = Row["Phone"].ToString();
                    this.txtName.Text = Row["Name"].ToString();
                    // string i = Row[""].ToString() + " " + Row["Journey_Date"].ToString();
                    this.txtTicket.Visible = false;
                    this.txtAddress.Text = Row["Address"].ToString();
                    this.label4.Visible = false;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            if (this.Check == 3)
            {
                try
                {
                    string q = "Select * from Bus.dbo.SuperVisor where Id like '" + Id + "';";
                    DataTable dt = DataAccess.DataAccess.GetDataTable(q);
                    DataRow Row = dt.Rows[0];
                    this.txtId.Text = Row["ID"].ToString();
                    this.txtAge.Text = Row["Age"].ToString();
                    this.txtMobileNo.Text = Row["Phone"].ToString();
                    this.txtName.Text = Row["Name"].ToString();
                    // string i = Row[""].ToString() + " " + Row["Journey_Date"].ToString();
                    this.txtTicket.Visible = false;
                    this.txtAddress.Text = Row["Address"].ToString();
                    this.label4.Visible = false;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
            if (this.Check == 4)
            {
                try
                {
                    this.txtId.Text = "16-32677-3";
                    this.txtAge.Text = "20";
                    this.txtMobileNo.Text = "01912643220";
                    this.txtName.Text = "Rafi";
                    // string i = Row[""].ToString() + " " + Row["Journey_Date"].ToString();
                    this.txtTicket.Visible = false;
                    this.txtAddress.Text = "Jamalpur";
                    this.label4.Visible = false;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;

        }
    }
}
