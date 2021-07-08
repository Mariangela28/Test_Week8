using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.FinalFantasy.Core.Entities
{
    public enum TipologiaEroe
    {
        Soldier,
        Wizard
    }
    public class Eroe : Avversario
    {
        public int Id { get; set; }
        public TipologiaEroe TipologiaEroe { get; set; }
        public Giocatore Giocatore { get; set; }
        public int GiocatoreId { get; set; }

        //relazione 1-1 con livello
    }
}
