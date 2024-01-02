using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PbParametr
{
    public int PbparId { get; set; }

    public int PbparMaksRozmiar { get; set; }

    public bool PbparPobierajPlikiNaWejscie { get; set; }

    public bool PbparBlokadaPobierania { get; set; }
}
