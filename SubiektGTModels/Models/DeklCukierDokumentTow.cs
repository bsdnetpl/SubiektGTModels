using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklCukierDokumentTow
{
    public int DcdpId { get; set; }

    public int DcdpIdCukierDokument { get; set; }

    public string DcdpNrPartiiTowaru { get; set; } = null!;
}
