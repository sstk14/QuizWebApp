using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//1. EntityFrameworkをusingに追加
using System.Data.Entity;

namespace QuizWebApp.Models
{
    //2. DbContext を継承
    public class QuizDbContext : DbContext
    {
        //3. Entityのプロパティを作成
        //     プロパティ名はEntity名の複数名を使用
        public DbSet<Entities.Quiz> Quizzes { get; set; }

    }
}