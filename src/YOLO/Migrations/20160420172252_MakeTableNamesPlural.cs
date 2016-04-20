using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace YOLO.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experience");
            migrationBuilder.DropForeignKey(name: "FK_Person_Experience_ExperienceId", table: "Person");
            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Locations",
                nullable: true);
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Experiences",
                nullable: true);
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.AddForeignKey(
                name: "FK_Person_Experience_ExperienceId",
                table: "Persons",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperinceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experiences");
            migrationBuilder.DropForeignKey(name: "FK_Person_Experience_ExperienceId", table: "Persons");
            migrationBuilder.DropColumn(name: "Images", table: "Locations");
            migrationBuilder.DropColumn(name: "Image", table: "Experiences");
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Location_LocationId",
                table: "Experience",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.AddForeignKey(
                name: "FK_Person_Experience_ExperienceId",
                table: "Person",
                column: "ExperienceId",
                principalTable: "Experience",
                principalColumn: "ExperinceId",
                onDelete: ReferentialAction.Restrict);
            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");
            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");
            migrationBuilder.RenameTable(
                name: "Experiences",
                newName: "Experience");
        }
    }
}
