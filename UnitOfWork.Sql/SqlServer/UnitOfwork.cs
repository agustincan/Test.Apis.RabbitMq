using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitOfWork.Sql.Abstraction;

namespace UnitOfWork.Sql.SqlServer
{
    public class UnitOfwork: IUnitOfWork
    {
        public UnitOfwork(DbContext context)
        {
            
        }
    }
}