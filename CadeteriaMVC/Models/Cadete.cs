namespace CadeteriaMVC.Models
{
    public class Cadete : Persona
    {
        private static decimal Comision = 300;
        private List<Pedido> ListadoDePedidos;

        public Cadete(string nombre, string direccion, ulong telefono) : base(nombre, direccion, telefono)
        {
            ListadoDePedidos = new List<Pedido>();
        }

        public decimal GetComision()
        {
            return Comision;
        }

        public bool SetComision(decimal comision)
        {
            try
            {
                Comision = comision;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public decimal GetJornalACobrar()
        {
            return ListadoDePedidos.Where(x => x.GetEstado() == Estado.Entregado).Count() * GetComision();
        }

        public bool AsignarPedido(Pedido pedido)
        {
            if (pedido.GetEstado() == Estado.Aprobado)
            {
                try
                {
                    ListadoDePedidos.Add(pedido);
                    pedido.SetEstado(Estado.Asignado);
                    return true;
                }
                catch
                {
                    pedido.SetEstado(Estado.Aprobado);
                    if (ListadoDePedidos.Contains(pedido))
                    {
                        ListadoDePedidos.Remove(pedido);
                    }
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
