using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Sf2Skrypt
{
    public int Sf2sId { get; set; }

    public byte[] Sf2sStrumien { get; set; } = null!;

    public int Sf2sIdKomponentu { get; set; }

    public virtual Sf2KomponentSferyczny Sf2sIdKomponentuNavigation { get; set; } = null!;
}
