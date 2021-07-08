using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public enum Nome
    {
        Ascia,
        Mazza,
        Spada,
        ArcoFrecce,
        Bacchetta,
        BastoneMagico,
        Arco,
        Clava,
        Divinazione,
        Fulmine,
        Tempesta
    }
    public class Arma 
    {
        public int Id { get; set; }
        public Nome Nome { get; set; }
        public string TipologiaEroe {get; set; }
        public string TipologiaMostro { get; set; }
        public int PuntiDanno { get; set; }
        //relazione 1-1 con eroe
    }
}
