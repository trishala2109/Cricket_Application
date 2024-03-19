using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace Cricket_Application.Models
{
    public class ChangeStatusDBHandler
    {
        SqlConnection conn;
        public void Connection()
        {
            string str = "Server = LAPTOP-9RQBBG2R\\SQLEXPRESS; Integrated Security = True; Database = Cricket_Application;";
            conn = new SqlConnection(str);
        }

        public bool GetTeam(ChangeStatusModel team)
        {
            Connection();
            conn.Open();

            string Query = "select TeamName from Teams where MatchID = '" + team.MatchID + "'";
            SqlCommand command = new SqlCommand(Query, conn);
            int result = command.ExecuteNonQuery();
            conn.Close();

            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
