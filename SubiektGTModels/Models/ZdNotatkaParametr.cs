using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdNotatkaParametr
{
    public int ZdnpId { get; set; }

    public int? ZdnpParamEwidId { get; set; }

    public int? ZdnpRodzaj { get; set; }

    public byte ZdnpData { get; set; }

    public byte ZdnpPersonel { get; set; }

    public byte ZdnpPriorytet { get; set; }

    public bool ZdnpPokazujWkalendarzu { get; set; }

    public string ZdnpKolor { get; set; } = null!;

    public int? ZdnpRodzajW { get; set; }

    public byte ZdnpDataW { get; set; }

    public byte ZdnpPersonelW { get; set; }

    public byte ZdnpPriorytetW { get; set; }

    public bool ZdnpPokazujWkalendarzuW { get; set; }

    public string ZdnpKolorW { get; set; } = null!;

    public int ZdnpFormaW { get; set; }

    public bool ZdnpKotwicz { get; set; }

    public bool ZdnpKotwiczW { get; set; }
}
