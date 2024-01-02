using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiZasob
{
    public int UizId { get; set; }

    public string? UizTyp { get; set; }

    public byte[] UizDane { get; set; } = null!;
}
