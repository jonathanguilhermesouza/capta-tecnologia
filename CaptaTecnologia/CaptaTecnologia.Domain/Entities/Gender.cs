using System.Collections.Generic;

namespace CaptaTecnologia.Domain.Entities
{
    public partial class Gender
    {
        public Gender()
        {
            Candidate = new HashSet<Candidate>();
        }

        public string Codigo { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Candidate> Candidate { get; set; }
    }
}