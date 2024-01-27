namespace SistemaFacturacion.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
    }
}
