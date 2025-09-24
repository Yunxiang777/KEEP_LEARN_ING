using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class NewsFile
{
    public Guid NewsFilesId { get; set; }

    public Guid NewsId { get; set; }

    public string Name { get; set; }

    public string Path { get; set; }

    public string Extension { get; set; }
}
