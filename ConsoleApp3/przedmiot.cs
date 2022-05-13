using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolClasses
{
	public class przedmiot : Item
    {
        public przedmiot()
        {
            name = "Bow";
            price = "1000";
            AddStat(Stat.AP, 50);
        }

    }

}