using System.Collections.Generic;

namespace MyForum.Models
{
    public class Chapter
    {
        public Chapter()
        {
            Subjects = new List<Subject>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}