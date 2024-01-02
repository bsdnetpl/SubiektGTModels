using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlMagazyn
{
    public int MagId { get; set; }

    public string MagSymbol { get; set; } = null!;

    public string MagNazwa { get; set; } = null!;

    public int MagStatus { get; set; }

    public string? MagOpis { get; set; }

    public string? MagAnalityka { get; set; }

    public bool MagGlowny { get; set; }

    public bool MagPos { get; set; }

    public Guid? MagPosident { get; set; }

    public string? MagPosnazwa { get; set; }

    public string? MagPosadres { get; set; }

    public virtual ICollection<EddEdokDostawy> EddEdokDostawies { get; set; } = new List<EddEdokDostawy>();

    public virtual ICollection<IcenCennikMagazyn> IcenCennikMagazyns { get; set; } = new List<IcenCennikMagazyn>();

    public virtual ICollection<ImSchematImportu> ImSchematImportus { get; set; } = new List<ImSchematImportu>();

    public virtual ICollection<IwDokument> IwDokuments { get; set; } = new List<IwDokument>();

    public virtual ICollection<KsefFakturyHandel> KsefFakturyHandels { get; set; } = new List<KsefFakturyHandel>();

    public virtual ICollection<KsefParametry> KsefParametries { get; set; } = new List<KsefParametry>();

    public virtual ICollection<MiSprzedazParametr> MiSprzedazParametrs { get; set; } = new List<MiSprzedazParametr>();

    public virtual ICollection<PdUzytkMagazyn> PdUzytkMagazyns { get; set; } = new List<PdUzytkMagazyn>();

    public virtual ICollection<PdUzytkownik> PdUzytkowniks { get; set; } = new List<PdUzytkownik>();

    public virtual ICollection<PrmPromocjeMagazyn> PrmPromocjeMagazyns { get; set; } = new List<PrmPromocjeMagazyn>();

    public virtual ICollection<SlOddzialMagazyn> SlOddzialMagazyns { get; set; } = new List<SlOddzialMagazyn>();

    public virtual ICollection<TwStan> TwStans { get; set; } = new List<TwStan>();

    public virtual ICollection<UfKonfiguracja> UfKonfiguracjas { get; set; } = new List<UfKonfiguracja>();

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas1 { get; set; } = new List<PdUzytkownik>();

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikasNavigation { get; set; } = new List<PdUzytkownik>();
}
