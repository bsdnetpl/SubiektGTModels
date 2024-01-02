using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileZestawieniaErp
{
    public int ZstId { get; set; }

    public string? Grupa { get; set; }

    public string ZstNazwa { get; set; } = null!;

    public int ZstTyp { get; set; }

    public string ZstProgId { get; set; } = null!;

    public int ZstStatusNowosci { get; set; }
}
