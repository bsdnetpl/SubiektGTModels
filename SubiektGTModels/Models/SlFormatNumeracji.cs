using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlFormatNumeracji
{
    public int FnId { get; set; }

    public string FnNazwa { get; set; } = null!;

    public int FnTypNumeru { get; set; }

    public virtual ICollection<DksKasa> DksKasas { get; set; } = new List<DksKasa>();

    public virtual ICollection<EddParametr> EddParametrEdpIdNumeracjiLnrNavigations { get; set; } = new List<EddParametr>();

    public virtual ICollection<EddParametr> EddParametrEdpIdNumeracjiWiadomosciNavigations { get; set; } = new List<EddParametr>();

    public virtual ICollection<NzCesjaParametr> NzCesjaParametrs { get; set; } = new List<NzCesjaParametr>();

    public virtual ICollection<NzCesjaParametrySzybkiePlatnosci> NzCesjaParametrySzybkiePlatnoscis { get; set; } = new List<NzCesjaParametrySzybkiePlatnosci>();

    public virtual ICollection<PlbSzablonLp> PlbSzablonLpSlpIdSzablonuNazwyLpNavigations { get; set; } = new List<PlbSzablonLp>();

    public virtual ICollection<PlbSzablonLp> PlbSzablonLpSlpIdSzablonuNumeruLpNavigations { get; set; } = new List<PlbSzablonLp>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestawUpzRachIdFmtNumeruNavigations { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestawUpzUmowaIdFmtNumeruNavigations { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCp> PlbUmowaCps { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PlbUmowaParametr> PlbUmowaParametrs { get; set; } = new List<PlbUmowaParametr>();

    public virtual ICollection<SkParametr> SkParametrs { get; set; } = new List<SkParametr>();

    public virtual ICollection<SlFormatNumeracjiElement> SlFormatNumeracjiElements { get; set; } = new List<SlFormatNumeracjiElement>();

    public virtual ICollection<SuParametr> SuParametrs { get; set; } = new List<SuParametr>();

    public virtual ICollection<ZlpParametryZlecen> ZlpParametryZlecens { get; set; } = new List<ZlpParametryZlecen>();
}
