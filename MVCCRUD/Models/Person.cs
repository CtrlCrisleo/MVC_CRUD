using System;
using System.Collections.Generic;

namespace MVCCRUD.Models;

public partial class Person
{
    public int Id { get; set; }

    public string IdType { get; set; } = null!;

    public int IdNumber { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
