using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spiewnik.Models.MODELE
{
    public class Autor
    {
        [Key]
        public int ID_Autora { get; set; }
        public string Nazwa { get; set; }
        public string LataDzialanosci { get; set; }
        public ICollection<Piosenka> Piosenki { get; set; }
    }
}
