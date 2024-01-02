using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZlpParametryZlecen
{
    public int ZlppId { get; set; }

    public int ZlppIdDomyslnegoFormatuNumeracji { get; set; }

    public virtual SlFormatNumeracji ZlppIdDomyslnegoFormatuNumeracjiNavigation { get; set; } = null!;
}
