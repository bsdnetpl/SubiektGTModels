using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokSzczegolyTransportu
{
    public int DdtDokId { get; set; }

    public int DdtKodJednostki { get; set; }

    public string DdtOpisJednostki { get; set; } = null!;

    public virtual DokDokument DdtDok { get; set; } = null!;

    public virtual SlKodJednostkiTransportowejEdd DdtKodJednostkiNavigation { get; set; } = null!;
}
