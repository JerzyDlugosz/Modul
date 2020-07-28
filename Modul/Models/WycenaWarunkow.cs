using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Models
{
    public class WycenaWarunkow
    {
        [Key]
        public int Id { get; set; }
        public int PotrzebnaIloscPaneli { get; set; }
        public decimal ProcentPokryciaZapotrzebowania { get; set; }
        public decimal PotrzebnaPowierzchniaDachu { get; set; }
        public decimal WielkoscInstalacji { get; set; }
        public decimal SuderowanaMocInwerteraOd { get; set; }
        public decimal SuderowanaMocInwerteraDo { get; set; }
        public string Inwerter { get; set; }
        public string NumerOferty { get; set; }
        public string WersjaFormularza { get; set; }
        public decimal IloscPunktow { get; set; }
        public string CzyPrzedluzycGwarancje { get; set; }
        public string FinansowanieSantander { get; set; }
        public int PotrzebnaIloscPaneliNaZyczenie { get; set; }
        public decimal ProcentPokryciaZapotrzebowaniaNaZyczenie { get; set; }
        public decimal PotrzebnaPowierzchniaDachuNaZyczenie { get; set; }
        public decimal WielkoscInstalacjiNaZyczenie { get; set; }
        public decimal SuderowanaMocInwerteraOdNaZyczenie { get; set; }
        public decimal SuderowanaMocInwerteraDoNaZyczenie { get; set; }
        public string InwerterNaZyczenie { get; set; }
        public string NumerOfertyNaZyczenie { get; set; }
        public string WersjaFormularzaNaZyczenie { get; set; }
        public decimal IloscPunktowNaZyczenie { get; set; }
        public string CzyPrzedluzycGwarancjeNaZyczenie { get; set; }
        public string FinansowanieSantanderNaZyczenie { get; set; }
    }
}
