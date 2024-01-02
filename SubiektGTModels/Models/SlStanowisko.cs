using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStanowisko
{
    public int StnId { get; set; }

    public string StnNazwa { get; set; } = null!;

    public int? StnKategoriaMin { get; set; }

    public int? StnKategoriaMax { get; set; }

    public virtual ICollection<PlbUmowaDzialStanowisko> PlbUmowaDzialStanowiskos { get; set; } = new List<PlbUmowaDzialStanowisko>();

    public virtual SlStawkaZaszeregowanium? StnKategoriaMaxNavigation { get; set; }

    public virtual SlStawkaZaszeregowanium? StnKategoriaMinNavigation { get; set; }
}
