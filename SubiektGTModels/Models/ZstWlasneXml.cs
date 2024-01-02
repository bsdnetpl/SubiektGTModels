using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZstWlasneXml
{
    public int ZstxId { get; set; }

    public int ZstxZestId { get; set; }

    public string ZstxDefSciezka { get; set; } = null!;

    public byte[] ZstxDefinicja { get; set; } = null!;

    public string ZstxTranSciezka { get; set; } = null!;

    public byte[] ZstxTransformacja { get; set; } = null!;

    public bool ZstxZapiszWynikXml { get; set; }

    public string ZstxPlikWynikXml { get; set; } = null!;

    public bool ZstxZapiszWynikHtm { get; set; }

    public string ZstxPlikWynikHtm { get; set; } = null!;

    public virtual ZstEwid ZstxZest { get; set; } = null!;
}
