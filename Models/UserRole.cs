using System.Collections.Generic;

namespace MyForum.Models
{
    public class UserRole
    {
        public UserRole()
        {
            UserRoleMappings = new List<UserRoleMapping>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<UserRoleMapping> UserRoleMappings { get; set; }
    }
}