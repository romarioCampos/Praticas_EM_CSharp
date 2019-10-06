using System.Data.SqlClient;

namespace ConexaoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection ConexaoDB = new SqlConnection(@"data source=DESKTOP-BSMIKD3\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=DBMobiliaria");
            ConexaoDB.Open();

            string strQuerySelect = "SELECT * FROM Morador";
            SqlCommand cmdCommandoSelect = new SqlCommand(strQuerySelect, ConexaoDB);
            SqlDataReader dados = cmdCommandoSelect.ExecuteReader();
        }
    }
}
