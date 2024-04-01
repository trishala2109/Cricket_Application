using System.Data.SqlClient;
namespace Cricket_Application.Models
{
    public class FinishMatchDBHandller
    {
        SqlConnection conn;
        public void Connection()
        {
            string str = "Server = SAYALKAPSE\\SQLEXPRESS; Integrated Security = True; Database = Cricket_Application;";
            conn = new SqlConnection(str);
        }

        public bool GetTeam(FinishMatch team)
        {
            Connection();
            conn.Open();

            string Query = "select TeamName from Teams where MatchId = '" + team.MatchId + "'";
            SqlCommand command = new SqlCommand(Query, conn);
            int result = command.ExecuteNonQuery();
            conn.Close();

            if (result > 0)
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

