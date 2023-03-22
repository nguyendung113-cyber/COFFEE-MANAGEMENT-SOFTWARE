using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DTO
{
    public class Table
    {

        private string status;
        private string name;
        private int iD;
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }

        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }      
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
