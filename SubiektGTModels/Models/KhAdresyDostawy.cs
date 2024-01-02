using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhAdresyDostawy
{
    public int AdkId { get; set; }

    public int AdkIdKhnt { get; set; }

    public int AdkIdAdresuHist { get; set; }

    public virtual AdrHistorium AdkIdAdresuHistNavigation { get; set; } = null!;

    public virtual KhKontrahent AdkIdKhntNavigation { get; set; } = null!;
}
