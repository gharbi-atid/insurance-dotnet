using Data.Infrastructure;
using Data.Models;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public  class EventService:Service<evenement>
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);
        public EventService() : base(unt)
        {
        }
    }
}
