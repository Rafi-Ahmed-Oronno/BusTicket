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
    public partial class Shedule : MetroFramework.Forms.MetroForm
    {

        Form a;
        string ID;
        DataTable Dt;
        Entity.Shedule S = new Entity.Shedule();
        public Shedule(Form a)
        {
            InitializeComponent();
            this.a = a;
        }
        private void populateGridView(String q)
        {
            this.dgvShedule.AutoGenerateColumns = false;
            Dt = DataAccess.DataAccess.GetDataTable(q);
            this.dgvShedule.DataSource = Dt;
        }
        private void Shedule_Load(object sender, EventArgs e)
        {
            //this.cmbRoute.DropDownStyle;
            this.btnDelete.Visible = false;
            this.cmbBusStatus.Items.Add("In Terminal");
            this.cmbBusStatus.Items.Add("On Road");

            this.cmbRoute.Items.Add("Dhaka-Chittagong");
            this.cmbRoute.Items.Add("Dhaka-MymenShing");

            this.cmbRoute.Items.Add("Chittagon-Dhaka");
            this.cmbRoute.Items.Add("MymenShing-Dhaka");

            this.cmbTime.Items.Add("10Am");
            this.cmbTime.Items.Add("2PM");
            populateGridView("Select * from Bus.dbo.Shedule Order By ID");
            string q = "Select * from Bus.dbo.Bus";
            DataTable dtBus = DataAccess.DataAccess.GetDataTable(q);
            q = "Select * from Bus.dbo.SuperVisor";
            DataTable dtSuperVisor = DataAccess.DataAccess.GetDataTable(q);
            q = "Select * from Bus.dbo.Driver";
            DataTable dtDriver= DataAccess.DataAccess.GetDataTable(q);

            int i = 0;
            DataRow RowBus = dtBus.Rows[i];
            DataRow RowDriver = dtDriver.Rows[i];
            DataRow RowSuperVisor = dtSuperVisor.Rows[i];
            for (; ; )
            {
                string item = RowBus["ID"].ToString();
                this.cmbBus.Items.Add(item);           
                i++;
                try
                {
                    RowBus = dtBus.Rows[i];
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            i = 0;
            for (; ; )
            {
                string item = RowDriver["ID"].ToString();
                this.cmbDriver.Items.Add(item);
                i++;
                try
                {
                    RowDriver = dtDriver.Rows[i];
                }
                catch (Exception ex)
                {
                    break;
                }
            }
            i = 0;
            for (; ; )
            {
                string item = RowSuperVisor["ID"].ToString();
                this.cmbSupervisor.Items.Add(item);
                i++;
                try
                {
                    RowBus = dtSuperVisor.Rows[i];
                }
                catch (Exception ex)
                {
                    break;
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CmbDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Show()
        {
           // S.id = Convert.ToInt32(this.ID);
            MessageBox.Show(this.ID);
            S.SeatStatus = "";
            try
            {
                string i = this.cmbBus.SelectedItem.ToString();
                S.Busid = Int32.Parse(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bus Id is Invalid");
            }

            try
            {

                S.BusStatus = this.cmbBusStatus.SelectedItem.ToString();
                S.Date = this.dateTimePicker1.Value.Date.ToString();
                S.Time = this.cmbTime.SelectedItem.ToString();
                S.Driver = this.cmbDriver.SelectedItem.ToString();
                S.SuperVisor = this.cmbSupervisor.SelectedItem.ToString();
                S.Route = this.cmbRoute.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            bool ans = false;
            //MessageBox.Show(S.Date);
            try
            {
                ans = SheduleRepo.SheduleRepo.Save(S);
                if (ans == true) MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Visible = true;
            populateGridView("Select * from Bus.dbo.Shedule Order by ID");
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
           
            int id = SheduleRepo.SheduleRepo.GetId();
            
            
           
            id++;
            S.id = id;
            S.SeatStatus = "";
            Show();
            populateGridView("Select * from Bus.dbo.Shedule");
            this.dgvShedule.Visible = true;


        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
           
           
            

            
            //string q= "Delete From Bus.dbo.Shedule where ID=" + this.ID + ";";
           // SheduleRepo.SheduleRepo.Execute(q);
          //  populateGridView("Select * from Bus.dbo.Shedule Order By ID");
            
        }

        private void DgvShedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ID = this.dgvShedule.CurrentRow.Cells["SID"].Value.ToString();
            //this.cmbRoute.Items.Add(this.dgvShedule.CurrentRow.Cells["Route"].Value.ToString());
        }

       
        private void BtnShow_Click(object sender, EventArgs e)
        {
            this.pCreateShedule.Visible = true;
            Show();
            populateGridView("Select * from Bus.dbo.Shedule");



        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            String DateTime=this.dateTimePicker1.Value.Date.ToString();

        }

        private void CmbSupervisor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DgvShedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvShedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ID = this.dgvShedule.CurrentRow.Cells["SID"].Value.ToString();
            this.btnCreate.Visible = false;
        }

        private void Shedule_Click(object sender, EventArgs e)
        {
            this.btnCreate.Visible = true;
        }

        private void PCreateShedule_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void PCreateShedule_Click(object sender, EventArgs e)
        {
            this.btnCreate.Visible = true;
        }
    }
}
