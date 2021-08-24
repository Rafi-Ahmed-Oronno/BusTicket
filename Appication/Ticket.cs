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
    public partial class Ticket : MetroFramework.Forms.MetroForm
    {
        bool A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, x, y;
        string[] s = new string[15] { null, null, null,null,null,null,null,null,null,null,null,null,null,null,null };
        int count = 0;

        string str = null;
        string Sid = null;
        string ticket = null,Id=null,busId=null,dateTime=null;
        private char check;
        private Form a;
        string customerId;
        public Ticket(string id,char Check, Form a)
        {

            InitializeComponent();
            this.check = Check;
            this.a = a;
            this.customerId=id;
        }
        private void BtnB2_Click(object sender, EventArgs e)
        {
            count++;
            this.btnB2.BackColor = Color.Red;
             this.B2 = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
        }

        private void Btn01_Click(object sender, EventArgs e)
        {
            count++;
            this.btn01.BackColor = Color.Red;
            
                this.x = true;
                
            
            //else MessageBox.Show("You can not buy more then 5 ");
        }
        

        private void BtnC2_Click(object sender, EventArgs e)
        {
            count++;
            this.btnC2.BackColor = Color.Red;
            
                this.C2 = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
        }

        private void BtnC3_Click(object sender, EventArgs e)
        {
            count++;
            this.btnC3.BackColor = Color.Red;
            
                this.C3 = true;
                
            
         //   else MessageBox.Show("You can not buy more then 5 ");
        }

        private void BtnC4_Click(object sender, EventArgs e)
        {
            count++;
            this.btnC4.BackColor = Color.Red;
            
                this.C4 = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
        }

        private void BtnC1_Click(object sender, EventArgs e)
        {
            count++;
            this.btnC1.BackColor = Color.Red;
            
                this.C1 = true;
                
            


          //  else MessageBox.Show("You can not buy more then 5 ");
        }

        
        private void setVisible()
        {
            btnA1.Visible = true;
            btnA2.Visible = true;
            btnA3.Visible = true;
            btnA4.Visible = true;
            btnB1.Visible = true;
            btnB2.Visible = true;
            btnB3.Visible = true;
            btnB4.Visible = true;
            btnC1.Visible = true;
            btnC2.Visible = true;
            btnC3.Visible = true;
            btnC4.Visible = true;
            btn01.Visible = true;
            btn02.Visible = true;

        }
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticket = null;
                Id = cmbRoute.SelectedItem.ToString().Substring(0, 1);
                string q = "select * from Bus.dbo.Shedule where ID =" + Id + ";";
                DataTable dt = SheduleRepo.SheduleRepo.GetData(q);
                DataRow Row = dt.Rows[0];
                this.ticket = Row["Seat_Status"].ToString();
                this.busId = Row["BusId"].ToString();
                this.dateTime = this.cmbDate.SelectedItem.ToString() + " " + this.cmbTime.SelectedItem.ToString();
                q = "Select * from Bus.dbo.Customers";
                dt = DataAccess.DataAccess.GetDataTable(q);
                Row = dt.Rows[0];
                //this.count = Convert.ToInt32(Row["Ticket_Information"].ToString());
                this.str = Row["Seat_Number"].ToString();
                string temp = null;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != ' ') temp += str[i];

                }
                str = temp;
                // if (this.count > 5) MessageBox.Show("You can not buy more Than " + this.count);

                setVisible();
                for (int i = 0; i < ticket.Length; i++)
                {
                    switch (ticket[i])
                    {
                        case '1':
                            {
                                btnA1.Visible = false;
                                break;
                            }
                        case '2':
                            {
                                btnA2.Visible = false;
                                break;
                            }
                        case '3':
                            {

                                btnA3.Visible = false;
                                break;
                            }
                        case '4':
                            {

                                btnA4.Visible = false;
                                break;
                            }
                        case '5':
                            {

                                btnB1.Visible = false;
                                break;
                            }
                        case '6':
                            {

                                btnB2.Visible = false;
                                break;
                            }
                        case '7':
                            {

                                btnB3.Visible = false;
                                break;
                            }
                        case '8':
                            {

                                btnB4.Visible = false;
                                break;
                            }
                        case '9':
                            {

                                btnC1.Visible = false;
                                break;

                            }
                        case 'A':
                            {
                                btnC2.Visible = false;
                                break;
                            }
                        case 'B':
                            {

                                btnC3.Visible = false;
                                break;

                            }
                        case 'C':
                            {

                                btnC4.Visible = false;
                                break;
                            }
                        case 'D':
                            {

                                btn01.Visible = false;
                                break;
                            }
                        case 'E':
                            {

                                btn02.Visible = false;
                                break;
                            }
                    }
                }
                this.pTicket.Visible = true;

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnB4_Click(object sender, EventArgs e)
        {
            count++;
            
                this.B4 = true;
               
            

           // else MessageBox.Show("You can not buy more then 5 ");
        }

        

        private void BtnB3_Click(object sender, EventArgs e)
        {
            count++;
            this.btnB3.BackColor = Color.Red;
           
                this.B3 = true;
                
            
                    
            //else MessageBox.Show("You can not buy more then 5 ");
        }

        

        private void BtnB1_Click(object sender, EventArgs e)
        {
            count++;
            this.btnB1.BackColor = Color.Red;
            
                this.B1 = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
        }

        private void BtnA4_Click(object sender, EventArgs e)
        {
            this.btnA4.BackColor = Color.Red;
            
           
                this.A4 = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
        }

        private void Btn02_Click(object sender, EventArgs e)
        {
            this.btn02.BackColor = Color.Red;
            
            
                
                this.y = true;
                
            
           // else MessageBox.Show("You can not buy more then 5 ");
            
        }

        private void BtnA3_Click(object sender, EventArgs e)
        {
            this.btnA3.BackColor = Color.Red;
            bool ans = Validation.Validation.count(count);
          
                count++;
                this.A3 = true;
               // this.btnA3.BackColor = Color.AliceBlue;
            //else MessageBox.Show("You can not buy more then 5 ");
        }
   
        private void BtnA2_Click(object sender, EventArgs e)
        {
            //count++;
            btnA2.BackColor = Color.Red;
            bool ans = Validation.Validation.count(count);
            
                this.A2 = true;
                
            
          //  else MessageBox.Show("You can not buy more then 5 ");
        }

       

        private void Ticket_Load(object sender, EventArgs e)
        {
            this.pTicket.Visible = false;
            if (check == 'B')
            {
                this.pReturn.Visible = false;
                string q = "Select * from Bus.dbo.Shedule";
                DataTable dt = SheduleRepo.SheduleRepo.GetData(q);
                int i = 0;
                DataRow Row = dt.Rows[i];
                for(; ; )
                {
                    if (dt.Rows[i] == null) break;

                        string item = Row["ID"].ToString()+ " "+Row["Route"].ToString();
                        cmbRoute.Items.Add(item);                                    
                        item = Row["Time"].ToString();
                        cmbTime.Items.Add(item);
                        item = Row["Date"].ToString().Substring(0,9);
                        cmbDate.Items.Add(item);
                        i++;
                    try {
                        Row = dt.Rows[i];
                    }
                    catch(Exception ex)
                    {
                        break;
                    }                  
                }
                
            }
            if(check=='R')
            {
                this.pTicket.Visible = false;
                //  this.dtpTicketBuy.Visible = false;
                this.cmbDate.Visible = false;
                this.cmbTime.Visible = false;
                this.cmbRoute.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
                this.btnConfirm.Visible = false;
                this.pReturn.Visible = true;
                try
                {
                    string q = "select Ticket_Information,Journey_Date from Bus.dbo.Customers where ID =" + Id + ";";
                    DataTable dt = DataAccess.DataAccess.GetDataTable(q);
                    DataRow Row = dt.Rows[0];
                    
                    this.txtReturnTicket.Text = Row["Ticket_Information"].ToString() + " " + Row["Journey_Date"].ToString();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
        }


        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.a.Visible = true;
            this.Visible = false;
        }

        
        
        private void BtBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                string t = null;
                if (A1 == true)
                {
                    btnA1.Visible = false;
                    s[i++] = "1";
                    t += " A1";
                }
                if (A2 == true)
                {
                    btnA2.Visible = false;
                    s[i++] = "2";
                    t += " A2";
                }
                if (A3 == true)
                {
                    btnA3.Visible = false;
                    s[i++] = "3";
                    t += " A3";
                }
                if (A4 == true)
                {
                    btnA4.Visible = false;
                    s[i++] = "4";
                    t += " A4";
                }
                if (B1 == true)
                {
                    btnB1.Visible = false;
                    s[i++] = "5";
                    t += " B1";
                }
                if (B2 == true)
                {
                    btnB2.Visible = false;
                    s[i++] = "6";
                    t += " B2";
                }
                if (B3 == true)
                {
                    btnB3.Visible = false;
                    s[i++] = "7";
                    t += " B3";
                }
                if (B4 == true)
                {
                    btnB4.Visible = false;
                    s[i++] = "8";
                    t += " B4";
                }
                if (C1 == true)
                {
                    btnC1.Visible = false;
                    s[i++] = "9";
                    t += " C1";
                }
                if (C2 == true)
                {
                    btnC2.Visible = false;
                    s[i++] = "A";
                    t += " C2";
                }
                if (C3 == true)
                {
                    btnC3.Visible = false;
                    s[i++] = "B";
                    t += " C3";
                }
                if (C4 == true)
                {
                    btnC4.Visible = false;
                    s[i++] = "C";
                    t += " C4";
                }
                if (x == true)
                {
                    btn01.Visible = false;
                    s[i++] = "D";
                    t += " 01";
                }
                if (y == true)
                {
                    btn02.Visible = false;
                    s[i++] = "E";
                    t += " 02";
                }

                for (i = 0; i < 5; i++)
                {
                    str += s[i];
                }
                //MessageBox.Show("Str" + str);
                this.cmbRoute.Items.Add(str);
                this.ticket += str;

                string q = "update Bus.dbo.Customers set Return_Ticket='" + t + "', Journey_Date = '" + this.cmbDate.SelectedItem.ToString() + "', Seat_Number = '" +str +  "', SheduleID = '" + this.cmbRoute.SelectedItem.ToString().Substring(0,1) + "'  where id like '" + this.customerId + "';";
                DataAccess.DataAccess.ExecuteQuery(q);
                q = "update Bus.dbo.Shedule set Seat_Status='" + this.ticket + "' where id=" + this.Id + ";";
                SheduleRepo.SheduleRepo.Execute(q);
                //MessageBox.Show(a + "Row Updated");

                ticket = null;
                str = null;
                MessageBox.Show("Requested");
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {
            this.btnA1.BackColor = Color.Red;
            count++;
            
                this.A1 = true;
                //this.btnA1.BackColor = Color.AliceBlue;
            
           // else MessageBox.Show("You can not buy more then 5 ");

        }
    }
}
