using Core.Interface.DBContext;
using Core.Interface.Repo;
using Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repo
{
    public class EFRepo : IEFRepo
    {
        private readonly IAppDbContext dbContext;
        private readonly IAppLogger logger;
        public EFRepo(IAppDbContext oContext, IAppLogger ologger)
        {
            this.dbContext = oContext;
            this.logger = ologger;
        }
    }
}
