using DemoCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Data
{
    public class TeacherContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbContextOptions<TeacherContext> Options { get; }

        public TeacherContext(DbContextOptions<TeacherContext> options) : base(options)
        {
            Options = options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

                entity.Property(e => e.Skills)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

                entity.Property(e => e.Salary)
                .IsRequired()
                .HasColumnType("money");

                entity.Property(e => e.AddedOn)
                .HasColumnType("date")
                .HasDefaultValueSql("{getdate()}");
            });
        }
    }
}