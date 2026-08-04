using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace reseau_sociaux
{
    public  class Publication
    {
        public int PublicationId { get; set; }
        public int EtudiantId { get; set; }
        public string AuthorFullName { get; set; } = "";
        public byte[]? AuthorProfileImage { get; set; }
        public byte[]? ImageData { get; set; }
        public string Legende { get; set; } = "";
        public DateTime TimePublished { get; set; }

       
    }
}
