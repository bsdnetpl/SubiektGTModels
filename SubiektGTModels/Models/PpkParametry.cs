using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PpkParametry
{
    public int PpkpId { get; set; }

    public bool PpkpUczestnictwo { get; set; }

    public int? PpkpIdInstytucji { get; set; }

    public int PpkpSposobGenerowaniaPlikowDoWysylki { get; set; }

    public int PpkpMiesiacWplaty { get; set; }

    public int PpkpDzienWplaty { get; set; }

    public virtual IsInstytucja? PpkpIdInstytucjiNavigation { get; set; }
}
