using System;
using System.ComponentModel.DataAnnotations;

namespace MyForum.Models
{
    public class Message
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Cannot be empty")]
        [Display(Name = "Text of your message")]
        public string MessageText { get; set; }
        public DateTime TimeSent { get; set; }
        
        public int UserId { get; set; }
        public int SubjectId { get; set; }
        
        public virtual UserProfile UserProfile { get; set; }
        public virtual Subject Subject { get; set; }
    }
}