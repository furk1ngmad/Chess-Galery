using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessGalery.Models
{
    public class Repository
    {
        private static readonly List<Player> _players = new();

        public static List<Player> Players{
            get { return _players; }
        }

        static Repository()
        {
            _players = new List<Player>()
            {
                new Player() { Id = 1, Name = "Gukesh", Elo = 2748, Nationality="India" , Image="4.jpg", Age=17,Description="Gukesh D is a talented young chess player from India. He gained significant attention in the chess world when he became the second youngest grandmaster in history at the age of 12 years, 7 months, and 17 days. This achievement came in January 2019, when he earned his third and final GM norm at the 17th Delhi International Open Chess Tournament. Gukesh's rapid rise in the chess world has marked him as one of the most promising young talents in the game."},
                new Player() { Id = 2, Name = "Hikaru Nakamura", Elo = 2795, Nationality="USA",Image="3.jpg",Age=36,Description="Hikaru Nakamura is a highly accomplished chess grandmaster from the United States. He's renowned for his exceptional speed and tactical prowess, particularly in rapid and blitz formats. Nakamura has been one of the leading American chess players for many years and has consistently ranked among the world's top players."},
                new Player() { Id = 3, Name = "Ian Nepomniachtchi", Elo = 2787, Nationality="Russia",Image="1.jpg",Age=33,Description="Ian Nepomniachtchi is a Russian chess grandmaster who is among the elite players in the world. Born on July 14, 1990, in Bryansk, Russia, Nepomniachtchi has been a prominent figure in the international chess scene for many years."},
                new Player() { Id = 4, Name = "Fabiano Caruana", Elo = 2803, Nationality="USA",Image="2.jpg",Age=31,Description="Caruana's rise to prominence in the chess world began at an early age, and he achieved the title of Grandmaster in 2007 at the age of 14, making him one of the youngest grandmasters in history at that time. He has consistently been among the top-ranked players globally and has won numerous prestigious tournaments throughout his career."}
                
            };

        }

        public static Player? GetById(int? id)
        {
            return _players.FirstOrDefault(p => p.Id == id);
        }
    }
}