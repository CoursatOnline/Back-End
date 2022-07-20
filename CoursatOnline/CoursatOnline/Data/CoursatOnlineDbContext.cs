using Microsoft.EntityFrameworkCore;
using CoursatOnline.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoursatOnline.Data
{
    public class CoursatOnlineDbContext: IdentityDbContext<ApplicationUser>
    {
        public CoursatOnlineDbContext() : base()
        { }
        public CoursatOnlineDbContext(DbContextOptions options) : base(options) 
        { }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public  DbSet<Student> Student { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<CategoriesCourses> CategoriesCourses { get; set; }
        public DbSet<Chapter> Chapter { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
        public DbSet<StudentRating> StudentRating { get; set; }
        public DbSet<StudentRegisters> RegisteredStudent { get; set; }

        
           
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                        .ToTable("Users")
                        .HasDiscriminator<Roles>("user_role")
                        .HasValue<Admin>(Data.Roles.Admin)
                        .HasValue<Instructor>(Data.Roles.Instructor)
                        .HasValue<Student>(Data.Roles.Student);
            //modelBuilder.Entity<User>()
            //            .HasIndex(u => u.Email)
            //            .IsUnique();
            //modelBuilder.Entity<User>()
            //            .HasIndex(u => u.User_Name)
            //            .IsUnique();
            modelBuilder.Entity<User>()
                        .Property(u => u.Show)
                        .HasDefaultValue(true);
            modelBuilder.Entity<CategoriesCourses>()
                        .HasKey(CC => new { CC.CatId, CC.CourseId });
            modelBuilder.Entity<CategoriesCourses>()
                        .HasOne(CatCourses => CatCourses._Course)
                        .WithMany(Course => Course._CategoriesCourses)
                        .HasForeignKey(CatCourses => CatCourses.CourseId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<CategoriesCourses>()
                        .HasOne(CatCourses => CatCourses._Category)
                        .WithMany(Category => Category._CategoriesCourses)
                        .HasForeignKey(CatCourses => CatCourses.CatId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            
            modelBuilder.Entity<StudentRating>()
                        .HasKey(SR => new { SR.StudentId, SR.RateId });
            modelBuilder.Entity<StudentRating>()
                        .HasOne<Student>(SR => SR._Student)
                        .WithMany(Student => Student._RatedCourses)
                        .HasForeignKey(SR => SR.StudentId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Rating>()
                        .HasOne(Rating => Rating._StudentRating)
                        .WithOne(StudentRates => StudentRates._Rate)
                        .HasForeignKey<StudentRating>(StdRate => StdRate.RateId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<StudentRegisters>()
                        .HasKey(SRE => new { SRE.StdId, SRE.PaymentId });
            modelBuilder.Entity<StudentRegisters>()
                        .HasOne<Student>(SR => SR._Student)
                        .WithMany(Student => Student._RegisteredCourses)
                        .HasForeignKey(SR => SR.StdId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Payment>()
                        .HasOne(Payment => Payment._StudentRegistered)
                        .WithOne(StudentRegisters => StudentRegisters._Payment)
                        .HasForeignKey<StudentRegisters>(SR => SR.PaymentId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);

            modelBuilder.Entity<CartItem>()
            .HasKey(CI => CI.Id);
            modelBuilder.Entity<CartItem>()
            .HasOne(CI => CI._Cart)
            .WithMany(C => C._CartItems)
            .HasForeignKey(CI => CI.CartId)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);

            //.HasRequired(c => c._Cart)
            //.WithMany()
            //.WillCascadeOnDelete(false);
            //modelBuilder.Entity<CartItem>()
            //            .HasOne<Student>(CI => CI._Student)
            //            .WithMany(S => S._Items)
            //            .HasForeignKey(CI => CI.StdId)
            //            .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<CartItem>()
                        .HasOne(CI => CI._Course)
                        .WithMany(Co => Co._CartItems)
                        .HasForeignKey(CI => CI.CrsId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Chapter>()
                        .HasKey(Chapter => Chapter.Id);
            modelBuilder.Entity<Chapter>()
                        .HasOne(Chapter => Chapter._Course)
                        .WithMany(Course => Course._Chapters)
                        .HasForeignKey(Chapter => Chapter.CrsId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Chapter>()
                        .HasOne(Chapter => Chapter._Instructor)
                        .WithMany(Instructor => Instructor._Chapters)
                        .HasForeignKey(Chapter => Chapter.InsId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Comment>()
                        .HasOne(Comment => Comment._User)
                        .WithMany(User => User._Comments)
                        .HasForeignKey(Comment => Comment.UserId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Comment>()
                        .HasOne(Comment => Comment._Chapter)
                        .WithMany(Chapter => Chapter._Comments)
                        .HasForeignKey(Comment => Comment.ChapterId)
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired(false);
            modelBuilder.Entity<Category>()
                .Property(category => category.Show)
                .HasDefaultValue(true);
            modelBuilder.Entity<Chapter>()
                .Property(chapter => chapter.Show)
                .HasDefaultValue(true);
            modelBuilder.Entity<Comment>()
                .Property(comment => comment.Show)
                .HasDefaultValue(true);
            modelBuilder.Entity<Course>()
                .Property(course => course.Show)
                .HasDefaultValue(true);
            modelBuilder.Entity<User>()
                .Property(u => u.Show)
                .HasDefaultValue(true);
            modelBuilder.Entity<CartItem>()
               .Property(CI => CI.DateAdded)
               .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Chapter>()
              .Property(chapter => chapter.DateAdded)
              .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Comment>()
             .Property(comment => comment.DateAdded)
             .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Rating>()
             .Property(rating => rating.Date)
             .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<Course>()
            .Property(course => course.IsPaid)
            .HasDefaultValue(false);
        }
    }
}
