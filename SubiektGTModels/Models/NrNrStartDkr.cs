using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NrNrStartDkr
{
    public int NsdId { get; set; }

    public int? NsdRok { get; set; }

    public int? NsdMiesiac { get; set; }

    public int NsdIdRoku { get; set; }

    public int NsdIdRejestru { get; set; }

    public int NsdGranica { get; set; }

    public virtual SlRejestrKsiegowy NsdIdRejestruNavigation { get; set; } = null!;

    public virtual NrParametrDkr NsdIdRokuNavigation { get; set; } = null!;
}
