
using Data.Infrastructure;
using Service.Pattern;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Data.Models;

namespace Service
{
    public   class UserService :Service<user> , IUserService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public UserService() : base(utw)
        {
        }
        public IEnumerable<user> afficher()
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
            var objs = JsonConvert.DeserializeObject<List<user>>(content);
            List<user> liste = new List<user>();
            foreach (user r in objs)
            {
                user rec = new user();

                rec = r;
                liste.Add(rec);
            }
            return liste;
        }




    }
}
