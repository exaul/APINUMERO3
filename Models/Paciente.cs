namespace APINUMERO3.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Enfermedad { get; set; }
        public int HabitacionId { get; set; }
        public Habitacion Habitacion { get; set; }
    }
}
