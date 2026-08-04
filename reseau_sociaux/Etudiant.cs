using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public class Etudiant
    {
        public int id { get; set; }
        public string fullName { get; set;}
        public string email { get; set;}
        public byte[] profileImage { get; set; }
        public string bio { get; set; }
        public string password { get; set; }
    }
}
