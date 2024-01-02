using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CenCennikSzablon
{
    public int CsId { get; set; }

    public int CsFiltrTyp { get; set; }

    public int CsRodzajFiltr { get; set; }

    public int CsStanFiltr { get; set; }

    public int CsDataTyp { get; set; }

    public DateTime CsDataOkreslona { get; set; }

    public DateTime CsDataPrzedzialOd { get; set; }

    public DateTime CsDataPrzedzialDo { get; set; }

    public string CsTytul { get; set; } = null!;

    public string CsOpis { get; set; } = null!;

    public string CsUwagi { get; set; } = null!;

    public string CsNazwa { get; set; } = null!;

    public bool CsCzyWzorzec { get; set; }

    public int? CsIdWzorzec { get; set; }

    public bool? CsIgnorujNoweElementy { get; set; }

    public int? CsMaxTowId { get; set; }

    public bool CsNotIn { get; set; }

    public virtual ICollection<CenCennikCecha> CenCennikCechas { get; set; } = new List<CenCennikCecha>();

    public virtual ICollection<CenCennikElement> CenCennikElements { get; set; } = new List<CenCennikElement>();

    public virtual ICollection<CenCennikGrupa> CenCennikGrupas { get; set; } = new List<CenCennikGrupa>();

    public virtual ICollection<CenCennikKolumna> CenCennikKolumnas { get; set; } = new List<CenCennikKolumna>();
}
