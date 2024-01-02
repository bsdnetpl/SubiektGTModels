using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikiParametrTyp
{
    public int IcenptId { get; set; }

    public int IcenptTyp { get; set; }

    public int IcenptPodtyp { get; set; }

    public int IcenptDefiniowalnyId { get; set; }

    public int IcenptParamEwidId { get; set; }

    public bool IcenptUzyjCennikaRoz { get; set; }

    public int IcenptCzasOtwarciaDokum { get; set; }

    public int IcenptTrybWyboruCennika { get; set; }

    public bool IcenptCennikDowolnaWaluta { get; set; }
}
