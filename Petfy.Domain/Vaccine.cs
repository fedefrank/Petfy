﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfy.Domain
{
    public class Vaccine
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Lab { get; set; }
        public List<PetVaccine> PetVaccines { get; set; } = new List<PetVaccine>();
    }
}
