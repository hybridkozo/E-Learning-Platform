using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using e_coding.gr.Models;

namespace e_coding.gr.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }




    }

    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionStr { get; set; }
        public int Level { get; set; }
        public string SourceUrl { get; set; }
        public string Section { get; set; }

        public List<Answer> Answers { get; set; }


    }

    public class  Answer
    {
        public int AnswerID { get; set; }
        public string AnswerStr { get; set; }
        public bool CorrectAnswer { get; set; }

        public int QuestionID { get; set; }
        public Question Question { get; set; }

    }
}
