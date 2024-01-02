using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbWyplataSkladnik
{
    public int WypsId { get; set; }

    public int WypsIdWyplaty { get; set; }

    public int WypsIdSkladnika { get; set; }

    public string WypsNazwa { get; set; } = null!;

    public decimal WypsWartoscNom { get; set; }

    public decimal WypsWartoscFin { get; set; }

    public bool WypsOpodatkowany { get; set; }

    public int WypsTyp { get; set; }

    public decimal WypsKwotaDoChor { get; set; }

    public decimal WypsKwotaDoUrl { get; set; }

    public decimal WypsKwotaEmRe { get; set; }

    public decimal WypsKwotaChWy { get; set; }

    public decimal WypsKwotaZdr { get; set; }

    public int WypsBylKwprzelewWydruk { get; set; }

    public bool WypsCzyPotracenieKomornicze { get; set; }

    public decimal WypsKwotaFep { get; set; }

    public bool WypsZwolnienieZpodatku { get; set; }

    public bool WypsNieOgrSklZdr { get; set; }

    public bool WypsZwolnienieZpodatkuDlaMlodych { get; set; }

    public decimal? WypsWartoscDoChorobowego { get; set; }

    public decimal? WypsPodstawaEmReDoChorobowego { get; set; }

    public decimal? WypsPodstawaChWyDoChorobowego { get; set; }

    public virtual PlbSkladnik WypsIdSkladnikaNavigation { get; set; } = null!;

    public virtual PlbWyplatum WypsIdWyplatyNavigation { get; set; } = null!;
}
