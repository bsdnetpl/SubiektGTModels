using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class BibZawartoscPliku
{
    public int BipId { get; set; }

    public int BipIdDokumentu { get; set; }

    public byte[]? BipZawartosc { get; set; }

    public string? BipTyp { get; set; }
}
