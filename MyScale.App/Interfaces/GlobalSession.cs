using MyScale.Domain.Models; // Importe o namespace novo

namespace MyScale.App
{
    public static class GlobalSession
    {
        // Agora usamos o LoggedUser que acabamos de criar
        public static LoggedUser? UsuarioLogado { get; set; }

        // Atalho para pegar o ID
        public static int UserId => UsuarioLogado?.Id ?? 0;

        public static bool IsHospital => UsuarioLogado?.Type == UserType.Hospital;
    }
}