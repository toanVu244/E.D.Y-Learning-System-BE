﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models;

public partial class Notification
{
    public string NotifiId { get; set; } = null!;

    public string? UserId { get; set; }

    public string? ContentNotifi { get; set; }

    public DateTime? Date { get; set; }

    public virtual User? User { get; set; }
}