﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacija_za_kladenje.Models
{
    public class TopMatchesPartialView
    {
        public List<TopMatchesViewModel> TopMatches { get; set; }
        public List<BetSlip> BetSlip { get; set; }
    }
}
