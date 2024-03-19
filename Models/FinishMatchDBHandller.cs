using System.Data.SqlClient;
namespace Cricket_Application.Models
{
    public class FinishMatchDBHandller
    {
        SqlConnection con;
        private void connection()
        {
            string constring = "server=.\\sqlexpress;integrated security=true;database=Cricket_Application";
            con=new SqlConnection(constring);

        }

       
        

    }
}
