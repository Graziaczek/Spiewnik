using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spiewnik.Models.MODELE
{
    public class Piosenka
    {
        [Key]
        public int ID_Piosenki { get; set; }
        public string Tytul { get; set; }
        public string Tekst { get; set; }
        public string Akordy { get; set; }
        public DateTime CzasTrwania { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public Autor Autor { get; set; }
        public ICollection<GatunkiPiosenki> Gatunki { get; set; }
        public ICollection<Ulubione> Ulubione { get; set; }
    }
}
