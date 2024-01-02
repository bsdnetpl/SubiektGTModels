using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileWydrukiErp
{
    public int WzwId { get; set; }

    public string? WgrNazwa { get; set; }

    public string WtpNazwa { get; set; } = null!;

    public string WzwNazwa { get; set; } = null!;

    public int WzwStatusNowosci { get; set; }
}
