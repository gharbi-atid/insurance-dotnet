
using Data.Infrastructure;
using Service.Pattern;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Data.Models;

namespace Service
{
    public   class ReclamationService :Service<reclamation> , IReclamationService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public ReclamationService() : base(utw)
        {
        }
        public IEnumerable<reclamation> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/insurance-javaee-web/insurance/reclamation");
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
            var objs = JsonConvert.DeserializeObject<List<reclamation>>(content);
            List<reclamation> liste = new List<reclamation>();
            foreach (reclamation r in objs)
            {
                reclamation rec = new reclamation();

                rec = r;
                liste.Add(rec);
            }
            return liste;
        }




    }
}
