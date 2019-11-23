using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizWebApp.Models.Entities
{
    public class Quiz
    {
        /// <summary>
        /// クイズID
        /// </summary>
        public string Id { get; set; } = "";

        /// <summary>
        /// 問題文
        /// </summary>
        public string Question { get; set; } = "";

        /// <summary>
        /// 答え
        /// </summary>
        public string Answer { get; set; } = "";
    }
}