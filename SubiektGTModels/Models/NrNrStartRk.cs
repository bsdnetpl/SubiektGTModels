using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NrNrStartRk
{
    public int NsrkId { get; set; }

    public int NsrkIdNrStart { get; set; }

    public int NsrkIdRoku { get; set; }

    public int NsrkIdRejestru { get; set; }

    public int? NsrkGranica { get; set; }

    public virtual NrNrStart NsrkIdNrStartNavigation { get; set; } = null!;

    public virtual SlRejestrKsiegowy NsrkIdRejestruNavigation { get; set; } = null!;
}
