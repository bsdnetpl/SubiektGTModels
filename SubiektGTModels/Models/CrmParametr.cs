using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CrmParametr
{
    public int CrmId { get; set; }

    public bool CrmWizard { get; set; }

    public int CrmOpoznienieWybierania { get; set; }

    public string? CrmPrefixGlobalny { get; set; }

    public int? CrmAlgorytm { get; set; }
}
