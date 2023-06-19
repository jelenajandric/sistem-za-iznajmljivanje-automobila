﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Data.Model
{
    public class Zaposleni : Osoba
    {
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public string tema { get; set; }
        public int onemogucen { get; set; } = 0; // =0 => nije onemugucen
    }
}
