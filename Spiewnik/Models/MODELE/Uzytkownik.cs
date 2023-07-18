using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spiewnik.Models.MODELE
{
    public class Uzytkownik
    {
        [Key]
        public int ID_Użytkownika { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public ICollection<Piosenka> Piosenki { get; set; }
        public ICollection<Ulubione> Ulubione { get; set; }
    }
}
