using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiFunkcja
{
    public int UifId { get; set; }

    public int UifIdModulu { get; set; }

    public int UifWorek { get; set; }

    public int UifPozycja { get; set; }

    public int? UifPozycjaOjca { get; set; }

    public int? UifTypOperacji { get; set; }

    public int? UifIdOperacji { get; set; }

    public int UifStyl { get; set; }

    public string UifNapis { get; set; } = null!;

    public int? UifPodwidok { get; set; }

    public bool UifDomyslna { get; set; }

    public bool? UifRozwijaj { get; set; }

    public bool? UifOdRazuMenu { get; set; }

    public string? UifParametr { get; set; }

    public virtual UiModul UifIdModuluNavigation { get; set; } = null!;
}
