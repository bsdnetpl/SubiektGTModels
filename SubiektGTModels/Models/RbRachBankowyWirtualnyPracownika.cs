using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyWirtualnyPracownika
{
    public int RbpId { get; set; }

    public int RbpIdRachunkuWirtualnego { get; set; }

    public int RbpIdPracownika { get; set; }

    public virtual PrPracownik RbpIdPracownikaNavigation { get; set; } = null!;

    public virtual RbRachBankowyWirtualny RbpIdRachunkuWirtualnegoNavigation { get; set; } = null!;
}
