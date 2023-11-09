﻿using MailKit.Net.Smtp;
using MimeKit;

namespace MinimalAPI.Models
{
    public class Message
    {
        public List<MailboxAddress> To { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public byte[] Attachments { get; set; }
        //public IFormFileCollection Attachments { get; set; }
        public Message(IEnumerable<string> to, string subject, string content, /*IFormFileCollection attachments*/ byte[] attachments)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress("Test",x)));
            Subject = subject;
            Content = content;
            Attachments = attachments;
        }
    }
}
