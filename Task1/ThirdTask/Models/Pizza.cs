using System;
using System.Collections.Generic;

namespace ThirdTask.Models;

public partial class Pizza
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Price { get; set; } = null!;
}
