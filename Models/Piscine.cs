using System.ComponentModel.DataAnnotations.Schema;

namespace TP2_ASP_web.Models
{
    public class Piscine
    {
        public int PiscineId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Nom { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }

        [Column(TypeName = "varchar(6)")]
        public string CodePostal { get; set; }
        public int CapaciteMaximale { get; set; }

    }
}
