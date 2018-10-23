using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Jokes")]
    public class JokesTable
    {
        public JokesTable()
        {
            JokeStatus = false;
        }

        [Key, Column("JokeId", TypeName = "int")]
        public int JokeId { get; set; }

        [Column("JokeCaption", TypeName = "nvarchar"), MaxLength(150)]
        public string JokeCaption { get; set; }

        [Column("JokeCategory", TypeName = "nvarchar"), MaxLength(10)]
        public string JokeCategory { get; set; }

        [Column("JokeStatus", TypeName = "bit"), DefaultValue(false), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? JokeStatus { get; set; }

        [Column("JokeAbstract", TypeName = "nvarchar"), MaxLength(1000)]
        public string JokeAbstract { get; set; }

        [Column("JokeDesc", TypeName = "text")]
        public string JokeDescription { get; set; }

        [Column("JokeAuthor", TypeName = "nvarchar"), MaxLength(50)]
        public string JokeAuthor { get; set; }

        [Column("AuthorEmail", TypeName = "nvarchar"), MaxLength(100)]
        public string AuthorEmail { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }
    }
}