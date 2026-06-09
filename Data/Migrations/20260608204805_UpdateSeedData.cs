using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutMes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Email", "FullName", "LinkedInUrl", "Title" },
                values: new object[] { "Zhvilluese Front-End e motivuar me 1+ vit trajnim dhe ekspertizë të certifikuar në HTML5, CSS3, JavaScript, React.js dhe Next.js. Kam përfunduar programin 12-mujor Brainster me rezultat 92% dhe 180 kredite. Aktualisht ndjek BSc në Teknologji Informacioni dhe Komunikimi në Universitetin e Tiranës.", "fatjetanerguti8@gmail.com", "Fatjeta Nerguti", "", "Front-End Developer & ICT Student" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Sistem librarie online që lejon përdoruesit të shfletojnë, lexojnë dhe menaxhojnë libra dhe e-books dixhitale. Ndërtuar me ASP.NET Core MVC dhe SQL Server.", "C#, ASP.NET Core, SQL Server" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ShortDescription", "TechStack" },
                values: new object[] { "Projekt web i ndërtuar me TypeScript duke aplikuar arkitekturë të strukturuar dhe parimet e programimit modern.", "Projekt i avancuar me TypeScript", "TypeScript, JavaScript" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "LiveUrl", "ShortDescription", "TechStack" },
                values: new object[] { "Faqe web responsive dhe elegante për prezantimin e një kafeneje. Dizajnuar me CSS të avancuar dhe HTML5 semantik.", null, "Faqe web elegante për kafene", "HTML5, CSS3, JavaScript" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Projekt web i realizuar gjatë periudhës së internshipit, duke demonstruar aftësi praktike në zhvillim frontend me HTML dhe CSS.", "HTML5, CSS3" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Projekt i vogël dhe minimalist për prezantimin e një kafeneje, me dizajn të pastër dhe modern duke përdorur HTML dhe CSS.", "HTML5, CSS3" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Frontend", 92, "HTML5 & CSS3" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Frontend", 80, "JavaScript" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Frontend", 85, "React.js" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Level", "Name" },
                values: new object[] { 78, "Next.js" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Level", "Name" },
                values: new object[] { 70, "TypeScript" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Level", "Name" },
                values: new object[] { 85, "Bootstrap" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Category", "DisplayOrder", "IconClass", "Level", "Name" },
                values: new object[,]
                {
                    { 7, "Design", 7, null, 80, "Figma / UX·UI" },
                    { 8, "Design", 8, null, 90, "Responsive Design" },
                    { 9, "Backend", 9, null, 72, "C# / ASP.NET Core" },
                    { 10, "Database", 10, null, 70, "MySQL / SQL Server" },
                    { 11, "Tools", 11, null, 82, "Git & GitHub" },
                    { 12, "Tools", 12, null, 55, "Docker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "AboutMes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "Email", "FullName", "LinkedInUrl", "Title" },
                values: new object[] { "Zhvilluese web me pasion për teknologjinë dhe krijimin e aplikacioneve moderne. E specializuar në ASP.NET Core dhe zhvillim frontend.", "", "Fatjeta Neguti", null, "Junior Web Developer" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Një sistem librarie online që lejon përdoruesit të shfletojnë, lexojnë dhe menaxhojnë libra dhe e-books dixhitale.", "C#, ASP.NET, SQL Server" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ShortDescription", "TechStack" },
                values: new object[] { "Projekt i zhvilluar me TypeScript.", "Projekt me TypeScript", "TypeScript" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "LiveUrl", "ShortDescription", "TechStack" },
                values: new object[] { "Një faqe web e thjeshtë dhe elegante për prezantimin e një kafeneje.", "https://github.com/fatjetanerguti/coffee-website", "Faqe web për kafene", "HTML, CSS, JavaScript" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Projekt i shkurtër i zhvilluar gjatë periudhës së internshipit, duke demonstruar aftësitë e zhvillimit web.", "HTML, CSS" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "TechStack" },
                values: new object[] { "Një projekt i vogël dhe minimalist për prezantimin e një kafeneje, me dizajn të pastër dhe modern.", "HTML, CSS" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Backend", 80, "C#" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Backend", 75, "ASP.NET Core" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Level", "Name" },
                values: new object[] { "Database", 70, "SQL Server" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Level", "Name" },
                values: new object[] { 65, "TypeScript" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Level", "Name" },
                values: new object[] { 85, "HTML & CSS" });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Level", "Name" },
                values: new object[] { 70, "JavaScript" });
        }
    }
}
