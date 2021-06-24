﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Final.Models
{
    [MetadataType(typeof(NewsMetadata))]
    public partial class News
    {
    }
    public class NewsMetadata
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "標題")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "內容")]
        public string Content { get; set; }
        [Required(ErrorMessage = "必填欄位")]
        [Display(Name = "發布日期")]
        public System.DateTime PublishDate { get; set; }
    }
}