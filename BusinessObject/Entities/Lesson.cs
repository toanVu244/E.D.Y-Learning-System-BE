﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Entities;

public partial class Lesson
{
    public int LessonId { get; set; }

    public int CourseId { get; set; }

    public string Detail { get; set; } = null!;

    public string Picture { get; set; } = null!;

    public virtual Course Course { get; set; } = null!;

    public virtual ICollection<Test> Tests { get; set; } = new List<Test>();
}
