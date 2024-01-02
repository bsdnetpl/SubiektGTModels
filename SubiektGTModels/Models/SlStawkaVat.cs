using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaVat
{
    public int VatId { get; set; }

    public string VatNazwa { get; set; } = null!;

    public decimal VatStawka { get; set; }

    public string VatSymbol { get; set; } = null!;

    public bool VatCzySystemowa { get; set; }

    public bool VatCzyWidoczna { get; set; }

    public int VatPozycja { get; set; }

    public int VatPozSprzedaz { get; set; }

    public int VatPozZakup { get; set; }

    public int VatPozRr { get; set; }

    public int VatPozDomyslna { get; set; }

    public int VatRodzaj { get; set; }

    public bool VatStawkaZagraniczna { get; set; }

    public bool? VatStawkaZagranicznaPdst { get; set; }

    public int? VatIdPanstwo { get; set; }

    public bool? VatUePanstwo { get; set; }

    public virtual ICollection<DfwVat> DfwVats { get; set; } = new List<DfwVat>();

    public virtual ICollection<DkrPozycja> DkrPozycjas { get; set; } = new List<DkrPozycja>();

    public virtual ICollection<DkrWydatekNaPojazd> DkrWydatekNaPojazds { get; set; } = new List<DkrWydatekNaPojazd>();

    public virtual ICollection<DokVat> DokVats { get; set; } = new List<DokVat>();

    public virtual ICollection<ImSchematImportuPozDekretu> ImSchematImportuPozDekretus { get; set; } = new List<ImSchematImportuPozDekretu>();

    public virtual ICollection<NzFinanseSplataVat> NzFinanseSplataVats { get; set; } = new List<NzFinanseSplataVat>();

    public virtual ICollection<OssDaneVat> OssDaneVats { get; set; } = new List<OssDaneVat>();

    public virtual ICollection<PkPlanKont> PkPlanKonts { get; set; } = new List<PkPlanKont>();

    public virtual ICollection<PkWzorzec> PkWzorzecs { get; set; } = new List<PkWzorzec>();

    public virtual ICollection<RfVat> RfVats { get; set; } = new List<RfVat>();

    public virtual ICollection<SuParametr> SuParametrSuVatExes { get; set; } = new List<SuParametr>();

    public virtual ICollection<SuParametr> SuParametrSuVatUes { get; set; } = new List<SuParametr>();

    public virtual ICollection<SuParametr> SuParametrSuVatUjs { get; set; } = new List<SuParametr>();

    public virtual ICollection<SuParametr> SuParametrSuVatZws { get; set; } = new List<SuParametr>();

    public virtual ICollection<TwKreatorPkwiU2015RegulyStawekVat> TwKreatorPkwiU2015RegulyStawekVats { get; set; } = new List<TwKreatorPkwiU2015RegulyStawekVat>();

    public virtual ICollection<TwTowar> TwTowarTwIdVatSpNavigations { get; set; } = new List<TwTowar>();

    public virtual ICollection<TwTowar> TwTowarTwIdVatZakNavigations { get; set; } = new List<TwTowar>();

    public virtual ICollection<UfVat> UfVats { get; set; } = new List<UfVat>();

    public virtual ICollection<VatDaneVat> VatDaneVats { get; set; } = new List<VatDaneVat>();

    public virtual SlPanstwo? VatIdPanstwoNavigation { get; set; }
}
