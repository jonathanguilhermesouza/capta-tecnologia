using CaptaTecnologia.Data.Context;
using CaptaTecnologia.Data.Repositories.Base;
using CaptaTecnologia.Domain.Entities;

namespace CaptaTecnologia.Data.Repositories
{
    public class CandidateRepository : BaseRepository<Candidate>
    {
        public CandidateRepository(CaptaTecnologiaContext context)
            : base(context)
        {
        }
    }
}
