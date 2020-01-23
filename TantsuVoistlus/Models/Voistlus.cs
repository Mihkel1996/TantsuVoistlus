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
        public string Eesnimi1 { get; set; }
        public string Perenimi1 { get; set; }
        public string Eesnimi2 { get; set; }
        public string Perenimi2 { get; set; }
        public int Vanus { get; set; }
        [Range(0, 5)]
        public int Hinded1 { get; set; }
        public int Hinded2 { get; set; }
        public int Hinded3 { get; set; }
        public int KeskmineHinne { get; set; }
    }
}