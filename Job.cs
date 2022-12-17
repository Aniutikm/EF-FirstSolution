using System;
using System.Collections.Generic;

namespace TestEntityFramework;

public partial class Job
{
    public short Id { get; set; }

    public decimal? Salary { get; set; }

    public string? Position { get; set; }
}
