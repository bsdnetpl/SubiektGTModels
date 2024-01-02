using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbUsluga
{
    public int HbuId { get; set; }

    public int HbuBank { get; set; }

    public string HbuNazwa { get; set; } = null!;

    public string HbuIdentyfikatorKlienta { get; set; } = null!;

    public string HbuCertyfikatSerwera { get; set; } = null!;

    public virtual ICollection<HbPrzedrostekHist> HbPrzedrostekHists { get; set; } = new List<HbPrzedrostekHist>();

    public virtual ICollection<RbRachBankowy> RbRachBankowies { get; set; } = new List<RbRachBankowy>();
}
