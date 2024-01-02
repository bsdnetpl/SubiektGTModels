using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrUprawnienium
{
    public int PupId { get; set; }

    public int PupIdPracownika { get; set; }

    public int PupIdUprawnienia { get; set; }

    public DateTime? PupDataUzyskania { get; set; }

    public DateTime? PupDataWaznosci { get; set; }

    public virtual PrPracownik PupIdPracownikaNavigation { get; set; } = null!;

    public virtual SlUprawnienie PupIdUprawnieniaNavigation { get; set; } = null!;
}
