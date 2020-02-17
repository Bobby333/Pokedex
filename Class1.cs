using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace pokemon
{
    class Class1
    {
        

        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string DexNumber { get; set; }
        public string HP { get; set;}
        public string DEf { get; set ; }
        public string ATK { get; set ; }
        public string SpAtk { get; set; }
        public string SpDef { get; set; }
        public string Spd { get; set; }
        public string Total {get; set;}
        public string Generation { get; set;}
        public string Legendary { get; set;}

		public void Dex(string legendary, string generation, string total, string name, string type1, string type2, string dexNumber, string hP, string dEf, string aTK, string spAtk, string spDef, string spd)
		{
			Name = name;
            Type1 = type1;
            Type2 = type2;
			DexNumber = dexNumber;
			HP = hP;
			DEf = dEf;
			ATK = aTK;
			SpAtk = spAtk;
			SpDef = spDef;
			Spd = spd;
            Total = total;
            Generation = generation;
            Legendary = legendary;
		}
	}
}
