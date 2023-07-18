using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Spiewnik.Models.MODELE
{
    public class Ulubione
    {
        public int ID_Uzytkownika { get; set; }
        public int ID_Piosenki { get; set; }
        public Uzytkownik Uzytkownik { get; set; }
        public Piosenka Piosenka { get; set; }
    }
}
