using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartSchool_WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Document = table.Column<string>(nullable: true),
                    Phonenumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TeacherId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSubjects",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    SubjectId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSubjects", x => new { x.StudentId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "72143DA8-799B-4962-A8AE-EF926FE299C5", new DateTime(2020, 6, 25, 19, 21, 42, 606, DateTimeKind.Local).AddTicks(7613), "455.278.840-00", "clarkkent@yahoo.com", "Clark", "Kent", "11933225555", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "0530841D-AA4A-4469-9F6D-8DD39C75BD51", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6099), "860.187.460-69", "leonskennedy@hotmail.com", "Leon", "Kennedy", "21999880033", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "22E5557C-A61E-476F-A996-09FAB7DFF0AD", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6137), "730.648.440-08", "brucewayne@gmail.com", "Bruce", "Wayne", "47933442121", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "B36F6B51-3F95-4B3E-95C0-19099A78E825", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6145), "704.332.760-10", "stark@yahoo.com", "Tony", "Stark", "1397674944", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6151), "819.391.990-42", "hulk@hotmail.com", "Bruce", "Benner", "45998877664", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6154) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "E8E0015B-1EB1-444C-AF78-C0DCDE508109", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6164), "268.910.380-06", "scooby@yahoo.com", "Scooby", "Doo", "11945492790", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreatedAt", "Document", "Email", "FirstName", "LastName", "Phonenumber", "UpdatedAt" },
                values: new object[] { "B1FE8B94-1773-443A-9E04-52753571F3D3", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6169), "236.780.220-30", "charliebrown@hotmail.com", "Charlie", "Brown", "34977553040", new DateTime(2020, 6, 25, 19, 21, 42, 611, DateTimeKind.Local).AddTicks(6172) });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "1", "Girafales", "Gonzales" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "2", "Pardal", "Voador" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "3", "Raimundo", "Nonato" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "4", "Alexsandro", "Andrade" });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[] { "5", "Gladys", "Moreno" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { "1", "Aritmética", "1" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { "2", "Física", "2" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { "3", "Português", "3" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { "4", "Informática", "4" });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "TeacherId" },
                values: new object[] { "5", "Culinária", "5" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "0530841D-AA4A-4469-9F6D-8DD39C75BD51", "1" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "0530841D-AA4A-4469-9F6D-8DD39C75BD51", "5" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "72143DA8-799B-4962-A8AE-EF926FE299C5", "5" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B1FE8B94-1773-443A-9E04-52753571F3D3", "4" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "E8E0015B-1EB1-444C-AF78-C0DCDE508109", "4" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", "4" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B36F6B51-3F95-4B3E-95C0-19099A78E825", "4" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "72143DA8-799B-4962-A8AE-EF926FE299C5", "4" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B1FE8B94-1773-443A-9E04-52753571F3D3", "3" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B36F6B51-3F95-4B3E-95C0-19099A78E825", "5" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "E8E0015B-1EB1-444C-AF78-C0DCDE508109", "3" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "E8E0015B-1EB1-444C-AF78-C0DCDE508109", "2" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "22E5557C-A61E-476F-A996-09FAB7DFF0AD", "2" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "0530841D-AA4A-4469-9F6D-8DD39C75BD51", "2" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "72143DA8-799B-4962-A8AE-EF926FE299C5", "2" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B1FE8B94-1773-443A-9E04-52753571F3D3", "1" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", "1" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B36F6B51-3F95-4B3E-95C0-19099A78E825", "1" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "22E5557C-A61E-476F-A996-09FAB7DFF0AD", "1" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "22E5557C-A61E-476F-A996-09FAB7DFF0AD", "3" });

            migrationBuilder.InsertData(
                table: "StudentsSubjects",
                columns: new[] { "StudentId", "SubjectId" },
                values: new object[] { "B76B460B-3F15-4D71-9B31-1C0EFA20D0DE", "5" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSubjects_SubjectId",
                table: "StudentsSubjects",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_TeacherId",
                table: "Subjects",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsSubjects");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
