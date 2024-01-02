using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWalutum
{
    public int WlId { get; set; }

    public string WlSymbol { get; set; } = null!;

    public string WlNazwa { get; set; } = null!;

    public int WlLiczbaJednostek { get; set; }

    public bool WlAktywna { get; set; }

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrPozycja> DkrPozycjas { get; set; } = new List<DkrPozycja>();

    public virtual ICollection<DkrWzorzecPozycja> DkrWzorzecPozycjas { get; set; } = new List<DkrWzorzecPozycja>();

    public virtual ICollection<DkrWzorzec> DkrWzorzecs { get; set; } = new List<DkrWzorzec>();

    public virtual ICollection<DksKasaBo> DksKasaBos { get; set; } = new List<DksKasaBo>();

    public virtual ICollection<DksKasa> DksKasas { get; set; } = new List<DksKasa>();

    public virtual ICollection<HbTransakcjaOczekujaca> HbTransakcjaOczekujacas { get; set; } = new List<HbTransakcjaOczekujaca>();

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<NzRaportKasowyStan> NzRaportKasowyStans { get; set; } = new List<NzRaportKasowyStan>();

    public virtual ICollection<RbRachBankowy> RbRachBankowies { get; set; } = new List<RbRachBankowy>();

    public virtual ICollection<RbRachBankowyHistorium> RbRachBankowyHistoria { get; set; } = new List<RbRachBankowyHistorium>();

    public virtual ICollection<SkStan> SkStans { get; set; } = new List<SkStan>();

    public virtual ICollection<SlRejestrKsiegowy> SlRejestrKsiegowies { get; set; } = new List<SlRejestrKsiegowy>();

    public virtual ICollection<SlWalutaKur> SlWalutaKurs { get; set; } = new List<SlWalutaKur>();

    public virtual ICollection<SlWalutaNominal> SlWalutaNominals { get; set; } = new List<SlWalutaNominal>();
}
