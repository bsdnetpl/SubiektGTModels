using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrZdjecie
{
    public int PzdId { get; set; }

    public int PzdPracownikId { get; set; }

    public byte[] PzdZdjecie { get; set; } = null!;

    public bool PzdGlowne { get; set; }

    public virtual PrPracownik PzdPracownik { get; set; } = null!;
}
