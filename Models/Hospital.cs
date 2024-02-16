namespace APINUMERO3.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
    }
}
