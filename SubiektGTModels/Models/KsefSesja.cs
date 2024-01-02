using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefSesja
{
    public int KsefsId { get; set; }

    public int KsefsUzytkId { get; set; }

    public string KsefsSessionId { get; set; } = null!;

    public byte[] KsefsSessionToken { get; set; } = null!;

    public DateTime KsefsDataUtworzenia { get; set; }

    public int KsefsSrodowisko { get; set; }

    public int KsefsUpostatus { get; set; }

    public virtual ICollection<DokDokument> DokDokuments { get; set; } = new List<DokDokument>();

    public virtual ICollection<KsefUpo> KsefUpos { get; set; } = new List<KsefUpo>();
}
