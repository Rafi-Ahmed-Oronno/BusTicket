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
    public partial class Return_Ticket : MetroFramework.Forms.MetroForm
    
    {
        Form a;
        DataTable dt;
        string t,q,id,cid,ct;
        DataRow Row;
        public Return_Ticket(Form a)
        {
            InitializeComponent();
            this.a = a;
        }
        private void PopulateGridView()
        {
            try
            {
                this.dgvReturnTicket.AutoGenerateColumns = false;
                q = "select * from Bus.dbo.Customers where Return_Ticket Like '%%'";
                dt = DataAccess.DataAccess.GetDataTable(q);
                this.dgvReturnTicket.DataSource = dt;
                Row = dt.Rows[0];
                id = Row["SheduleID"].ToString();
                ct = Row["Seat_Number"].ToString();
                q = "select * from Bus.dbo.Shedule where ID=" + id + ";";
                dt = DataAccess.DataAccess.GetDataTable(q);
                Row = dt.Rows[0];
                t = Row["Seat_Status"].ToString();
                //MessageBox.Show(t
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string q = "update Bus.dbo.Customers set Return_Ticket=null where ID like '" + this.cid + "';";
            int a = DataAccess.DataAccess.ExecuteQuery(q);
            if (a >= 0) MessageBox.Show("Accepted");
            PopulateGridView();

        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            try
            {
                string[] str = new string[12];
                for (int i = 0; i < str.Length; i++) str[i] = null;
                for (int i = 0; i < t.Length; i++) str[i] = t[i].ToString();
                //MessageBox.Show(t);
                string temp = null;
                for (int i = 0; i < str.Length; i++)
                {
                    temp = temp + str[i];
                }
                //MessageBox.Show("temp"+temp);
                for (int i = 0; i < str.Length; i++)
                {
                    for (int j = 0; j < ct.Length; j++)
                    {
                        if (ct[j].ToString() == str[i])
                        {
                            // MessageBox.Show(ct[j].ToString(), str[i]);
                            str[i] = null;
                            break;
                        }
                    }
                }
                // MessageBox.Show();
                temp = null;
                for (int i = 0; i < str.Length; i++)
                {
                    temp = temp + str[i];
                }
                q = "update Bus.dbo.Shedule set Seat_Status='" + temp + "' where id=" + this.id + ";";
                int ans = SheduleRepo.SheduleRepo.Execute(q);
                // if (ans >= 0) MessageBox.Show("Rejected");
                q = "update Bus.dbo.Customers set Return_Ticket=null, Journey_Date = null, Seat_Number = null, SheduleID = null  where id like '" + this.cid + "';";
                ans = DataAccess.DataAccess.ExecuteQuery(q);
                if (ans >= 0) MessageBox.Show("Rejected");
                PopulateGridView();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            //MessageBox.Show(temp);


        }

        private void DgvReturnTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cid= this.dgvReturnTicket.CurrentRow.Cells["CustomerID"].Value.ToString();
           // this.ct = this.dgvReturnTicket.CurrentRow.Cells["seatNumber"].Value.ToString();
            //MessageBox.Show(cid, ct);
        }

        private void Return_Ticket_Load(object sender, EventArgs e)
        {
            PopulateGridView();
            q = "select * from Bus.dbo.Shedule;";
            dt=SheduleRepo.SheduleRepo.GetData(q);
            
            Row = dt.Rows[0];
            string i = Row["ID"].ToString();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }
    }
}
