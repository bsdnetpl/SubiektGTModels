using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrFormatowanie
{
    public int GrfwId { get; set; }

    public string GrfwNazwa { get; set; } = null!;

    public string GrfwGrid { get; set; } = null!;

    public int GrfwIdModulu { get; set; }

    public byte[] GrfwFormatowanie { get; set; } = null!;

    public int GrfwKolejnosc { get; set; }

    public string? GrfwSqlWarunek { get; set; }

    public string? GrfwSqlTabele { get; set; }

    public virtual ICollection<GrFormatowanieWarunek> GrFormatowanieWaruneks { get; set; } = new List<GrFormatowanieWarunek>();
}
