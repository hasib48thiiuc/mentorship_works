﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FWork
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CourseId { get; set; }
        public Course course { get; set; }

    }
}
