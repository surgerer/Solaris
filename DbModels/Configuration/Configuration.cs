﻿using EFCache;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels
{
    public class Configuration : DbConfiguration
    {
        public Configuration()
        
        {
           // кэш второго уровня.не включать
            //    var transactionHandler = new CacheTransactionHandler(new InMemoryCache());

            //AddInterceptor(transactionHandler);

            //var cachingPolicy = new CachingPolicy();

            //Loaded +=
            //  (sender, args) => args.ReplaceService<DbProviderServices>(
            //    (s, _) => new CachingProviderServices(s, transactionHandler,
            //      cachingPolicy));
        }
    }
}
