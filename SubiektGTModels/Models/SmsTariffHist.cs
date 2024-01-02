using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SmsTariffHist
{
    public int SmstId { get; set; }

    public string SmstTariffName { get; set; } = null!;

    public bool SmstDiacriticsAllowed { get; set; }

    public short SmstMaxCharacters { get; set; }

    public short SmstMaxCharactersWithDiacritics { get; set; }

    public short SmstMaxParts { get; set; }

    public short SmstMaxPartsWithDiacritics { get; set; }

    public string? SmstSenderName { get; set; }

    public virtual ICollection<SmsMessage> SmsMessages { get; set; } = new List<SmsMessage>();
}
