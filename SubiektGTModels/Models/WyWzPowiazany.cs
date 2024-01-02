using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyWzPowiazany
{
    public int WpwId { get; set; }

    public int WpwIdWzorca { get; set; }

    public bool? WpwDrukujKp { get; set; }

    public bool? WpwDrukujKw { get; set; }

    public bool? WpwDrukujPz { get; set; }

    public bool? WpwDrukujWz { get; set; }

    public int? WpwLiczbaKopiiKp { get; set; }

    public int? WpwLiczbaKopiiKw { get; set; }

    public int? WpwLiczbaKopiiPz { get; set; }

    public int? WpwLiczbaKopiiWz { get; set; }

    public int? WpwIdWzorcaKp { get; set; }

    public int? WpwIdWzorcaKw { get; set; }

    public int? WpwIdWzorcaPz { get; set; }

    public int? WpwIdWzorcaWz { get; set; }

    public bool? WpwDrukujPrzelew { get; set; }

    public int? WpwLiczbaKopiiPrzelewu { get; set; }

    public bool? WpwDrukujZal { get; set; }

    public int? WpwLiczbaKopiiZal { get; set; }

    public int? WpwIdWzorcaZal { get; set; }

    public bool? WpwDrukujOswDotPochodzeniaWegla { get; set; }

    public int? WpwLiczbaKopiiOswDotPochodzeniaWegla { get; set; }

    public int? WpwIdWzorcaOswDotPochodzeniaWegla { get; set; }
}
