﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic
{
    public class Message
    {
        public string Text { get; set; } = string.Empty;

        public bool IsReceived { get; set; } // true if message is received from other process

        public DateTime Timestamp { get; set; }

        public Message() { }

        public Message(string text, bool isReceived = false)
        {
            Text = text;
            IsReceived = isReceived;
            Timestamp = DateTime.Now;
        }
    }
}
