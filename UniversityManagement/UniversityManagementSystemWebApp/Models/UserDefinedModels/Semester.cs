﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementSystemWebApp.Models.UserDefinedModels
{
    public class Semester
    {
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }

        public List<Course> Courses { get; set; }
    }
}