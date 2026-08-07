using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public class GroupeMembre
    {
        public int GroupeId { get; set; }
        public int EtudiantId { get; set; }
        public string FullName { get; set; } = "";
        public byte[]? ProfileImage { get; set; }
        public string Role { get; set; } = "Membre";
        public DateTime DateAjout { get; set; }
    }
}
