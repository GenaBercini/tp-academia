using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Dominio
{
    public class User
    {
        private static readonly List<User> _lista = new();
        private static int ultimoId = 0;

        [Key]
        public int IdUsuario { get; private set; }
        public string NombreUsuario { get; private set; }
        public string Clave { get; private set; }
        public bool Habilitado { get; private set; }
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public string Email { get; private set; }
        public bool CambiaClave { get; private set; }
        public bool Deleted { get; private set; }
        public int IdPersona { get; private set; }
        public static IReadOnlyList<User> Lista => _lista.AsReadOnly();
        public User(string nombreUsuario, string clave, bool habilitado, string nombre, string apellido, string email, int idPersona)
        {
            IdUsuario = GetNextId();
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Habilitado = habilitado;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            IdPersona = idPersona;
            CambiaClave = false;
            Deleted = false;
        }

        public void UpdateUser(string nombreUsuario, string clave, string nombre, string apellido, string email, bool habilitado, bool cambiaClave, int idPersona)
        {
            NombreUsuario = nombreUsuario;
            Clave = clave;
            Habilitado = habilitado;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            CambiaClave = cambiaClave;
            IdPersona = idPersona;
        }

        public void SetNombreUsuario(string nombreUsuario) => NombreUsuario = nombreUsuario;
        public void SetClave(string clave) => Clave = clave;
        public void SetHabilitado(bool habilitado) => Habilitado = habilitado;
        public void SetNombre(string nombre) => Nombre = nombre;
        public void SetApellido(string apellido) => Apellido = apellido;
        public void SetEmail(string email) => Email = email;
        public void SetCambiaClave(bool cambiaClave) => CambiaClave = cambiaClave;
        public void SetDeleted(bool deleted) => Deleted = deleted;
        public void SetIdPersona(int idPersona) => IdPersona = idPersona;

        public static int GetNextId()
        {
            ultimoId++;
            return ultimoId;
        }

        public void DeleteUser()
        {
            Deleted = true;
        }

        public static void AddUser(User user)
        {
            _lista.Add(user);
        }

        static User()
        {
            AddUser(new User("admin", "admin", true, "Administrador", "General", "admin@admin.com", 1));
            AddUser(new User("johndoe", "1234", false, "John", "Doe", "john.doe@example.com", 2));
            AddUser(new User("GenaBercini", "1234", true, "Genaro", "Bercini", "bercinigenaro@gmail.com", 3));
        }
    }
}
