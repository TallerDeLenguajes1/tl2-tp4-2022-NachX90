namespace CadeteriaMVC.Models
{
    public class Pedido
    {
        private static uint Contador = 0;
        private readonly uint Nro;
        private readonly string? Obs;
        private readonly Cliente? Cliente;
        private Estado Estado;

        public Pedido(string? obs, Cliente? cliente)
        {
            Nro = Contador++;
            Obs = obs;
            Cliente = cliente;
            Estado = Estado.EnEspera;
        }

        public uint GetNro()
        {
            return Nro;
        }

        public string? GetObs()
        {
            return Obs;
        }

        public Estado GetEstado()
        {
            return Estado;
        }

        public bool SetEstado(Estado estado)
        {
            try
            {
                Estado = estado;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
