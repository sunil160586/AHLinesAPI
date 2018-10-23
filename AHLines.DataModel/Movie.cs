using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Movies")]
    public class Movie
    {
        public Movie()
        {

        }

        [Key, Column("MovieId", TypeName = "int")]
        public int MovieId { get; set; }

        [Column("MovieFolder", TypeName = "nvarchar"), MaxLength(50)]
        public string MovieFolder { get; set; }

        [Column("MovieName", TypeName = "nvarchar"), MaxLength(100)]
        public string MovieName { get; set; }

        [Column("MovieTitle", TypeName = "nvarchar"), MaxLength(100)]
        public string MovieTitle { get; set; }

        [Column("ImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ImageUrl { get; set; }

        [Column("OtherImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string OtherImageUrl { get; set; }

        [Column("MovieStatus", TypeName = "nvarchar"), MaxLength(1)]
        public string MovieStatus { get; set; }

        [Column("MovieType", TypeName = "nvarchar"), MaxLength(10)]
        public string MovieType { get; set; }

        [Column("MovieAbstract", TypeName = "text")]
        public string MovieAbstract { get; set; }

        [Column("MovieComments", TypeName = "text")]
        public string MovieComments { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}