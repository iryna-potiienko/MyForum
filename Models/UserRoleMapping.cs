namespace MyForum.Models
{
    public class UserRoleMapping
    {
        public int Id { get; set; }
        public int UserProfileId { get; set; }
        public int UserRoleId { get; set; }
        
        public virtual UserProfile UserProfile { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}