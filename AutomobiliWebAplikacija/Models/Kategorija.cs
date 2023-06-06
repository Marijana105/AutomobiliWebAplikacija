using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AutomobiliWebAplikacija.Models
{
    public class Kategorija
    {
        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        [Display(Name = "#")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Polje {0} je obvezno.")]
        public string Naziv { get; set; }
        public List<Automobil> Automobili { get; set; }
    }
}
