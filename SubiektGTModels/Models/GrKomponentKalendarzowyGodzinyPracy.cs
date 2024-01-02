using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrKomponentKalendarzowyGodzinyPracy
{
    public int GrgpId { get; set; }

    public int GrgpIdGrida { get; set; }

    public int GrgpGodzinaPoczatkowa { get; set; }

    public int GrgpGodzinaKoncowa { get; set; }

    public virtual GrGrid GrgpIdGridaNavigation { get; set; } = null!;
}
