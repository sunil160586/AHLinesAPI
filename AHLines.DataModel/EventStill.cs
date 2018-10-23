﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AHLines.DataModel
{
    [Table("AHL_Events_Stills")]
    public class EventStill
    {
        public EventStill()
        {
            DisplayPage = 1;
            ViewCount = 500;
        }

        [Key, Column("StillId", TypeName = "int")]
        public int StillId { get; set; }

        [Column("EventId", TypeName = "int")]
        public int? EventId { get; set; }

        [Column("EventStillId", TypeName = "int")]
        public int? EventStillId { get; set; }

        [Column("DisplayStatus", TypeName = "nvarchar"), MaxLength(1)]
        public string DisplayStatus { get; set; }

        [Column("DisplayPage", TypeName = "int")]
        public int? DisplayPage { get; set; }

        [Column("ThumbImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string ThumbImageUrl { get; set; }

        [Column("SmallImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string SmallImageUrl { get; set; }

        [Column("LargeImageUrl", TypeName = "nvarchar"), MaxLength(100)]
        public string LargeImageUrl { get; set; }

        [Column("ViewCount", TypeName = "int")]
        public int? ViewCount { get; set; }

        [Column("LastViewed", TypeName = "datetime")]
        public DateTime? LastViewed { get; set; }

        [Column("CreatedDate", TypeName = "datetime")]
        public DateTime? Created { get; set; }

        [Column("CreatedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string CreatedBy { get; set; }

        [Column("ModifiedDate", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [Column("ModifiedBy", TypeName = "nvarchar"), MaxLength(50)]
        public string UpdatedBy { get; set; }

        [Column("OldEventId", TypeName = "int")]
        public int? OldEventId { get; set; }
    }
}