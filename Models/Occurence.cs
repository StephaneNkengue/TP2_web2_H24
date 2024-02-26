namespace TP2_ASP_web.Models
{
    public class Occurence
    {
        public int OccurenceId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Groupe GroupeId { get; set; }

    }
}
