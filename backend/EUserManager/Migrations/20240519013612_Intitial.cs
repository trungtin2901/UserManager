using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EUserManager.Migrations
{
    /// <inheritdoc />
    public partial class Intitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "Password", "UpdateDate", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2603), "user1@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2615), "User1" },
                    { 2, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2619), "user2@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2620), "User2" },
                    { 3, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2622), "user3@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2623), "User3" },
                    { 4, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2626), "user4@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2626), "User4" },
                    { 5, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2628), "user5@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2629), "User5" },
                    { 6, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2631), "user6@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2631), "User6" },
                    { 7, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2633), "user7@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2634), "User7" },
                    { 8, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2636), "user8@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2637), "User8" },
                    { 9, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2639), "user9@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2639), "User9" },
                    { 10, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2643), "user10@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2644), "User10" },
                    { 11, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2646), "user11@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2647), "User11" },
                    { 12, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2649), "user12@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2649), "User12" },
                    { 13, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2651), "user13@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2652), "User13" },
                    { 14, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2654), "user14@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2655), "User14" },
                    { 15, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2657), "user15@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2658), "User15" },
                    { 16, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2698), "user16@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2698), "User16" },
                    { 17, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2701), "user17@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2701), "User17" },
                    { 18, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2703), "user18@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2704), "User18" },
                    { 19, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2706), "user19@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2707), "User19" },
                    { 20, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2709), "user20@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2709), "User20" },
                    { 21, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2712), "user21@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2712), "User21" },
                    { 22, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2714), "user22@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2715), "User22" },
                    { 23, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2717), "user23@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2718), "User23" },
                    { 24, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2720), "user24@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2720), "User24" },
                    { 25, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2722), "user25@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2723), "User25" },
                    { 26, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2725), "user26@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2726), "User26" },
                    { 27, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2728), "user27@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2728), "User27" },
                    { 28, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2730), "user28@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2731), "User28" },
                    { 29, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2733), "user29@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2734), "User29" },
                    { 30, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2736), "user30@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2736), "User30" },
                    { 31, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2739), "user31@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2739), "User31" },
                    { 32, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2741), "user32@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2742), "User32" },
                    { 33, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2744), "user33@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2744), "User33" },
                    { 34, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2747), "user34@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2747), "User34" },
                    { 35, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2749), "user35@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2750), "User35" },
                    { 36, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2752), "user36@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2752), "User36" },
                    { 37, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2755), "user37@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2755), "User37" },
                    { 38, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2757), "user38@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2758), "User38" },
                    { 39, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2760), "user39@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2761), "User39" },
                    { 40, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2763), "user40@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2763), "User40" },
                    { 41, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2765), "user41@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2766), "User41" },
                    { 42, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2768), "user42@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2769), "User42" },
                    { 43, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2771), "user43@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2771), "User43" },
                    { 44, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2773), "user44@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2774), "User44" },
                    { 45, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2776), "user45@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2777), "User45" },
                    { 46, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2779), "user46@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2779), "User46" },
                    { 47, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2781), "user47@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2782), "User47" },
                    { 48, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2784), "user48@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2785), "User48" },
                    { 49, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2787), "user49@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2787), "User49" },
                    { 50, new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2790), "user50@example.com", "123456", new DateTime(2024, 5, 19, 8, 36, 10, 681, DateTimeKind.Local).AddTicks(2790), "User50" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
