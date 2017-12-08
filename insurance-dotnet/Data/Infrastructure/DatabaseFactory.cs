﻿using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private insurancedbContext dataContext;
        public insurancedbContext DataContext { get { return dataContext; } }

        public DatabaseFactory()
        {
            dataContext = new insurancedbContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }
    }

}
