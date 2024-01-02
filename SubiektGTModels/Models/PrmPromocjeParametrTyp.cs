using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrmPromocjeParametrTyp
{
    public int PrmptId { get; set; }

    public int PrmptTyp { get; set; }

    public int PrmptPodtyp { get; set; }

    public int PrmptDefiniowalnyId { get; set; }

    public int PrmptParamEwidId { get; set; }

    public bool PrmptUzyjPromocjiRoz { get; set; }

    public int PrmptTryb { get; set; }

    public bool PrmptZezwalajWycofac { get; set; }

    public bool PrmptZezwalajPrzenosic { get; set; }

    public bool PrmptZezwalajSprawdzac { get; set; }

    public int PrmptCzasOtwarciaDokum { get; set; }
}
