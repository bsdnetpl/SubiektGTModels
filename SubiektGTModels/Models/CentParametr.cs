using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CentParametr
{
    public int CentId { get; set; }

    public string? CentPrefixGlobalny { get; set; }

    public int? CentOpoznienieWybierania { get; set; }

    public DateTime? CentDataModyfikacji { get; set; }

    public int? CentOdebranieGlos { get; set; }

    public int? CentOdebranieSkypeGlos { get; set; }

    public int? CentOdebranieSkypeChat { get; set; }

    public int? CentWybranieGlos { get; set; }

    public int? CentWybranieSkypeGlos { get; set; }

    public int? CentWybranieSkypeChat { get; set; }

    public int? CentWybranieGadu { get; set; }

    public int? CentTryb { get; set; }

    public string? CentCiagVoip { get; set; }

    public int? CentParamEwidId { get; set; }
}
