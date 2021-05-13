using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NotaryAppAPI.Models
{
    public partial class NotaryAppDBContext : DbContext
    {
        public NotaryAppDBContext(DbContextOptions<NotaryAppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
    }
}
