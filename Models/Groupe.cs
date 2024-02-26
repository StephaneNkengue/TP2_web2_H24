namespace TP2_ASP_web.Models
{
    public class Groupe
    {
        public int GroupeId { get; set; }
        public int NumeroGroupe { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public Piscine PiscineId { get; set; }
        public Moniteur MoniteurParDefautId { get; set; }
    }
}