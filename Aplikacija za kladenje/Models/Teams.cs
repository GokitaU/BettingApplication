﻿

namespace Aplikacija_za_kladenje.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Leagues League { get; set; }

    }
}
