using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NkPoleSzablonu
{
    public int NdId { get; set; }

    public string NdNazwaPolaDanych { get; set; } = null!;

    public int NdIdSzablonu { get; set; }

    public string NdOpis { get; set; } = null!;

    public string NdOpisPo { get; set; } = null!;

    public string NdCzcionka { get; set; } = null!;

    public int NdX { get; set; }

    public int NdY { get; set; }

    public int NdSzer { get; set; }

    public int NdWys { get; set; }

    public bool NdCzyNumer { get; set; }

    public bool NdCzyUsuwacZera { get; set; }

    public bool NdCzyZaokr { get; set; }

    public int NdIlePoPrzec { get; set; }

    public int NdCzyDuzaJm { get; set; }

    public int NdWyrownanie { get; set; }

    public bool NdSlownie { get; set; }

    public bool NdCzyCenaPoPromo { get; set; }

    public int NdPoziomCeny { get; set; }

    public int NdIdPromocja { get; set; }

    public bool NdCzyCenaPoprzedniaLubZ30dni { get; set; }

    public virtual NkSzablon NdIdSzablonuNavigation { get; set; } = null!;
}
