using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdOstrzezenium
{
    public int OstNumerProgramowy { get; set; }

    public int OstIdUzytkownika { get; set; }

    public int OstNiePokazujWiecejFlagi { get; set; }

    public bool OstPokazujRazDlaWszystkich { get; set; }

    public virtual PdUzytkownik OstIdUzytkownikaNavigation { get; set; } = null!;
}
