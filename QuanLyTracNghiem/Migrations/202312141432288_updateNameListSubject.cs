namespace QuanLyTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateNameListSubject : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ListSubject", name: "IDSubejct", newName: "IDSubject");
            RenameIndex(table: "dbo.ListSubject", name: "IX_IDSubejct", newName: "IX_IDSubject");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.ListSubject", name: "IX_IDSubject", newName: "IX_IDSubejct");
            RenameColumn(table: "dbo.ListSubject", name: "IDSubject", newName: "IDSubejct");
        }
    }
}
