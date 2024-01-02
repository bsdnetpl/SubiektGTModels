using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrFormatowanieWarunek
{
    public int GrfwwId { get; set; }

    public int GrfwwIdFormatowania { get; set; }

    public string GrfwwKolumnaNazwa { get; set; } = null!;

    public string GrfwwKolumnaPole { get; set; } = null!;

    public int GrfwwWarunek { get; set; }

    public string GrfwwWartosc { get; set; } = null!;

    public int GrfwwOperator { get; set; }

    public virtual GrFormatowanie GrfwwIdFormatowaniaNavigation { get; set; } = null!;
}
