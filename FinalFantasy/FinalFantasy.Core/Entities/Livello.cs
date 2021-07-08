using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public class Livello
    {
        public int Id { get; set; }
        public int Livello1 { get; set; } = 20;
        public int Livello2 { get; set; } = 40;
        public int Livello3 { get; set; } = 60;
        public int Livello4 { get; set; } = 80;
        public int Livello5 { get; set; } = 100;

        //relazione 1-1 con eroe
    }
}
