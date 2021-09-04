using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyForum.Models
{
    public class Subject
    {
        public Subject()
        {
            Messages = new List<Message>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Text of your question")]
        public string QuestionText { get; set; }
        public DateTime TimeSent { get; set; }
        
        public int ChapterId { get; set; }
        public int UserId { get; set; }
        
        public virtual Chapter Chapter { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}