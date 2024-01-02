using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class MiKhPomijany
{
    public int MikpId { get; set; }

    public int? MikpIdParametr { get; set; }

    public int? MikpIdKontrahent { get; set; }

    public virtual KhKontrahent? MikpIdKontrahentNavigation { get; set; }

    public virtual MiSprzedazParametr? MikpIdParametrNavigation { get; set; }
}
