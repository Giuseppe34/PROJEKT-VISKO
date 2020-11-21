using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    class Rezervace 
    {
        /// <summary>
        /// list do ktereho budu ukladat pujcene naradi
        /// </summary>
        private List<Naradi> m_PujceneNaradi; 
        public List<Naradi> PujceneNaradi
        {
            get => m_PujceneNaradi;
            set => m_PujceneNaradi = value;
        }
        private DateTime m_DatumVypujcky;
        public DateTime DatumVypujcky
        {
            get => m_DatumVypujcky;
            set => m_DatumVypujcky = value;
        }
        private int m_DelkaVypujcky;
        public int DelkaVypujcky
        {
            get => m_DelkaVypujcky;
            set => m_DelkaVypujcky = value;
        }
        private Zakaznik m_Zakaznik;
        public Zakaznik Zakaznik
        {
            get => m_Zakaznik;
            set => m_Zakaznik = value;
        }
        private Pracovnik m_Pracovnik;
        public Pracovnik Pracovnik
        {
            get => m_Pracovnik;
            set => m_Pracovnik = value;           
        }
        public Rezervace(Osoba zak, Osoba prac, DateTime okamzikVypujcky)
        {
            Zakaznik = (Zakaznik)zak;
            Pracovnik = (Pracovnik)prac;
            DatumVypujcky = okamzikVypujcky;
            PujceneNaradi = new List<Naradi>();
        }
        public int PocetKusu()
        {
            return PujceneNaradi?.Count() ?? 0;
        }
    }
}
