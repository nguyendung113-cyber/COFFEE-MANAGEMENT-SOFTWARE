using QuanLyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCoffee.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        public static int TableWidth = 90;
        public static int TableHeight = 90;

        private TableDAO() { }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTabel @idTable1 , @idTabel2", new object[] { id1, id2 });
        }

        public DataTable getListTable()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.TableFood");

        }

        public DataTable getTrangThai()
        {
            return DataProvider.Instance.ExecuteQuery("Select distinct  b.status from dbo.TableFood as b");

        }


        public bool InsertBan(string name, string status)
        {

            string query = string.Format("INSERT dbo.TableFood ( name, status)VALUES  ( N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteTable(string name)
        {
            string query = string.Format("Delete TableFood where name = '{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public List<Table> LoadTableList() {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
