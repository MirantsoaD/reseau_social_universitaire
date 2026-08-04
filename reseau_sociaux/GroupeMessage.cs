using System;
using System.Collections.Generic;
using System.Text;

namespace reseau_sociaux
{
    public class GroupeMessage
    {
        public int MessageId { get; set; }
        public int GroupeId { get; set; }
        public int EtudiantId { get; set; }
        public string FullName { get; set; } = "";   // sender's name (from JOIN)
        public string Content { get; set; } = "";
        public DateTime TimeSent { get; set; }
    }
}
