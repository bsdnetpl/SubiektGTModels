using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModul
{
    public int UimId { get; set; }

    public int UimTyp { get; set; }

    public int UimProgram { get; set; }

    public int? UimIdWzorca { get; set; }

    public string UimProgid { get; set; } = null!;

    public int UimTypKontekstu { get; set; }

    public string UimKontekst { get; set; } = null!;

    public string UimTytul { get; set; } = null!;

    public string UimPodtytul { get; set; } = null!;

    public string? UimVespDef { get; set; }

    public string? UimXslt { get; set; }

    public bool UimHtml { get; set; }

    public int UimSchematKolorow { get; set; }

    public bool UimFiltrWymagany { get; set; }

    public int UimStatusNowosci { get; set; }

    public string UimOpis { get; set; } = null!;

    public bool UimUkryte { get; set; }

    public virtual ICollection<UiModul> InverseUimIdWzorcaNavigation { get; set; } = new List<UiModul>();

    public virtual ICollection<PdUzytkModulHist> PdUzytkModulHists { get; set; } = new List<PdUzytkModulHist>();

    public virtual ICollection<RozRozszerzenieSql> RozRozszerzenieSqls { get; set; } = new List<RozRozszerzenieSql>();

    public virtual ICollection<RozZestKontekstowe> RozZestKontekstowes { get; set; } = new List<RozZestKontekstowe>();

    public virtual ICollection<UiFiltrDeklaracje> UiFiltrDeklaracjes { get; set; } = new List<UiFiltrDeklaracje>();

    public virtual ICollection<UiFiltr> UiFiltrs { get; set; } = new List<UiFiltr>();

    public virtual ICollection<UiFunkcja> UiFunkcjas { get; set; } = new List<UiFunkcja>();

    public virtual ICollection<UiModulPo> UiModulPos { get; set; } = new List<UiModulPo>();

    public virtual ICollection<UiModulPowiazany> UiModulPowiazanies { get; set; } = new List<UiModulPowiazany>();

    public virtual ICollection<UiOperacjaModul> UiOperacjaModuls { get; set; } = new List<UiOperacjaModul>();

    public virtual ICollection<UiPodwidok> UiPodwidoks { get; set; } = new List<UiPodwidok>();

    public virtual ICollection<UiSkrotModul> UiSkrotModuls { get; set; } = new List<UiSkrotModul>();

    public virtual UiModul? UimIdWzorcaNavigation { get; set; }

    public virtual UiKolor UimSchematKolorowNavigation { get; set; } = null!;

    public virtual ICollection<PdUzytkownik> UipIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
