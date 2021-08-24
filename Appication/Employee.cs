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
    public partial class Employee : MetroFramework.Forms.MetroForm
    {
        Form a;
        string Id;
        public Employee(Form a,string id)
        {
            InitializeComponent();
            this.a = a;
            this.Id = id;

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            if (Id == null) { }
            else
            {
                
                string q = "select Notice from Bus.dbo.Driver where ID Like 'D-1'";
                DataTable dt=DataAccess.DataAccess.GetDataTable(q);
                DataRow Row = dt.Rows[0];
                string i = Row["Notice"].ToString();
                txtNotice.Clear();

                txtNotice.Text = i;
                txtNotice.ReadOnly = true;
                this.dgvShedule.AutoGenerateColumns= false;
                q = "Select Date,Time,Route,BusId,Seat_Status,Bus_Status from Bus.dbo.Shedule where Driver like'" + Id + "' OR SuperVisor like'" + Id + "';";
                DataSet Ds = DataAccess.DataAccess.GetDataSet(q);
                
                this.dgvShedule.DataSource = Ds.Tables[0];

            }
        }

        private void DgvShedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            if(Id.Substring(0,1)=="D")
            {
                new Profile(this, Id, 2).Visible = true;
                this.Visible = false;
            }
            else
                new Profile(this, Id, 3).Visible = true;
            this.Visible = false;

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }

        private void TxtNotice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
