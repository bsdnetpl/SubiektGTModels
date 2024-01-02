using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWojewodztwo
{
    public int WojId { get; set; }

    public string WojNazwa { get; set; } = null!;

    public virtual ICollection<AdrEwid> AdrEwids { get; set; } = new List<AdrEwid>();

    public virtual ICollection<KhParametr> KhParametrs { get; set; } = new List<KhParametr>();
}
