using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Models
{
    public class Oferta
    {
        [Key]
        public int Id { get; set; }
        public decimal RoczneZuzycieEnergii { get; set; }
        public string UmiejscowienieInstalacji { get; set; }
        public string PokrycieDachu { get; set; }
        public string Panele { get; set; }
        public string ProducentInwertera { get; set; }
        public string TypInwertera { get; set; }
        public decimal OdlegloscOdPaneeli { get; set; }
        public decimal OdlegloscOdRozdzielniGlownej { get; set; }
        public int IloscPaneli { get; set; }
        public decimal Moc { get; set; }
        public int OptymalizatoryTIGO { get; set; }
        public decimal WysokoscBudynku { get; set; }
        public decimal WartoscPVNetto { get; set; }
        public decimal WartoscPVBrutto { get; set; }
    }
}
