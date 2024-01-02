using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefFakturyHandel
{
    public int KsefhId { get; set; }

    public int KsefhIdFaktury { get; set; }

    public int? KsefhIdDokumentu { get; set; }

    public int? KsefhMagId { get; set; }

    public virtual DokDokument? KsefhIdDokumentuNavigation { get; set; }

    public virtual KsefFaktury KsefhIdFakturyNavigation { get; set; } = null!;

    public virtual SlMagazyn? KsefhMag { get; set; }
}
