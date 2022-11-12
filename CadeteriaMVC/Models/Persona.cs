namespace CadeteriaMVC.Models
{
    public abstract class Persona
    {
        private static uint Contador = 0;
        private readonly uint Id;
        private string? Nombre;
        private string? Direccion;
        private ulong Telefono;

        public Persona(string nombre, string direccion, ulong telefono)
        {
            Contador++;
            Id = Contador;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        public uint GetId()
        {
            return Id;
        }

        public string? GetNombre()
        {
            return Nombre;
        }

        public string? GetDireccion()
        {
            return Direccion;
        }

        public ulong GetTelefono()
        {
            return Telefono;
        }
    }
}
