using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetParametrInst
{
    public int NpiId { get; set; }

    public bool NpiPobierajAutomatycznie { get; set; }

    public bool NpiProponujInstalacje { get; set; }

    public bool NpiInstalacjaSieciowa { get; set; }

    public bool NpiUsuwajZainstalowane { get; set; }

    public string NpiSciezka { get; set; } = null!;

    public bool NpiWybranyKomputer { get; set; }

    public string NpiKomputer { get; set; } = null!;

    public string NpiNieProponujWersji { get; set; } = null!;

    public bool NpiUsuwajStarsze { get; set; }
}
