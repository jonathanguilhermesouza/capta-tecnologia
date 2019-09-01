using CaptaTecnologia.Data.Context;
using CaptaTecnologia.Data.Repositories.Base;
using CaptaTecnologia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CaptaTecnologia.Data.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(CaptaTecnologiaContext context)
            : base(context)
        {
        }

        public bool IsTrue(Expression<Func<User, bool>> predicateWhere)
        {
            return _context.User.Any(predicateWhere);
        }
    }
}
