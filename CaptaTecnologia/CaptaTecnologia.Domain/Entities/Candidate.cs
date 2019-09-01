namespace CaptaTecnologia.Domain.Entities
{
    public partial class Candidate
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string GenderCodigo { get; set; }

        public virtual Gender Gender { get; set; }

        public void EditCandidate(Candidate candidate)
        {
            this.Name = candidate.Name;
            this.LastName = candidate.LastName;
            this.GenderCodigo = candidate.GenderCodigo;
        }
    }
}