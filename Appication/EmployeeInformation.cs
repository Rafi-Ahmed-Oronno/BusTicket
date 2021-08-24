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
    public partial class EmployeeInformation : MetroFramework.Forms.MetroForm
    {
        Form a;
        string EID="s";
        DataTable Dt;
        public EmployeeInformation(Form a)
        {
            InitializeComponent();
            this.a = a;
        }
        private void PopulateGridView(string q)
        {
            this.dgvShedule.AutoGenerateColumns = false;
            Dt = DataAccess.DataAccess.GetDataTable(q);
            this.dgvShedule.DataSource = Dt;
        }
        private void EmployeeInformation_Load(object sender, EventArgs e)
        {
            
             
             string q = "Select * from Driver";
            PopulateGridView(q);
            q = "Select * from Bus.dbo.Bus";
            Dt= DataAccess.DataAccess.GetDataTable(q);
            int i = 0;
            DataRow Row = Dt.Rows[i];
            for(; ; )
            {
                string item = Row["ID"].ToString();
                this.cmbBus.Items.Add(item);
                i++;
                try
                {
                    Row = Dt.Rows[i];
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

        private void DgvShedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string q = null;
            string id = null;
            bool ans = false;

            string tempid = null; 

                if (rbtnDriver.Checked == true)
                {
                    id = DataAccess.DataAccess.GetId("Driver");
                     tempid = id;
                    id = id.Substring(2, 1);
                    MessageBox.Show("id" + id);
                //  MessageBox.Show("id" + id.Substring(2, 1));
                //id.Substring(2, 1)
                int i = 0,bx=0;
                try
                {
                    i = Convert.ToInt32(id);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
                    i++;
                    q = "Select * from Driver where ID like ' " + this.EID + "';";
                try
                {
                    bx = DataAccess.DataAccess.ExecuteQuery(q);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                if (bx >= 1)
                    {
                    try
                    {
                        q = "update Bus.dbo.Driver set  Name ='" + this.txtName.Text + "', Address ='" + this.txtAddress.Text + "', Age=" + this.txtAge.Text + ", Phone='" + this.txtPhoneNo.Text + "', Salary=" + this.txtSalary.Text + ", Bonus =" + this.txtBonus.Text + ", BusId=" + this.cmbBus.SelectedItem.ToString() + ",NULL,'" + this.txtJoingDate + "' where ID Like '" + id + ";";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                    else
                {
                    try
                    {
                        q = "insert into Bus.dbo.Driver values ('D-" + i + "','" + this.txtName.Text + "','" + this.txtAddress.Text + "', " + this.txtAge.Text + " ,'" + txtPhoneNo.Text + "'," + this.txtSalary.Text + " , " + this.txtBonus.Text + "," + this.cmbBus.SelectedItem.ToString() + ",NULL,'" + txtJoingDate.Text + "');";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                }
                else
                {
                try
                {
                    id = DataAccess.DataAccess.GetId("SuperVisor");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }

                // MessageBox.Show("id" + id.Substring(2, 1));
                int i = 0;
                try
                {
                    i = Convert.ToInt32(id.Substring(2, 1));
                    i++;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                q = "Select * from Bus.dbo.SuperVisor where ID like ' " + this.EID + "';";
                int a = 0;
                try
                {
                    a = DataAccess.DataAccess.ExecuteQuery(q);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
               // MessageBox.Show("A" + a);
                    if (a >= 1)
                {
                    try
                    {
                        q = "update Bus.dbo.SuperVisor set  Name ='" + this.txtName.Text + "', Address ='" + this.txtAddress.Text + "', Age=" + this.txtAge.Text + ", Phone='" + this.txtPhoneNo.Text + "', Salary=" + this.txtSalary.Text + ", Bonus =" + this.txtBonus.Text + ", BusId=" + this.cmbBus.SelectedItem.ToString() + ",NULL,'" + txtJoingDate.Text + "' where ID Like '" + id + ";";
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                    }
                    else
                    {
                    try
                    {
                        q = "insert into Bus.dbo.SuperVisor values ('S-" + i + "' ,'" + this.txtName.Text + "','" + this.txtAddress.Text + "', " + this.txtAge.Text + " ,'" + txtPhoneNo.Text + "', " + this.txtSalary.Text + " , " + this.txtBonus.Text + "," + this.cmbBus.SelectedItem.ToString() + ",NULL,'" + txtJoingDate.Text + "');";
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                }
            }

            int ax = 0;
            try
            {
                ax = DataAccess.DataAccess.ExecuteQuery(q);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (ax >= 1)
            {
                MessageBox.Show("Success");
                new Password('A', tempid, "").Visible = true;
                this.Visible = false;
            }
            else MessageBox.Show("ERROR");
            
        }

        private void BtnDriver_CheckedChanged(object sender, EventArgs e)
        {
            string q = "Select * from Bus.dbo.Driver";
            try
            {
                PopulateGridView(q);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnSuperVisor_CheckedChanged(object sender, EventArgs e)
        {
            string q = "Select * from Bus.dbo.SuperVisor";
            try
            {
                PopulateGridView(q);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DgvShedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.EID = this.dgvShedule.CurrentRow.Cells["ID"].Value.ToString();

                this.txtName.Text = this.dgvShedule.CurrentRow.Cells["Name"].Value.ToString();
                this.txtAge.Text = this.dgvShedule.CurrentRow.Cells["Age"].Value.ToString();
                this.txtAddress.Text = this.dgvShedule.CurrentRow.Cells["Address"].Value.ToString();
                this.txtPhoneNo.Text = this.dgvShedule.CurrentRow.Cells["Phone"].Value.ToString();
                this.txtJoingDate.Text = this.dgvShedule.CurrentRow.Cells["Joining_Date"].Value.ToString();
                this.txtSalary.Text = this.dgvShedule.CurrentRow.Cells["Salary"].Value.ToString();
                this.txtBonus.Text = this.dgvShedule.CurrentRow.Cells["Bonus"].Value.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string q = null;
            if(this.btnDriver.Checked==true)
            {
                q = "Delete From Bus.dbo.Driver where ID Like '" + this.EID + "';";

            }
            else
            {
                q = "Delete From Bus.dbo.SuperVisor where ID Like '" + this.EID + "';";
            }
            int a = 0;
            try
            {
                 a = DataAccess.DataAccess.ExecuteQuery(q);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            if (a >= 1) MessageBox.Show("Delete");
            else MessageBox.Show("ERROR");
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string q = null;
            if (this.btnDriver.Checked == true)
            {
                try
                {
                    q = "Select * from Bus.dbo.Driver Where ID Like '%" + this.txtSearch.Text + "%' or  Name Like '%" + this.txtSearch.Text + "%';";
                    PopulateGridView(q);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                try
                {
                    q = "Select * from Bus.dbo.SuperVisor Where ID Like '%" + this.txtSearch.Text + "%' or  Name Like '%" + this.txtSearch.Text + "%';";
                    PopulateGridView(q);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        
    }
}
