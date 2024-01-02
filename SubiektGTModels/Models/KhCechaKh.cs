using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhCechaKh
{
    public int CkId { get; set; }

    public int CkIdKhnt { get; set; }

    public int CkIdCecha { get; set; }

    public virtual SlCechaKh CkIdCechaNavigation { get; set; } = null!;

    public virtual KhKontrahent CkIdKhntNavigation { get; set; } = null!;
}
