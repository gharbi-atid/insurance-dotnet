using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using Data.Models;
using Service.Pattern;

namespace Service
{
    public class RendezvousService : Service<Rendezvous>
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);
        public RendezvousService() : base(unt)
        {
        }
    }
}
