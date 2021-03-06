﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KiberlabLMS.Data.Common.Models;
using KiberlabLMS.Data.Models.CourseModels;
using KiberlabLMS.Data.Models.User;

namespace KiberlabLMS.Data.Models.State
{
    public class CourseInstance : BaseModel
    {
        public CourseInstance()
        {
            this.UserProfiles = new HashSet<UserProfile>();
            //this.CourseStates = new HashSet<CourseState>();
        }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public ICollection<UserProfile> UserProfiles { get; set; }

        public Course Course { get; set; }

        public string CourseId { get; set; }

        //public ICollection<CourseState> CourseStates { get; set; }
    }
}
