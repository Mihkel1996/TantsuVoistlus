﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TantsuVoistlus.Models
{
    public class VoistlusViewModels
    {
        public int Id { get; set; }
        public string Voistluspaar { get; set; }
        public int Hinne1 { get; set; }
        public int Hinne2 { get; set; }
        public int Hinne3 { get; set; }
        public int KeskmineHinne { get; set; }
    }
}