using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfSterownik
{
    public int UstId { get; set; }

    public int UstTyp { get; set; }

    public string UstNazwa { get; set; } = null!;

    public string UstWersja { get; set; } = null!;

    public string UstAboutClsid { get; set; } = null!;

    public string UstDriverClsid { get; set; } = null!;

    public string UstDialogClsid { get; set; } = null!;

    public string UstStanowisko { get; set; } = null!;

    public virtual ICollection<UfUrzadzenie> UfUrzadzenies { get; set; } = new List<UfUrzadzenie>();
}
