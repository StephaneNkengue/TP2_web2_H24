namespace TP2_ASP_web.Models
{
    public class Cours
    {
        public int CoursId { get; set; }
        public string Titre { get; set; }
        public string description { get; set; }
        public int NombreMaximalSugerre { get; set; }
        public int DureeDuCoursMinutes { get; set; }
        public Cours CoursPrealablesId { get; set; }

    }
}
