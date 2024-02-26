namespace TP2_ASP_web.Models
{
    public class Inscription
    {
        public int InscriptionId { get; set; }
        public DateTime DateInscription { get; set; }
        public Utilisateur UtilisateurId { get; set; }
        public Groupe CoursGroupeId { get; set; }
    }
}
