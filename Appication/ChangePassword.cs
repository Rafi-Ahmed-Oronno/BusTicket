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
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {

        Form a;
        string id;
        public ChangePassword(Form a, string Id)
        {
            InitializeComponent();

            this.a = a;
            this.id = Id;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            new Login(this).Visible = true;
            this.Visible = true;


        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            DataTable Dt = DataAccess.DataAccess.GetDataTable("Select * from Bus.dbo.Login where ID Like '" + this.id + "';");

            DataRow Row = Dt.Rows[0];

            if (txtOldPassword.Text == Row["Password"].ToString())
            {
                if (this.txtNewPassword.Text == this.txtConfirmPassword.Text)
                {
                    string q = "update Bus.dbo.Login set Password='" + this.txtConfirmPassword.Text + "' where ID like '" + this.id + "'; ";
                    int a = DataAccess.DataAccess.ExecuteQuery(q);
                    if (a >= 1) MessageBox.Show("Password Changed Successfully");
                    else MessageBox.Show("Error");
                }
            }
        }
    }
}
