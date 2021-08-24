using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetworkSite.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
        name: "ColourTheme",
        table: "Users",
        nullable: true);
        }

        
    }
}
