using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public class Comment
    {
        public int CommentaireId { get; set; }
        public int EtudiantId { get; set; }
        public int PublicationId { get; set; }
        public string? Content { get; set; }
        public byte[]? ImageCommenter { get; set; }
        public DateTime TimePublished { get; set; }

    }
}
