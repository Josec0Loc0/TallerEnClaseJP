using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TallerEnClaseJP.Migrations
{
    /// <inheritdoc />
    public partial class CreaciondeModelos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estadio",
                columns: table => new
                {
                    IdEstadio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CiudadEstadio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estadio", x => x.IdEstadio);
                });

            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEquipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TitulosEquipo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Extranjero = table.Column<bool>(type: "bit", nullable: false),
                    EstadioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo", x => x.IdEquipo);
                    table.ForeignKey(
                        name: "FK_Equipo_Estadio_EstadioId",
                        column: x => x.EstadioId,
                        principalTable: "Estadio",
                        principalColumn: "IdEstadio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jugador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Posición = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Titulos = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EquipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugador_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "IdEquipo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_EstadioId",
                table: "Equipo",
                column: "EstadioId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugador_EquipoId",
                table: "Jugador",
                column: "EquipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugador");

            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "Estadio");
        }
    }
}
