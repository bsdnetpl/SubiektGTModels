using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOpisAbsencji
{
    public int OaId { get; set; }

    public string OaNazwa { get; set; } = null!;

    public virtual ICollection<EcpAbsencjaPrzedKorektum> EcpAbsencjaPrzedKorekta { get; set; } = new List<EcpAbsencjaPrzedKorektum>();

    public virtual ICollection<EcpAbsencja> EcpAbsencjas { get; set; } = new List<EcpAbsencja>();
}
