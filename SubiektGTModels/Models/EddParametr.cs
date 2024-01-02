using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EddParametr
{
    public int EdpId { get; set; }

    public int EdpParamEwidId { get; set; }

    public int EdpIdNumeracjiLnr { get; set; }

    public int EdpIdNumeracjiWiadomosci { get; set; }

    public int EdpZrodloMiejscaWysylki { get; set; }

    public string EdpAdresEmailWysylkiEdd { get; set; } = null!;

    public int? EdpIdKontaEmailWysylkiEdd { get; set; }

    public string EdpMaskaAdresuOdbioruStatusowEdd { get; set; } = null!;

    public int? EdpKodRodzajuTransportu { get; set; }

    public string EdpDodatkoweInfoRodzajuTransportu { get; set; } = null!;

    public string EdpCzasWysylkiTransportu { get; set; } = null!;

    public string EdpCzasPrzewozuTransportu { get; set; } = null!;

    public int EdpTrybDostawyTwAkcyzowych { get; set; }

    public int EdpTrybOdroczonyWysylkiEdd { get; set; }

    public bool EdpSystemowyCzasWysylkiTransportu { get; set; }

    public int EdpZrodloMiejscaOdbioru { get; set; }

    public virtual EmAccount? EdpIdKontaEmailWysylkiEddNavigation { get; set; }

    public virtual SlFormatNumeracji EdpIdNumeracjiLnrNavigation { get; set; } = null!;

    public virtual SlFormatNumeracji EdpIdNumeracjiWiadomosciNavigation { get; set; } = null!;

    public virtual SlKodRodzajuTransportuEdd? EdpKodRodzajuTransportuNavigation { get; set; }

    public virtual ParEwid EdpParamEwid { get; set; } = null!;

    public virtual SlTrybDostawyTwAkcyzowych EdpTrybDostawyTwAkcyzowychNavigation { get; set; } = null!;

    public virtual SlTrybOdroczonyWysylkiEdd EdpTrybOdroczonyWysylkiEddNavigation { get; set; } = null!;
}
