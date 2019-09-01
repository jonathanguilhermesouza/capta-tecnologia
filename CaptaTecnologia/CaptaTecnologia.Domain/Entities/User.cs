namespace CaptaTecnologia.Domain.Entities
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPasswordAsync(string username, string password)
        {
            return this.Username == username && this.Password == password;
        }
    }
}