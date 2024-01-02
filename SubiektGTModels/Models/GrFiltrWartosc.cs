using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrFiltrWartosc
{
    public int GrwId { get; set; }

    public int GrwIdFiltra { get; set; }

    public int GrwIdUzytkownika { get; set; }

    public string GrwProfil { get; set; } = null!;

    public byte[] GrwWartosc { get; set; } = null!;
}
