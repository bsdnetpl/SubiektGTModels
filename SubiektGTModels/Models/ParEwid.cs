using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ParEwid
{
    public int PeId { get; set; }

    public int PeIdTypu { get; set; }

    public string PeNazwa { get; set; } = null!;

    public bool PeDomyslne { get; set; }

    public int PeStatusNowosci { get; set; }

    public virtual DkrParametr? DkrParametr { get; set; }

    public virtual DkrParametrDokDoDekretacji? DkrParametrDokDoDekretacji { get; set; }

    public virtual ICollection<EddParametr> EddParametrs { get; set; } = new List<EddParametr>();

    public virtual ICollection<IcenCennikiParametr> IcenCennikiParametrs { get; set; } = new List<IcenCennikiParametr>();

    public virtual ICollection<InsSzpiegParametr> InsSzpiegParametrs { get; set; } = new List<InsSzpiegParametr>();

    public virtual InsxParametr? InsxParametr { get; set; }

    public virtual ICollection<IntParametryIntrastat> IntParametryIntrastats { get; set; } = new List<IntParametryIntrastat>();

    public virtual KhParametr? KhParametr { get; set; }

    public virtual ICollection<KkKodKreskowyParam> KkKodKreskowyParams { get; set; } = new List<KkKodKreskowyParam>();

    public virtual ICollection<KsefParametry> KsefParametries { get; set; } = new List<KsefParametry>();

    public virtual ICollection<KsefParametryAlgorytmyMapowaniaTw> KsefParametryAlgorytmyMapowaniaTws { get; set; } = new List<KsefParametryAlgorytmyMapowaniaTw>();

    public virtual NetParametrInd? NetParametrInd { get; set; }

    public virtual ICollection<NzCesjaParametrySzybkiePlatnosci> NzCesjaParametrySzybkiePlatnoscis { get; set; } = new List<NzCesjaParametrySzybkiePlatnosci>();

    public virtual OssParametr? OssParametr { get; set; }

    public virtual PdBlokadum? PdBlokadum { get; set; }

    public virtual ICollection<PdParametrHaslo> PdParametrHaslos { get; set; } = new List<PdParametrHaslo>();

    public virtual ParTyp PeIdTypuNavigation { get; set; } = null!;

    public virtual PlbParametrWyplaty? PlbParametrWyplaty { get; set; }

    public virtual PlbUmowaParametr? PlbUmowaParametr { get; set; }

    public virtual ICollection<PojParametr> PojParametrs { get; set; } = new List<PojParametr>();

    public virtual ICollection<PosParam> PosParams { get; set; } = new List<PosParam>();

    public virtual ICollection<PrmPromocjeParametr> PrmPromocjeParametrs { get; set; } = new List<PrmPromocjeParametr>();

    public virtual ICollection<SkParametr> SkParametrs { get; set; } = new List<SkParametr>();

    public virtual SuParametr? SuParametr { get; set; }

    public virtual TrParametr? TrParametr { get; set; }

    public virtual VatParametr? VatParametr { get; set; }

    public virtual ICollection<WyWydrukParam> WyWydrukParams { get; set; } = new List<WyWydrukParam>();

    public virtual ICollection<PdUzytkownik> PepIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
