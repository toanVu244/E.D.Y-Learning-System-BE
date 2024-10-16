﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Category
{
    public int Idcategory { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
