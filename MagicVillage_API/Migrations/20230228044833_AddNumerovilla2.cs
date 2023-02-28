using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVillage_API.Migrations
{
    /// <inheritdoc />
    public partial class AddNumerovilla2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaAcutalizacion",
                table: "NumeroVillas",
                newName: "FechaActualizacion");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 2, 27, 23, 48, 32, 747, DateTimeKind.Local).AddTicks(7741), new DateTime(2023, 2, 27, 23, 48, 32, 747, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 2, 27, 23, 48, 32, 747, DateTimeKind.Local).AddTicks(7747), new DateTime(2023, 2, 27, 23, 48, 32, 747, DateTimeKind.Local).AddTicks(7746) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaActualizacion",
                table: "NumeroVillas",
                newName: "FechaAcutalizacion");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 2, 27, 23, 42, 28, 330, DateTimeKind.Local).AddTicks(7122), new DateTime(2023, 2, 27, 23, 42, 28, 330, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 2, 27, 23, 42, 28, 330, DateTimeKind.Local).AddTicks(7133), new DateTime(2023, 2, 27, 23, 42, 28, 330, DateTimeKind.Local).AddTicks(7131) });
        }
    }
}
