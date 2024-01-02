using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlZwolnienieZakcyzy
{
    public int AkcId { get; set; }

    public string AkcNazwa { get; set; } = null!;

    public bool? AkcCzyWidoczna { get; set; }
}
