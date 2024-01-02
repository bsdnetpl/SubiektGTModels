using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlBibObiekt
{
    public int BicId { get; set; }

    public string BicProgId { get; set; } = null!;

    public string BicNazwa { get; set; } = null!;

    public int? BicDokTyp { get; set; }

    public int? BicDokPodtyp { get; set; }

    public int? BicProgIdCtx { get; set; }
}
