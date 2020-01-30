using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TantsuVoistlus.Models
{
    public class Voistlus
    {

        public int Id { get; set; }
        public string Voistluspaar { get; set; }
        [Range(1, 5)]
        public int Hinded1 { get; set; }
        [Range(1, 5)]
        public int Hinded2 { get; set; }
        [Range(1, 5)]
        public int Hinded3 { get; set; }
        public int KeskmineHinne { get; set; }
    }
}