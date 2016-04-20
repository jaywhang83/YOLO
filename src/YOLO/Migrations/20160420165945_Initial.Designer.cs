using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using YOLO.Models;

namespace YOLO.Migrations
{
    [DbContext(typeof(YOLODbContext))]
    [Migration("20160420165945_Initial")]
    partial class Initial
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

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("ExperinceId");
                });

            modelBuilder.Entity("YOLO.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("LocationId");
                });

            modelBuilder.Entity("YOLO.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");
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
