using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public enum TipologiaMostro
    {
        Lucifer,
        Ghost
    }
    public class Mostro : Avversario
    {
        public int Id { get; set; }
        public TipologiaMostro TipologiaMostro { get; set; }
        //relazione 1-1 con mostro
    }
}
