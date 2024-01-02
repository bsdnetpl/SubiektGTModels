using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUprawnienie
{
    public int UprId { get; set; }

    public string? UprNazwa { get; set; }

    public int? UprProgram { get; set; }

    public string? UprModul { get; set; }

    public bool? UprChecked { get; set; }

    public bool? UprMagazynowe { get; set; }

    public int UprStatusNowosci { get; set; }

    public int UprStatusNowosciM { get; set; }

    public bool UprUkryte { get; set; }

    public virtual ICollection<UiOperacja> UiOperacjas { get; set; } = new List<UiOperacja>();
}
