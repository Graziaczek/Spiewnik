using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spiewnik.Models.MODELE
{
    public class Gatunek
    {
        [Key]
        public int ID_Gatunku { get; set; }
        public string NazwaGatunkku { get; set; }
        public ICollection<GatunkiPiosenki> Piosenki { get; set; }
    }
}
