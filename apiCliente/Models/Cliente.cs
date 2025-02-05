namespace apiCliente.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public required string nombre { get; set; }
        public required string telefono { get; set; }
        public required string pais {  get; set; }
    }
}
