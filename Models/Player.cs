using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessGalery.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int Age { get; set; }

        public string? Description { get; set; }

        public string? Image { get; set; }
        public int Elo { get; set; }
        public string? Nationality { get; set; }
    }
}