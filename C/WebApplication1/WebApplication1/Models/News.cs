using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class News
{
    public Guid NewsId { get; set; }

    public string Title { get; set; }

    public string Content { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime EndDateTime { get; set; }

    public int Click { get; set; }

    public DateTime UpdateDateTime { get; set; }

    public int UpdateEmploeeId { get; set; }

    public DateTime insertDateTime { get; set; }

    public int InsertEmploeeId { get; set; }

    public bool Enable { get; set; }
}
