using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Audios")]
    public class Audio
    {
        public Audio()
        {

        }

        [Key, Column("AudioId", TypeName = "int")]
        public int AudioId { get; set; }

        [Column("FileLinkUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string FileLinkUrl { get; set; }

        [Column("MovieId", TypeName = "int")]
        public int? MovieId { get; set; }

        [Column("ViewCount", TypeName = "int")]
        public int? ViewCount { get; set; }

        [Column("Audio_Status", TypeName = "bit"), DefaultValue(1), DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool? AudioStatus { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}