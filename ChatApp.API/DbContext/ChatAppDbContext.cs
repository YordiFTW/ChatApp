using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Bussiness.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.API.DbContext
{
    public class ChatAppDbContext : IdentityDbContext<User>
    {
        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(user => user.HasIndex(x => x.UserName).IsUnique(false));

            builder.Entity<Chat>()
            .HasMany(c => c.Comments)
            .WithOne(e => e.Chat);
        }

        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Chat> Chats { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Comment> Comments { get; set; }

        
    }

}
