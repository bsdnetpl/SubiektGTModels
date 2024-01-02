using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokumentTechniczny
{
    public int DtPrzychodRozchodId { get; set; }

    public int DtPrzyjecieMagazynoweId { get; set; }

    public virtual DokDokument DtPrzychodRozchod { get; set; } = null!;

    public virtual DokDokument DtPrzyjecieMagazynowe { get; set; } = null!;
}
