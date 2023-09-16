using System;
using System.Collections.Generic;

namespace Semana04FirstEFCore.API.Models;

public partial class People
{
    public int Id { get; set; }

    public string? Fullname { get; set; }

    public string? Email { get; set; }

    public int? Dni { get; set; }
}
