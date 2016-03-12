using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using WebApp.Models;

namespace WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20160211134413_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasAnnotation("Relational:Name", "RoleNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasAnnotation("Relational:TableName", "AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasAnnotation("Relational:TableName", "AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasAnnotation("Relational:TableName", "AspNetUserRoles");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Blacklist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdd");

                    b.Property<string>("Description");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apartment");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CityId");

                    b.Property<string>("Comment");

                    b.Property<string>("Currency");

                    b.Property<int>("DistrictId");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("FirstName");

                    b.Property<string>("House");

                    b.Property<string>("Housing");

                    b.Property<DateTime>("InDate");

                    b.Property<string>("LastName");

                    b.Property<string>("MidleName");

                    b.Property<int>("PartherShip");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("Phone3");

                    b.Property<DateTime>("RevisionDate");

                    b.Property<int>("StreetId");

                    b.Property<double>("Sum");

                    b.Property<int?>("TypesHousingId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CityId");

                    b.Property<int>("ContractSum");

                    b.Property<DateTime>("DateClosed");

                    b.Property<DateTime>("DateContract");

                    b.Property<DateTime>("DateIn");

                    b.Property<DateTime>("DateMeeting");

                    b.Property<string>("FirstName");

                    b.Property<int?>("Gender");

                    b.Property<bool>("IsSite");

                    b.Property<string>("LastName");

                    b.Property<int>("MaxSum");

                    b.Property<string>("MidleName");

                    b.Property<int>("MinSum");

                    b.Property<string>("PhoneNumber1");

                    b.Property<string>("PhoneNumber2");

                    b.Property<string>("PhoneNumber3");

                    b.Property<int>("ReheshSum");

                    b.Property<string>("Resource");

                    b.Property<int>("Status");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CityId");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.DistrictToСlient", b =>
                {
                    b.Property<int>("ClientId");

                    b.Property<int>("DistrictId");

                    b.HasKey("ClientId", "DistrictId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DistrictId");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.TypesHousing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("WebApp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasAnnotation("Relational:Name", "EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .HasAnnotation("Relational:Name", "UserNameIndex");

                    b.HasAnnotation("Relational:TableName", "AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNet.Identity.EntityFramework.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("WebApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Building", b =>
                {
                    b.HasOne("WebApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("RealEstateCrm.Entities.City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("RealEstateCrm.Entities.District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("RealEstateCrm.Entities.Street")
                        .WithMany()
                        .HasForeignKey("StreetId");

                    b.HasOne("RealEstateCrm.Entities.TypesHousing")
                        .WithMany()
                        .HasForeignKey("TypesHousingId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Client", b =>
                {
                    b.HasOne("WebApp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("RealEstateCrm.Entities.City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.District", b =>
                {
                    b.HasOne("RealEstateCrm.Entities.City")
                        .WithMany()
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.DistrictToСlient", b =>
                {
                    b.HasOne("RealEstateCrm.Entities.Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("RealEstateCrm.Entities.District")
                        .WithMany()
                        .HasForeignKey("DistrictId");
                });

            modelBuilder.Entity("RealEstateCrm.Entities.Street", b =>
                {
                    b.HasOne("RealEstateCrm.Entities.District")
                        .WithMany()
                        .HasForeignKey("DistrictId");
                });
        }
    }
}
