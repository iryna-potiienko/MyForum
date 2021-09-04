using System;
using Microsoft.EntityFrameworkCore;

namespace MyForum.Models
{
    public class MyForumContext: DbContext
    {
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserRoleMapping> UserRoleMappings { get; set; }

        public MyForumContext(DbContextOptions<MyForumContext> options)
            :base(options)
        {
            bool i = Database.EnsureCreated();
        }
    }
}