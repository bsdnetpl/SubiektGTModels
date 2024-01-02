using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IntParametryIntrastat
{
    public int IntpId { get; set; }

    public int IntpParamEwidId { get; set; }

    public int IntpZrodloOpisuTowaru { get; set; }

    public int IntpDokumentySkutekMagazynowyW { get; set; }

    public int IntpDokumentySkutekMagazynowyP { get; set; }

    public int IntpDokumentyTypDaty { get; set; }

    public virtual ParEwid IntpParamEwid { get; set; } = null!;
}
