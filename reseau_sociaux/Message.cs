using System;

namespace reseau_sociaux
{
    public class Message
    {
        public int MessageId { get; set; }
        public int SentToId { get; set; }
        public int SentFromId { get; set; }
        public string Content { get; set; } = string.Empty;
        public byte[]? Media { get; set; }
        public DateTime TimeSent { get; set; }
    }
}
