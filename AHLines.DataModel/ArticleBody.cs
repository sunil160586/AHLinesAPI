using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Articles_Body")]
    public class ArticleBody
    {
        public ArticleBody()
        {

        }

        [Key, Column("ArticleId", TypeName = "int")]
        public int ArticleId { get; set; }

        [Column("Body", TypeName = "text")]
        public string Body { get; set; }
    }
}