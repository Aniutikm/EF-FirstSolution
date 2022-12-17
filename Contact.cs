using System;
using System.Collections.Generic;

namespace TestEntityFramework;

public partial class Contact
{
    public short Id { get; set; }

    public string? FirstName { get; set; }

    public string? Surname { get; set; }

    public string? PhoneNumber { get; set; }
}
