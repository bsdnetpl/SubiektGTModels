using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzRozDekret
{
    public int NzdIdDekretu { get; set; }

    public int NzdIdRozrachunku { get; set; }

    public int NzdIdRoku { get; set; }

    public int NzdStatus { get; set; }

    public bool? NzdPomniejsza { get; set; }

    public virtual DkrPozycja NzdIdDekretuNavigation { get; set; } = null!;

    public virtual NzFinanse NzdIdRozrachunkuNavigation { get; set; } = null!;
}
