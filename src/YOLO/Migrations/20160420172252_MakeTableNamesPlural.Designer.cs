using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using YOLO.Models;

namespace YOLO.Migrations
{
    [DbContext(typeof(YOLODbContext))]
    [Migration("20160420172252_MakeTableNamesPlural")]
    partial class MakeTableNamesPlural
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YOLO.Models.Experience", b =>
                {
                    b.Property<int>("ExperinceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("ExperinceId");

                    b.HasAnnotation("Relational:TableName", "Experiences");
                });

            modelBuilder.Entity("YOLO.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Images");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.HasAnnotation("Relational:TableName", "Locations");
                });

            modelBuilder.Entity("YOLO.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.HasAnnotation("Relational:TableName", "Persons");
                });

            modelBuilder.Entity("YOLO.Models.Experience", b =>
                {
                    b.HasOne("YOLO.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("YOLO.Models.Person", b =>
                {
                    b.HasOne("YOLO.Models.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId");
                });
        }
    }
}
