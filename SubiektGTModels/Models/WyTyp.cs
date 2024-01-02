using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyTyp
{
    public int WtpId { get; set; }

    public string WtpNazwa { get; set; } = null!;

    public int WtpGrupaId { get; set; }

    public virtual ICollection<WyWzorzec> WyWzorzecs { get; set; } = new List<WyWzorzec>();
}
