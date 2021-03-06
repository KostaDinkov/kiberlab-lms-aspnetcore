﻿using System;
using KiberlabLMS.Models.CourseModels;
using KiberlabLMS.Models.Shared;

namespace KiberlabLMS.Models.State
{
    public class SectionState : BaseModel
    {
        public DateTime CompletedOn { get; set; }

        public bool IsComplete { get; set; }

        public bool IsLocked { get; set; }

        public string SectionId { get; set; }

        public Section Section { get; set; }

        public string CourseStateId { get; set; }

        public CourseState CourseState { get; set; }
    }
}
