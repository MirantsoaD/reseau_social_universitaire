using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public class Groupe
    {
        public int GroupeId { get; set; }
        public string Nom { get; set; } = "";
        public string Description { get; set; } = "";
        public int CreateurId { get; set; }
        public string CreateurNom { get; set; } = "";
        public DateTime DateCreation { get; set; }
        public int MembreCount { get; set; }
        public string? RoleMoi { get; set; }   // role of current user in this group, null if not a member
    }
}
