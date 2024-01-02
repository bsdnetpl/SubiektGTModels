using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModulPosxaml
{
    public int UiposxId { get; set; }

    public int UiposxModulPosid { get; set; }

    public int UiposxTyp { get; set; }

    public string UiposxXaml { get; set; } = null!;

    public string UiposxXamlNazwa { get; set; } = null!;

    public DateTime UiposxXamlData { get; set; }

    public DateTime? UiposxXamlDataWczytania { get; set; }

    public int? UiposxTypEx { get; set; }
}
