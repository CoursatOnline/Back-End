﻿// <auto-generated />
using System;
using CoursatOnline.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoursatOnline.Migrations
{
    [DbContext(typeof(CoursatOnlineDbContext))]
    partial class CoursatOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoursatOnline.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("CoursatOnline.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("StdId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StdId")
                        .IsUnique();

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("CoursatOnline.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 20, 23, 54, 48, 659, DateTimeKind.Local).AddTicks(2201));

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("CrsId");

                    b.ToTable("CartItem");
                });

            modelBuilder.Entity("CoursatOnline.Models.CategoriesCourses", b =>
                {
                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("Show")
                        .HasColumnType("bit");

                    b.HasKey("CatId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("CategoriesCourses");
                });

            modelBuilder.Entity("CoursatOnline.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Show")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("CoursatOnline.Models.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CrsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 20, 23, 54, 48, 659, DateTimeKind.Local).AddTicks(2873));

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<bool>("Show")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Video")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.HasIndex("InsId");

                    b.ToTable("Chapter");
                });

            modelBuilder.Entity("CoursatOnline.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ChapterId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 20, 23, 54, 48, 659, DateTimeKind.Local).AddTicks(3311));

                    b.Property<bool>("Show")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ChapterId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("CoursatOnline.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsPaid")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<bool?>("Show")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.HasKey("Id");

                    b.HasIndex("InsId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("CoursatOnline.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("cardnumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cvc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("month")
                        .HasColumnType("int");

                    b.Property<int>("value")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("CoursatOnline.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CrsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 7, 20, 23, 54, 48, 659, DateTimeKind.Local).AddTicks(3742));

                    b.Property<string>("Rate_Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Ratio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CrsId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("CoursatOnline.Models.StudentRating", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<int>("_CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "RateId", "_CourseId");

                    b.HasIndex("RateId")
                        .IsUnique();

                    b.HasIndex("_CourseId");

                    b.ToTable("StudentRating");
                });

            modelBuilder.Entity("CoursatOnline.Models.StudentRegisters", b =>
                {
                    b.Property<int>("StdId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("StdId");

                    b.HasIndex("CourseId");

                    b.HasIndex("PaymentId")
                        .IsUnique();

                    b.ToTable("RegisteredStudent");
                });

            modelBuilder.Entity("CoursatOnline.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Show")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasDiscriminator<int>("user_role");

                    b.HasCheckConstraint("CK_Users_Discriminator", "[user_role] IN (0, 1, 2)");

                    b.HasCheckConstraint("CK_Users_user_role_Enum", "[user_role] IN (0, 1, 2)");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CoursatOnline.Models.Admin", b =>
                {
                    b.HasBaseType("CoursatOnline.Models.User");

                    b.HasDiscriminator().HasValue(0);

                    b.HasCheckConstraint("CK_Users_Discriminator", "[user_role] IN (0, 1, 2)");

                    b.HasCheckConstraint("CK_Users_user_role_Enum", "[user_role] IN (0, 1, 2)");
                });

            modelBuilder.Entity("CoursatOnline.Models.Instructor", b =>
                {
                    b.HasBaseType("CoursatOnline.Models.User");

                    b.HasDiscriminator().HasValue(1);

                    b.HasCheckConstraint("CK_Users_Discriminator", "[user_role] IN (0, 1, 2)");

                    b.HasCheckConstraint("CK_Users_user_role_Enum", "[user_role] IN (0, 1, 2)");
                });

            modelBuilder.Entity("CoursatOnline.Models.Student", b =>
                {
                    b.HasBaseType("CoursatOnline.Models.User");

                    b.HasDiscriminator().HasValue(2);

                    b.HasCheckConstraint("CK_Users_Discriminator", "[user_role] IN (0, 1, 2)");

                    b.HasCheckConstraint("CK_Users_user_role_Enum", "[user_role] IN (0, 1, 2)");
                });

            modelBuilder.Entity("CoursatOnline.Models.Cart", b =>
                {
                    b.HasOne("CoursatOnline.Models.Student", "_Student")
                        .WithOne("_Cart")
                        .HasForeignKey("CoursatOnline.Models.Cart", "StdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Student");
                });

            modelBuilder.Entity("CoursatOnline.Models.CartItem", b =>
                {
                    b.HasOne("CoursatOnline.Models.Cart", "_Cart")
                        .WithMany("_CartItems")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_CartItems")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("_Cart");

                    b.Navigation("_Course");
                });

            modelBuilder.Entity("CoursatOnline.Models.CategoriesCourses", b =>
                {
                    b.HasOne("CoursatOnline.Models.Category", "_Category")
                        .WithMany("_CategoriesCourses")
                        .HasForeignKey("CatId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_CategoriesCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("_Category");

                    b.Navigation("_Course");
                });

            modelBuilder.Entity("CoursatOnline.Models.Category", b =>
                {
                    b.HasOne("CoursatOnline.Models.Admin", "_Admin")
                        .WithMany("_Categories")
                        .HasForeignKey("AdminId");

                    b.Navigation("_Admin");
                });

            modelBuilder.Entity("CoursatOnline.Models.Chapter", b =>
                {
                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_Chapters")
                        .HasForeignKey("CrsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Instructor", "_Instructor")
                        .WithMany("_Chapters")
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("_Course");

                    b.Navigation("_Instructor");
                });

            modelBuilder.Entity("CoursatOnline.Models.Comment", b =>
                {
                    b.HasOne("CoursatOnline.Models.Chapter", "_Chapter")
                        .WithMany("_Comments")
                        .HasForeignKey("ChapterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.User", "_User")
                        .WithMany("_Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("_Chapter");

                    b.Navigation("_User");
                });

            modelBuilder.Entity("CoursatOnline.Models.Course", b =>
                {
                    b.HasOne("CoursatOnline.Models.Instructor", "_Instructor")
                        .WithMany("_Courses")
                        .HasForeignKey("InsId");

                    b.Navigation("_Instructor");
                });

            modelBuilder.Entity("CoursatOnline.Models.Rating", b =>
                {
                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_Ratings")
                        .HasForeignKey("CrsId");

                    b.Navigation("_Course");
                });

            modelBuilder.Entity("CoursatOnline.Models.StudentRating", b =>
                {
                    b.HasOne("CoursatOnline.Models.Rating", "_Rate")
                        .WithOne("_StudentRating")
                        .HasForeignKey("CoursatOnline.Models.StudentRating", "RateId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Student", "_Student")
                        .WithMany("_RatedCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_StudentRatings")
                        .HasForeignKey("_CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("_Course");

                    b.Navigation("_Rate");

                    b.Navigation("_Student");
                });

            modelBuilder.Entity("CoursatOnline.Models.StudentRegisters", b =>
                {
                    b.HasOne("CoursatOnline.Models.Course", "_Course")
                        .WithMany("_StudentRegistered")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Payment", "_Payment")
                        .WithOne("_StudentRegistered")
                        .HasForeignKey("CoursatOnline.Models.StudentRegisters", "PaymentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CoursatOnline.Models.Student", "_Student")
                        .WithMany("_RegisteredCourses")
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("_Course");

                    b.Navigation("_Payment");

                    b.Navigation("_Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CoursatOnline.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CoursatOnline.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoursatOnline.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CoursatOnline.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CoursatOnline.Models.Cart", b =>
                {
                    b.Navigation("_CartItems");
                });

            modelBuilder.Entity("CoursatOnline.Models.Category", b =>
                {
                    b.Navigation("_CategoriesCourses");
                });

            modelBuilder.Entity("CoursatOnline.Models.Chapter", b =>
                {
                    b.Navigation("_Comments");
                });

            modelBuilder.Entity("CoursatOnline.Models.Course", b =>
                {
                    b.Navigation("_CartItems");

                    b.Navigation("_CategoriesCourses");

                    b.Navigation("_Chapters");

                    b.Navigation("_Ratings");

                    b.Navigation("_StudentRatings");

                    b.Navigation("_StudentRegistered");
                });

            modelBuilder.Entity("CoursatOnline.Models.Payment", b =>
                {
                    b.Navigation("_StudentRegistered");
                });

            modelBuilder.Entity("CoursatOnline.Models.Rating", b =>
                {
                    b.Navigation("_StudentRating");
                });

            modelBuilder.Entity("CoursatOnline.Models.User", b =>
                {
                    b.Navigation("_Comments");
                });

            modelBuilder.Entity("CoursatOnline.Models.Admin", b =>
                {
                    b.Navigation("_Categories");
                });

            modelBuilder.Entity("CoursatOnline.Models.Instructor", b =>
                {
                    b.Navigation("_Chapters");

                    b.Navigation("_Courses");
                });

            modelBuilder.Entity("CoursatOnline.Models.Student", b =>
                {
                    b.Navigation("_Cart");

                    b.Navigation("_RatedCourses");

                    b.Navigation("_RegisteredCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
