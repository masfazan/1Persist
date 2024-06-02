using Microsoft.Data.SqlClient;
using Model;
using System.Text.Json;
using System.Xml.Linq;

namespace Repositories
{
    public class SQL
    {
        static string connectionString = "Server=127.0.0.1; Database=DBRadar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        public static void InsertDBRadar(List<Radar> radares)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Radar (concessionaria, ano_do_pnv_snv, tipo_de_radar, rodovia, uf, km_m, municipio, tipo_pista, sentido, situacao, data_da_inativacao, latitude, longitude, velocidade_leve)";
                foreach (Radar radar in radares)
                {
                    using (SqlCommand command = connection.CreateCommand())
                    {

                        command.Parameters.AddWithValue("@concessionaria", radar.concessionaria);
                        command.Parameters.AddWithValue("@ano_do_pnv_snv", radar.ano_PNV_SNV);
                        command.Parameters.AddWithValue("@tipo_de_radar", radar.tipo_Radar);
                        command.Parameters.AddWithValue("@rodovia", radar.rodovia);
                        command.Parameters.AddWithValue("@uf", radar.uf);
                        command.Parameters.AddWithValue("@km_m", radar.km_m);
                        command.Parameters.AddWithValue("@municipio", radar.municipio);
                        command.Parameters.AddWithValue("@tipo_pista", radar.tipo_Pista);
                        command.Parameters.AddWithValue("@sentido", radar.sentido);
                        command.Parameters.AddWithValue("@situacao", radar.situacao);
                        command.Parameters.AddWithValue("@data_da_inativacao", radar.data_Inativacao);
                        command.Parameters.AddWithValue("@latitude", radar.latitude);
                        command.Parameters.AddWithValue("@longitude", radar.longitude);
                        command.Parameters.AddWithValue("@velocidade_leve", radar.velocidade_Leve);
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
        //Recuperar dados SQL  
    }
}
