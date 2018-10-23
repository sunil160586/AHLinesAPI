using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Videos_Type")]
    public class VideoType
    {
        public VideoType()
        {

        }

        [Key, Column("TypeId", TypeName = "int")]
        public int TypeId { get; set; }

        [Column("TypeName", TypeName = "nvarchar"), MaxLength(50)]
        public string TypeName { get; set; }
    }
}