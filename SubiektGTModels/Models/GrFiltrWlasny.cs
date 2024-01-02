using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrFiltrWlasny
{
    public int GrfId { get; set; }

    public int GrfIdGrida { get; set; }

    public string GrfNazwa { get; set; } = null!;

    public string GrfSql { get; set; } = null!;
}
