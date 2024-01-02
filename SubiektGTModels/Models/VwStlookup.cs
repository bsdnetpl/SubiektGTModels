using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwStlookup
{
    public int StId { get; set; }

    public int StStatus { get; set; }

    public int StTyp { get; set; }

    public string StNazwa { get; set; } = null!;

    public string StNrInw { get; set; } = null!;

    public bool? StoCzyAmort { get; set; }

    public bool? StoCzyAmortBil { get; set; }
}
