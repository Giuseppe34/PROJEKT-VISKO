using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    class Historie
    {
        private List<Rezervace> m_Rezervace;
        public List <Rezervace> ListRezervace
        {
            get => m_Rezervace;
            set => m_Rezervace = value;
        }
        public Historie()
        {
            ListRezervace = new List<Rezervace>();
        }
    }
}
