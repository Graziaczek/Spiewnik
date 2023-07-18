using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spiewnik.Models.MODELE
{
    public class GatunkiPiosenki
    {
        public int ID_Gatunku { get; set; }
        public int ID_Piosenki { get; set; }
        public Gatunek Gatunek { get; set; }
        public Piosenka Piosenka { get; set; }

    }
}
