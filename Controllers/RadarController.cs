using Model;
using Services;

namespace Controllers
{
    public class RadarController
    {
        private RadarService radarService;

        public RadarController()
        {
            radarService = new RadarService();
        }
        public bool Insert(Radar radar)
        {
            return true;
        }

        public bool Delete(int id)
        {
            return radarService.Delete(id);
        }
        public Radar Get(int id)
        {
            return radarService.Get(id);
        }

        public bool Update(Radar radar)
        {
            return radarService.Update(radar);
        }
        public List<Radar> GetAll()
        {
            return radarService.GetAll();
        }

        public static int getCountRecords(List<Radar> lista) => lista.Count;
        public static void printData(List<Radar> lst)
        {
            foreach (var p in lst)
            {
                Console.WriteLine(p);

            }
        }

    }
}
