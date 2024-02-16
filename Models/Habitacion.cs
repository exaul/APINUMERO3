namespace APINUMERO3.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
