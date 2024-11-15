using DomainModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class UserContext : DbContext
    {
        public UserContext()
            : base("name=Users")
        {
        }

        public virtual DbSet<call> call { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<tariff> tariff { get; set; }
        public virtual DbSet<type_of_call> type_of_call { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.FIO)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone_Number)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.TypeOfUser)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<tariff>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<tariff>()
                .Property(e => e.TypeOfTariff)
                .IsUnicode(false);

            modelBuilder.Entity<type_of_call>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
