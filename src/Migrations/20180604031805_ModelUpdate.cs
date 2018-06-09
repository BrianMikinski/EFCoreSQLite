using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreSQLite.Migrations
{
    public partial class ModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Garages_LocationId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Cars",
                newName: "GarageId2");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_LocationId",
                table: "Cars",
                newName: "IX_Cars_GarageId2");

            migrationBuilder.AddColumn<Guid>(
                name: "GarageId1",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_GarageId1",
                table: "Cars",
                column: "GarageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Garages_GarageId1",
                table: "Cars",
                column: "GarageId1",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Garages_GarageId2",
                table: "Cars",
                column: "GarageId2",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Garages_GarageId1",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Garages_GarageId2",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_GarageId1",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "GarageId1",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "GarageId2",
                table: "Cars",
                newName: "LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_GarageId2",
                table: "Cars",
                newName: "IX_Cars_LocationId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Garages_LocationId",
                table: "Cars",
                column: "LocationId",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
