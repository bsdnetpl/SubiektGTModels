using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FoZakladkaWlasnaPowiazanie
{
    public int FozpId { get; set; }

    public int FozpIdDefinicji { get; set; }

    public int FozpObiektTyp { get; set; }

    public int FozpObiektTypEx { get; set; }
}
