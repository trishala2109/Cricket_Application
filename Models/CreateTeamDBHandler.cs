using Microsoft.AspNetCore.Components.Web;
using System.Data.SqlClient;

namespace Cricket_Application.Models
{
    public class CreateTeamDBHandler
    {
        SqlConnection con;
        private void connection()
        {
            string constring = "server=.\\sqlexpress;integrated security=true;database=Cricket_Application";
            con = new SqlConnection(constring);
        }

        public bool insertCreateTeam(CreateTeam createTeam)
        {
            connection();
            string query= "INSERT INTO CreateTeam VALUES('" + createTeam.TeamName + "','" + createTeam.TeamLogo + "'," + createTeam.MatchDateTime + "'," + createTeam.MatchType+ "'," + createTeam.OtherMatchType+ "'," + createTeam.BattingTeam+ "'," + createTeam.BallingTeam+")";
            SqlCommand cmd=new SqlCommand(query, con);
            con.Open();
            int ct = cmd.ExecuteNonQuery();
            con.Close();
            if(ct>0)
            
                return true;
            else
                return false;
        }
    }
}
