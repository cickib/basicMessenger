using System;

namespace WebApplication1.Models {
    public class Message {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}