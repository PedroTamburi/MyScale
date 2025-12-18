using MyScale.Domain.Models;

namespace MyScale.App
{
    public static class GlobalSession
    {
        public static LoggedUser? UsuarioLogado { get; set; }

        public static int UserId => UsuarioLogado?.Id ?? 0;

        public static bool IsHospital => UsuarioLogado?.Type == UserType.Hospital;
    }
}