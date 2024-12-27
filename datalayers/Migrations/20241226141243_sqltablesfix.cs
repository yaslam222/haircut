using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace datalayers.Migrations
{
    public partial class sqltablesfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HaircutServices_HaircutServicesCategories_HaircutServicesCategoryId",
                table: "HaircutServices");

            migrationBuilder.DropForeignKey(
                name: "FK_HaircutSupServices_HaircutServices_HaircutServiceId",
                table: "HaircutSupServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HaircutSupServices",
                table: "HaircutSupServices");

            migrationBuilder.DropIndex(
                name: "IX_HaircutSupServices_HaircutServiceId",
                table: "HaircutSupServices");

            migrationBuilder.DropIndex(
                name: "IX_HaircutServices_HaircutServicesCategoryId",
                table: "HaircutServices");

            migrationBuilder.DropColumn(
                name: "HaircutServiceId",
                table: "HaircutSupServices");

            migrationBuilder.DropColumn(
                name: "HaircutServicesCategoryId",
                table: "HaircutServices");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "BeautyServiesItems");

            migrationBuilder.DropColumn(
                name: "NumberText",
                table: "BeautyServiesItems");

            migrationBuilder.RenameTable(
                name: "HaircutSupServices",
                newName: "HairCutSupServices");

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "HaircutMenuItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BeautyServicesItemId",
                table: "BeautysServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HairCutSupServices",
                table: "HairCutSupServices",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HairCutSupServices_ServiceId",
                table: "HairCutSupServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HaircutServices_ServiceCategoryId",
                table: "HaircutServices",
                column: "ServiceCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BeautysServices_BeautyServicesItemId",
                table: "BeautysServices",
                column: "BeautyServicesItemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BeautysServices_BeautyServiesItems_BeautyServicesItemId",
                table: "BeautysServices",
                column: "BeautyServicesItemId",
                principalTable: "BeautyServiesItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HaircutServices_HaircutServicesCategories_ServiceCategoryId",
                table: "HaircutServices",
                column: "ServiceCategoryId",
                principalTable: "HaircutServicesCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HairCutSupServices_HaircutServices_ServiceId",
                table: "HairCutSupServices",
                column: "ServiceId",
                principalTable: "HaircutServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeautysServices_BeautyServiesItems_BeautyServicesItemId",
                table: "BeautysServices");

            migrationBuilder.DropForeignKey(
                name: "FK_HaircutServices_HaircutServicesCategories_ServiceCategoryId",
                table: "HaircutServices");

            migrationBuilder.DropForeignKey(
                name: "FK_HairCutSupServices_HaircutServices_ServiceId",
                table: "HairCutSupServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HairCutSupServices",
                table: "HairCutSupServices");

            migrationBuilder.DropIndex(
                name: "IX_HairCutSupServices_ServiceId",
                table: "HairCutSupServices");

            migrationBuilder.DropIndex(
                name: "IX_HaircutServices_ServiceCategoryId",
                table: "HaircutServices");

            migrationBuilder.DropIndex(
                name: "IX_BeautysServices_BeautyServicesItemId",
                table: "BeautysServices");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "HaircutMenuItems");

            migrationBuilder.DropColumn(
                name: "BeautyServicesItemId",
                table: "BeautysServices");

            migrationBuilder.RenameTable(
                name: "HairCutSupServices",
                newName: "HaircutSupServices");

            migrationBuilder.AddColumn<int>(
                name: "HaircutServiceId",
                table: "HaircutSupServices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HaircutServicesCategoryId",
                table: "HaircutServices",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "BeautyServiesItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NumberText",
                table: "BeautyServiesItems",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HaircutSupServices",
                table: "HaircutSupServices",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_HaircutSupServices_HaircutServiceId",
                table: "HaircutSupServices",
                column: "HaircutServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HaircutServices_HaircutServicesCategoryId",
                table: "HaircutServices",
                column: "HaircutServicesCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_HaircutServices_HaircutServicesCategories_HaircutServicesCategoryId",
                table: "HaircutServices",
                column: "HaircutServicesCategoryId",
                principalTable: "HaircutServicesCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HaircutSupServices_HaircutServices_HaircutServiceId",
                table: "HaircutSupServices",
                column: "HaircutServiceId",
                principalTable: "HaircutServices",
                principalColumn: "Id");
        }
    }
}
