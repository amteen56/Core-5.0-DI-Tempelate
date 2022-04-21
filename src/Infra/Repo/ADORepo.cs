using Core.Interface.Repo;
using Core.Interface.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repo
{
    public class ADORepo : IADORepo
    {
        public string conStr;
        public ADORepo(string conString)
        {
            conStr = conString;
        }
    }
}
