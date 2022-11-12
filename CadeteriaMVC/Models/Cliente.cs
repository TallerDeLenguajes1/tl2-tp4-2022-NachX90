namespace CadeteriaMVC.Models
{
    public class Cliente : Persona
    {
        private string? ReferenciaDeDireccion;

        public Cliente(string nombre, string direccion, ulong telefono, string referenciaDeDireccion) : base(nombre, direccion, telefono)
        {
            ReferenciaDeDireccion = referenciaDeDireccion;
        }

        public string? GetReferenciaDeDireccion()
        {
            return ReferenciaDeDireccion;
        }

        public bool SetReferenciaDeDireccion(string referenciaDeDireccion)
        {
            try
            {
                ReferenciaDeDireccion = referenciaDeDireccion;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
