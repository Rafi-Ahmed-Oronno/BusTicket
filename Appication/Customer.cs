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
    public partial class Customer : MetroFramework.Forms.MetroForm
    {
        Form a;
        string Id;
        public Customer(Form a,string Id)
        {
            InitializeComponent();
            this.a = a;
            this.Id = Id;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DataTable Dt = DataAccess.DataAccess.GetDataTable("Select * From Bus.dbo.Customers where ID Like 'C-1'");
            DataRow Row = Dt.Rows[0];
            this.txtNotice.Text = Row["Notice"].ToString();
            Dt = DataAccess.DataAccess.GetDataTable("Select * From Bus.dbo.Customers where ID Like'"+this.Id+"';");
            Row = Dt.Rows[0];
            string s = Row["Return_Ticket"].ToString();
            if(s==null)
            {
                MessageBox.Show("Your Requested is rejected");
            }
        }

        private void ProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Profile(this,Id,1).Visible = true;
            this.Visible = false;
        }

        private void BuyTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ticket(this.Id,'B',this).Visible = true;
            this.Visible = false;
        }

        private void ReturnTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ticket(this.Id,'R',this).Visible = true;
            this.Visible = false;

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ChangePassword(this,this.Id).Visible = true;
            this.Visible = false;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }
    }
}
