using Model;
namespace _1Persist
{
    public class ReadFile
    {
        public static List<Radar> GetData(string path)
        {
            List<Radar> radarLista = new List<Radar>();
            string jsonString;
            try
            {
                using StreamReader sr = new StreamReader(path);
                {

                    while ((jsonString = sr.ReadToEnd()) != null) ;
                    {
                        radarLista.Add(jsonString);
                        //concessionaria = reader["concessionaria"].ToString(),
                        //ano_PNV_SNV = reader["ano_do_pnv_snv"].ToString(),
                        //tipo_Radar = reader["tipo_de_radar"].ToString(),
                        //rodovia = reader["rodovia"].ToString(),
                        //uf = reader["uf"].ToString(),
                        //km_m = reader["km_m"].ToString(),
                        //municipio = reader["municipio"].ToString(),
                        //tipo_Pista = reader["tipo_pista"].ToString(),
                        //sentido = reader["sentido"].ToString(),
                        //situacao = reader["situacao"].ToString(),
                        //data_Inativacao = reader["data_da_inativacao"].ToString().Split(',').ToList(),
                        //latitude = reader["latitude"].ToString(),
                        //longitude = reader["longitude"].ToString(),
                        //velocidade_Leve = reader["velocidade_leve"].ToString(),
                    }
                    //radarLista = JsonConvert.DeserializeObject<List<Radar>>(jsonString);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
            }
            return radarLista;
        }
    }
    //public static string GetData(string path)
    //{
    //    string json = "";

    //    try
    //    {
    //        using (StreamReader sr = new StreamReader(path))
    //        {
    //            json = sr.ReadToEnd();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
    //    }

    //    return json;
    //}
}

