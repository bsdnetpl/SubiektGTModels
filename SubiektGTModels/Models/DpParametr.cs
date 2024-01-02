using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DpParametr
{
    public int DpparId { get; set; }

    public int DpparMaksRozmiar { get; set; }

    public bool DpparPobierajPlikiNaWejscie { get; set; }

    public bool DpparBlokadaPobierania { get; set; }
}
