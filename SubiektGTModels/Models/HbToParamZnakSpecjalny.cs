using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbToParamZnakSpecjalny
{
    public int HbzsId { get; set; }

    public int HbzsBank { get; set; }

    public string HbzsZnakSpecjalny { get; set; } = null!;

    public string HbzsZnakZamiana { get; set; } = null!;

    public bool HbzsNazwa { get; set; }

    public bool HbzsTytul { get; set; }

    public bool HbzsPodmiot { get; set; }
}
