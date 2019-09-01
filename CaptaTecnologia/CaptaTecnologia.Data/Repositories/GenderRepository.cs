using CaptaTecnologia.Data.Context;
using CaptaTecnologia.Data.Repositories.Base;
using CaptaTecnologia.Domain.Entities;

namespace CaptaTecnologia.Data.Repositories
{
    public class GenderRepository : BaseRepository<Gender>
    {
        public GenderRepository(CaptaTecnologiaContext context)
            : base(context)
        {
        }
    }
}
