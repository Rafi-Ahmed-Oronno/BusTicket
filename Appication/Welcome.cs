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
    public partial class Welcome : MetroFramework.Forms.MetroForm
    {
        private static DataAccess.DataAccess Data = new DataAccess.DataAccess();

        public Welcome()
        {
            InitializeComponent();
           
        }

        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            new Login(this).Visible = true;
            this.Visible = false;
        }

        private void BtnSignup_Click(object sender, EventArgs e)
        {
            new Signup(this).Visible = true;
            this.Visible = false;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
