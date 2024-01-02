using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlLicznikNumeracjiRok
{
    public int LnrId { get; set; }

    public int LnrIdLicznika { get; set; }

    public int LnrRok { get; set; }

    public int LnrWartoscAktualna { get; set; }

    public virtual SlLicznikNumeracji LnrIdLicznikaNavigation { get; set; } = null!;
}
