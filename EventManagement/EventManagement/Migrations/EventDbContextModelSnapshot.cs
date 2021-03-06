// <auto-generated />
using EventManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventManagement.Migrations
{
    [DbContext(typeof(EventDbContext))]
    partial class EventDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EventManagement.Models.Venue", b =>
                {
                    b.Property<string>("Event_Place")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Event_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Guest_Capability")
                        .HasColumnType("int");

                    b.Property<int>("Per_Guest_Cost")
                        .HasColumnType("int");

                    b.HasKey("Event_Place");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("EventManagement.Models.VenueAllDetails", b =>
                {
                    b.Property<string>("Event_Place")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DJ_Cost")
                        .HasColumnType("int");

                    b.Property<string>("Event_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Guest_Capability")
                        .HasColumnType("int");

                    b.Property<int>("Mike_Speaker_Cost")
                        .HasColumnType("int");

                    b.Property<int>("Per_Guest_Cost")
                        .HasColumnType("int");

                    b.Property<int>("Stage_Cost")
                        .HasColumnType("int");

                    b.HasKey("Event_Place");

                    b.ToTable("VenueAllDetails");
                });

            modelBuilder.Entity("EventManagement.Models.VenueDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DJ_Cost")
                        .HasColumnType("int");

                    b.Property<string>("Event_Place")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Mike_Speaker_Cost")
                        .HasColumnType("int");

                    b.Property<int>("Stage_Cost")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Event_Place");

                    b.ToTable("VenueDetail");
                });

            modelBuilder.Entity("EventManagement.Models.VenueDetails", b =>
                {
                    b.HasOne("EventManagement.Models.Venue", "venue")
                        .WithMany()
                        .HasForeignKey("Event_Place");
                });
#pragma warning restore 612, 618
        }
    }
}
