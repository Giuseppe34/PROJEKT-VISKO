using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    class Osoba
    {
        private string m_Jmeno;
        private string m_Prijemni;
        private string m_Adresa;
        private string m_Email;
        private string m_Telefon;

        public string Jmeno
        {
            get => m_Jmeno;
            set => m_Jmeno = value;
        }
        public string Prijemni
        {
            get => m_Prijemni;
            set => m_Prijemni = value;
        }
        public string Adresa
        {
            get => m_Adresa;
            set => m_Adresa = value;
        }
        public string Email
        {
            get => m_Email;
            set => m_Email = value;
        }
        public string Telefon
        {
            get => m_Telefon;
            set => m_Telefon = value;
        }
    }
}
