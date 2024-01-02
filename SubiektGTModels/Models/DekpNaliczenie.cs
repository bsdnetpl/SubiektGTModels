using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DekpNaliczenie
{
    public int DpnId { get; set; }

    public int DpnTyp { get; set; }

    public DateTime? DpnMiesiac { get; set; }

    public DateTime DpnDataNaliczenia { get; set; }

    public string DpnOpis { get; set; } = null!;

    public int DpnStatusEksportu { get; set; }

    public virtual ICollection<DeklEwid> DeklEwids { get; set; } = new List<DeklEwid>();
}
