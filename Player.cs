using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Player
    {
        public string Name { get; set; }
        public PlayerStats Stats { get; set; } = new PlayerStats();
        public List<Item> Items { get; set; } = new List<Item>();
    }
}
