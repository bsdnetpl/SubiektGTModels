using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwSesjaBlokadum
{
    public int? SsTypObiektu { get; set; }

    public int? SsTypObiektuEx { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }
}
