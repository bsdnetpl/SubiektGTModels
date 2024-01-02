using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfTransmisjaSzczegol
{
    public int UtsId { get; set; }

    public int UtsIdTransmisja { get; set; }

    public int UtsLp { get; set; }

    public int? UtsStatus { get; set; }

    public int? UtsNumer { get; set; }

    public string UtsKomunikat { get; set; } = null!;

    public virtual ICollection<UfTransmisjaKontekst> UfTransmisjaKonteksts { get; set; } = new List<UfTransmisjaKontekst>();

    public virtual UfTransmisja UtsIdTransmisjaNavigation { get; set; } = null!;
}
