namespace QuizWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateQuizDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quizzes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Question = c.String(),
                        Answer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Quizzes");
        }
    }
}
