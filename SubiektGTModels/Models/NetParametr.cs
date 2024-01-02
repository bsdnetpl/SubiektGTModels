using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetParametr
{
    public int NepId { get; set; }

    public bool NepZainicjowane { get; set; }

    public bool NepAutoAktualizacja { get; set; }

    public int NepOdstep { get; set; }

    public bool NepZgoda { get; set; }

    public bool NepOdswiezLicencje { get; set; }
}
