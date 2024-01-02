using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlLicznikNumeracji
{
    public int LnId { get; set; }

    public string LnNazwa { get; set; } = null!;

    public int LnTyp { get; set; }

    public int LnDomyslna { get; set; }

    public int LnWartoscAktualna { get; set; }

    public virtual ICollection<SlFormatNumeracjiElement> SlFormatNumeracjiElements { get; set; } = new List<SlFormatNumeracjiElement>();

    public virtual ICollection<SlLicznikNumeracjiRok> SlLicznikNumeracjiRoks { get; set; } = new List<SlLicznikNumeracjiRok>();
}
