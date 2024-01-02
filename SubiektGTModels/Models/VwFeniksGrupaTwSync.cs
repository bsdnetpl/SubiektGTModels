using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFeniksGrupaTwSync
{
    public int SubiektId { get; set; }

    public int? MultiStoreId { get; set; }

    public byte StateId { get; set; }

    public int GrtId { get; set; }

    public string GrtNazwa { get; set; } = null!;

    public string? GrtNrAnalityka { get; set; }
}
