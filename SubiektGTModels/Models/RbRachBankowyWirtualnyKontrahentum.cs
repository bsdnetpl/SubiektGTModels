using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyWirtualnyKontrahentum
{
    public int RbkId { get; set; }

    public int RbkIdRachunkuWirtualnego { get; set; }

    public int RbkIdKontrahenta { get; set; }

    public virtual KhKontrahent RbkIdKontrahentaNavigation { get; set; } = null!;

    public virtual RbRachBankowyWirtualny RbkIdRachunkuWirtualnegoNavigation { get; set; } = null!;
}
