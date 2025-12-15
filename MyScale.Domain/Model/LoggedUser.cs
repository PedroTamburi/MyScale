namespace MyScale.Domain.Models
{
    // Esta classe NÃO é uma tabela do banco. É só um "crachá" para a sessão.
    public class LoggedUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserType Type { get; set; }
    }

    public enum UserType
    {
        Hospital,
        HealthAgent
    }
}