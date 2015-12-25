﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoWebApiUdemy.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        public string Category { get; set; }
        public string Format { get; set; }
    }
}