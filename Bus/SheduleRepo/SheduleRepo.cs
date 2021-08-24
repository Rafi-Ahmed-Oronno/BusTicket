using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SheduleRepo
{
    public class SheduleRepo
    {
        public static int GetId()
        {
            string i = DataAccess.DataAccess.GetId("Bus.dbo.Shedule");
            if (i == null) return 0;
            int  id = Convert.ToInt32(i);
            return id;
        }
        public static int Execute(string q)
        {
            int a = DataAccess.DataAccess.ExecuteQuery(q);
            return a;
        }
        public static DataTable GetData(string q)
        {
            DataTable dt = DataAccess.DataAccess.GetDataTable(q);
            return dt;
        }
        public static bool Save(Entity.Shedule pro)
        {
            try
            {
                //Console.WriteLine(pro.id + pro.Route);
                string query = "select * from Bus.dbo.Shedule where ID = " + pro.id + " Order by ID";
                var dt = DataAccess.DataAccess.GetDataTable(query);
                

                if (dt == null || dt.Rows.Count == 0)
                {
                    //return true;
                    query = "Insert into Bus.dbo.Shedule values (" + pro.id + ",'" + pro.Date + "','" + pro.Time + "','" + pro.Route + "'," + pro.Busid + ",'" + pro.Driver + "','" + pro.SuperVisor + "','" + pro.SeatStatus + "','" + pro.BusStatus + "');";
                   
                }
                else
                {
                   // return true;
                    query = "Update Bus.dbo.Shedule set Date = '" + pro.Date + "',Time= '" + pro.Time + "',Route= '" + pro.Route + "',BusId= '" + pro.Busid +"',Driver= '" + pro.Driver + "',SuperVisor= '" + pro.SuperVisor + "',Seat_Status= '" + pro.SeatStatus + "', Bus_Status='" + pro.BusStatus + "' where  ID= " + pro.id + ";";
                }
                
                int count = DataAccess.DataAccess.ExecuteQuery(query);
               // if (count == 0) return true;

                if (count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            string query = "delete from product where appid = '" + id + "'";
            int count = DataAccess.DataAccess.ExecuteQuery(query);
            if (count == 1)
                return true;
            else
                return false;

        }

        private Entity.Shedule ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var p = new Entity.Shedule();
            p.id = Convert.ToInt32(row["ID"].ToString());
            p.Date= row["Date"].ToString();
            p.Time = row["Time"].ToString();
            p.Route=row["Route"].ToString();
            p.Busid = Int32.Parse(row["quantity"].ToString());
            p.Driver = row["Driver"].ToString();
            p.SuperVisor = row["SuperVisor"].ToString();
            p.SeatStatus = row["Seat_Status"].ToString();
            p.BusStatus = row["Bus_Status"].ToString();
            return p;
        }
    }
}
