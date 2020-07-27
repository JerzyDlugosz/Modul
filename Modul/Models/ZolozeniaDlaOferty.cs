using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Modul.Models
{
    public class ZolozeniaDlaOferty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PokazFormularz { get; set; }
        [Required]
        public string CzyRolnik { get; set; }
        [Required]
        public int ProgPodatkowy { get; set; }
        [Required]
        public Wojewodztwo Wojewodztwo { get; set; }
        [Required]
        public int MiesieczneRachunki { get; set; }
        public string ZnajomoscRocznychRachunkowiZuzywanaEnergia { get; set; }
        [Required]
        public string ImieiNazwiskoKlienta { get; set; }
        public string Paneltechniczny { get; set; }
        public string WycenaNaZyczenie { get; set; }


    }
    public enum Wojewodztwo
    {
        dolnośląskie, kujawsko_pomorskie, lubelskie, lubuskie, łódzkie, małopolskie, mazowieckie,
        opolskie, podkarpackie, podlaskie, pomorskie, śląskie, świętokrzyskie, warmińsko_mazurskie, 
        wielkopolskie, zachodniopomorskie
    }
}
