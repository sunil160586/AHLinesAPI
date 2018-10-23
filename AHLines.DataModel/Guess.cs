using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Guess")]
    public class Guess
    {
        public Guess()
        {

        }

        [Key, Column("GuessId", TypeName = "int")]
        public int GuessId { get; set; }

        [Column("QuizImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string QuizImageUrl { get; set; }

        [Column("AnswerImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string AnswerImageUrl { get; set; }

        [Column("AnswerHint1", TypeName = "nvarchar"), MaxLength(50)]
        public string AnswerHint1 { get; set; }

        [Column("AnswerHint2", TypeName = "nvarchar"), MaxLength(50)]
        public string AnswerHint2 { get; set; }

        [Column("AnswerHint3", TypeName = "nvarchar"), MaxLength(50)]
        public string AnswerHint3 { get; set; }

        [Column("AnswerName", TypeName = "nvarchar"), MaxLength(50)]
        public string AnswerName { get; set; }

        [Column("StartDate", TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        [Column("EndDate", TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}