using Microsoft.EntityFrameworkCore;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
 
namespace Library.Entity;

public partial class DbModel : DbContext

{

    public DbModel()

    {

    }

    public DbModel(DbContextOptions<DbModel> options)

        : base(options)

    {

    }

    //Tables

    public virtual DbSet<Entity.Author> Authors { get; set; }

    public virtual DbSet<Entity.Book> Books { get; set; }

    public virtual DbSet<Entity.BookAuthor> BookAuthors { get; set; }

    public virtual DbSet<Entity.BookCategory> Categories { get; set; }

    public virtual DbSet<Entity.Member> Members { get; set; }

    public virtual DbSet<Entity.MemberType> MemberTypes { get; set; }

    public virtual DbSet<Entity.Rental> Rentals { get; set; }

    public virtual DbSet<Entity.RentalDetail> RentalDetails { get; set; }

    public virtual DbSet<Entity.User> Users { get; set; }

    public virtual DbSet<Entity.UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=LibrarySystem;User Id=sa; Password=123;Trusted_Connection=False;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)

    {

        modelBuilder.Entity<Entity.Author>(entity =>

        {

            entity.ToTable("Author").HasKey(x => x.AuthorId);

            entity.Property(e => e.AuthorId)
                .HasMaxLength(6)
                .IsFixedLength()
                .IsUnicode(false);
            entity.Property(e => e.AuthorName)
                .HasMaxLength(100);
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false);

        });

        modelBuilder.Entity<Entity.Book>(entity =>

        {

            entity.ToTable("Book").HasKey(x => x.BookId);
            entity.Property(e => e.BookId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100);
            entity.Property(e => e.ISBN)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.Publisher)
                .HasMaxLength(50);
            entity.Property(e => e.YearPublished)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.CatId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.AvailabilityStatus)
                .HasConversion<int>() 
                .IsRequired();

            entity.HasOne(d => d.BookCategory).WithMany(p => p.Books)
                .HasForeignKey(d => d.CatId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Book_BookCategoty");

        });

        modelBuilder.Entity<Entity.BookAuthor>(entity =>

        {

            entity.ToTable("BookAuthor").HasKey(x => new { x.BookId, x.AuthorId });
            entity.Property(e => e.BookId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.AuthorId)
                .HasMaxLength(6)
                .IsUnicode(false);

            // BookAuthor table to Book table
            entity.HasOne(d => d.Book).WithMany(p => p.BookAuthors)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BookAuthor_Book");

            // BookAuthor table to Author table
            entity.HasOne(d => d.Author).WithMany(p => p.BookAuthors)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_BookAuthor_Author");

        });

        modelBuilder.Entity<Entity.BookCategory>(entity =>

        {

            entity.ToTable("BookCategory").HasKey(x =>  x.CatId );
            entity.Property(e => e.CatId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CatName)
                .HasMaxLength(100);

        });

        modelBuilder.Entity<Entity.Member>(entity =>

        {

            entity.ToTable("Member").HasKey(x => x.MemberId);
            entity.Property(e => e.MemberId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(30);
            entity.Property(e => e.EMail)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MemberTypeId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CurrentRentOutCount).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.MemberType).WithMany(p => p.Members)
                .HasForeignKey(d => d.MemberTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Member_MemberType");

        });

        modelBuilder.Entity<Entity.MemberType>(entity =>

        {
            entity.ToTable("MemberType").HasKey(x => x.MemberTypeId);
            entity.Property(e => e.MemberTypeId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DaysAllowed).HasDefaultValueSql("((14))");
            entity.Property(e => e.MaxBookAllowed).HasDefaultValueSql("((3))");

        });

        modelBuilder.Entity<Entity.Rental>(entity =>

        {
            entity.ToTable("Rental").HasKey(x => x.RentalId);
            entity.Property(e => e.RentalId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RentalDate)
                .HasColumnType("datetime2");
            entity.Property(e => e.MemberId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.DateToReturn)
                .HasColumnType("datetime2");
            entity.Property(e => e.UserId)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.Member).WithMany(p => p.Rentals)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_Member");

            entity.HasOne(d => d.User).WithMany(p => p.Rentals)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rental_User");
        });

        modelBuilder.Entity<Entity.RentalDetail>(entity =>

        {

            entity.ToTable("RentalDetail").HasKey(x => new { x.RentalId, x.BookId });
            entity.Property(e => e.RentalId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.BookId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ReturnDate)
                .HasColumnType("datetime2");
            entity.Property(e => e.IsReturned).HasDefaultValue(false);
            entity.Property(e => e.ReturnStatus)
                .HasConversion<int>()
                .IsRequired();

            entity.HasOne(d => d.Rental).WithMany(p => p.RentalDetails)
                .HasForeignKey(d => d.RentalId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RentalDetail_Rental");

            entity.HasOne(d => d.Book).WithMany(p => p.RentalDetails)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentalDetail_Copy");

        });

       

        modelBuilder.Entity<Entity.User>(entity =>

        {

            entity.ToTable("User").HasKey(x => x.UserId);
            entity.Property(e => e.UserId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(100);
            entity.Property(e => e.Password)
                .HasMaxLength(100);
            entity.Property(e => e.UserRoleId)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.UserRole).WithMany(p => p.Users)
                .HasForeignKey(d => d.UserRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_UserRole");

        });

        modelBuilder.Entity<Entity.UserRole>(entity =>

        {

            entity.ToTable("UserRole").HasKey(x => x.UserRoleId);
            entity.Property(e => e.UserRoleId)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.RoleDescription)
                .HasMaxLength(100);

        });

        OnModelCreatingPartial(modelBuilder);

    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
