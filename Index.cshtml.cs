using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {

        public string fn;
        public void OnGet()
        {
            string connectionString = "Data Source=LU-CHENG\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;TrustServerCertificate=true";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string sqlQuery = "select firstname from Table_1";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()) {
                fn = dr["firstname"].ToString();

            }
            con.Close();
        }
    }
}