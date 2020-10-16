using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.webAPI2.Models
{
    public class IdentidadeSecreta
    {
        public int ID { get; set; }
        public string NomeReal { get; set; }
        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
