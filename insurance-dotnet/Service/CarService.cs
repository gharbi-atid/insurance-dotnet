
using Data.Infrastructure;
using Service.Pattern;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Data.Models;

namespace Service
{
    public   class CarService :Service<car> , ICarService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public CarService() : base(utw)
        {
        }
        public IEnumerable<car> GetAllCars()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/insurance-javaee-web/insurance/car/");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            var objs = JsonConvert.DeserializeObject<List<car>>(content);
            List<car> liste = new List<car>();
            foreach (car r in objs)
            {
                car c = new car();
                c.idCar = r.idCar;
                c.marque = r.marque;
                c.matricule = r.matricule;
                c.modele = r.modele;

                liste.Add(c);
            }
            return liste;
        }




    }
}
