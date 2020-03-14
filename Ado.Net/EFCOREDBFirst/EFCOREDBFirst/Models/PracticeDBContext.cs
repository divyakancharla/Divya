using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCOREDBFirst.Models
{
    public partial class PracticeDBContext : DbContext
    {
        public PracticeDBContext()
        {
        }

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Testt> Testt { get; set; }
        public virtual DbSet<WorksOn> WorksOn { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-A63MUHA\\SQLEXPRESS;Initial Catalog=PracticeDB;User ID=sa;Password=pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cours>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__Cours__C1FFD8616871151F");

                entity.Property(e => e.Cid).ValueGeneratedNever();

                entity.Property(e => e.Cname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Address)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasColumnName("contactName")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Customerid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Town)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Dno)
                    .HasName("PK__departme__C030857AF64257F5");

                entity.ToTable("department");

                entity.Property(e => e.Dno)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasColumnName("location")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("employee");

                entity.Property(e => e.Dno)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Efname)
                    .HasColumnName("efname")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Elname)
                    .HasColumnName("elname")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerId")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Freight).HasColumnType("money");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Shipaddres)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Shipname)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Shippeddate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Projectno)
                    .HasName("PK__Project__7611D517E35C5C6F");

                entity.Property(e => e.Projectno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Projectname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__test__DD37D91A9EBE789F");

                entity.ToTable("test");

                entity.HasIndex(e => e.Pname)
                    .HasName("UQ__test__1FC9734C9DDDABD3")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Testt>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__testt__DD37D91A1113AEDC");

                entity.ToTable("testt");

                entity.HasIndex(e => e.Pname)
                    .HasName("UQ__testt__1FC9734C880CBE98")
                    .IsUnique();

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("edate")
                    .HasColumnType("date");

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Sdate)
                    .HasColumnName("sdate")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WorksOn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("works_on");

                entity.Property(e => e.EDate)
                    .HasColumnName("e_date")
                    .HasColumnType("date");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pno)
                    .IsRequired()
                    .HasColumnName("pno")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
