using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NkZrodloDanych
{
    public int NzrId { get; set; }

    public string NzrNazwa { get; set; } = null!;

    public string NzrSelect { get; set; } = null!;

    public string NzrWidoczne { get; set; } = null!;

    public bool NzrSubiekt { get; set; }

    public bool NzrRewizor { get; set; }

    public bool NzrRachmistrz { get; set; }

    public bool NzrGratyfikant { get; set; }

    public bool NzrGestor { get; set; }

    public string NzrOrderBy { get; set; } = null!;

    public string NzrSort { get; set; } = null!;

    public virtual ICollection<NkSzablon> NkSzablons { get; set; } = new List<NkSzablon>();

    public virtual ICollection<NkZestawDanych> NkZestawDanyches { get; set; } = new List<NkZestawDanych>();
}
