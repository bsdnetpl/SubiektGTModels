using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetParametrInd
{
    public int NepId { get; set; }

    public bool NepPowiadomWersjaProgramu { get; set; }

    public bool NepPowiadomWersjaParametrow { get; set; }

    public bool NepPowiadomKursy { get; set; }

    public bool NepPowiadomLicWygasanie { get; set; }

    public bool NepPowiadomLicRozbieznosci { get; set; }

    public bool NepInfoTechniczne { get; set; }

    public bool NepInfoMerytoryczne { get; set; }

    public bool NepInfoMarketingowe { get; set; }

    public int? NepParamEwidId { get; set; }

    public int NepPokazujWiadomosciPrzez { get; set; }

    public virtual ParEwid? NepParamEwid { get; set; }
}
