using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TantsuVoistlus.Models
{
    public class Voistlus
    {
        
        [Range(0, 5)]
        public string Voistluspaar { get; set; }
        public int Hinded1 { get; set; }
        public int Hinded2 { get; set; }
        public int Hinded3 { get; set; }
        public int KeskmineHinne { get; set; }
    }
}