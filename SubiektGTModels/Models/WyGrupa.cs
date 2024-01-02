using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyGrupa
{
    public int WgrId { get; set; }

    public string WgrNazwa { get; set; } = null!;

    public bool WgrSubiekt { get; set; }

    public int WgrRachmistrz { get; set; }

    public int WgrMgratyfikant { get; set; }

    public bool WgrUf { get; set; }

    public bool WgrCrm { get; set; }

    public bool WgrNavireo { get; set; }
}
