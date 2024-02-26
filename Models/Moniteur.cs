namespace TP2_ASP_web.Models
{
    public class Moniteur
    {
        public int MoniteurId { get; set; }
        public string NoLicence { get; set; }
        public Utilisateur UtilisateurId { get; set; }
    }
}