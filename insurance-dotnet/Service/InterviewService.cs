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
    public class InterviewService : Service<Interview>
    {
        private static DatabaseFactory dbf = new DatabaseFactory();
        private static UnitOfWork unt = new UnitOfWork(dbf);
        public InterviewService() : base(unt)
        {
        }
    }
}
