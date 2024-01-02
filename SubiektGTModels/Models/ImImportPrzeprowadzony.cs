using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImImportPrzeprowadzony
{
    public int IpId { get; set; }

    public int IpZrodlo { get; set; }

    public DateTime IpData { get; set; }

    public int IpOkres { get; set; }

    public DateTime IpDataOd { get; set; }

    public DateTime IpDataDo { get; set; }

    public int IpIdOperatora { get; set; }

    public int IpTypDokumentow { get; set; }

    public int IpMagazyn { get; set; }

    public bool IpImportPonowny { get; set; }

    public int IpPrzerwijImport { get; set; }

    public string IpOpis { get; set; } = null!;

    public int? IpLiczbaWybranych { get; set; }

    public int? IpLiczbaOk { get; set; }

    public virtual ICollection<ImImportLog> ImImportLogs { get; set; } = new List<ImImportLog>();

    public virtual PdUzytkownik IpIdOperatoraNavigation { get; set; } = null!;
}
