using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Videos_Format")]
    public class VideoFormat
    {
        public VideoFormat()
        {

        }

        [Key, Column("FormatId", TypeName = "int")]
        public int FormatId { get; set; }

        [Column("FormatType", TypeName = "nvarchar"), MaxLength(50)]
        public string FormatType { get; set; }
    }
}