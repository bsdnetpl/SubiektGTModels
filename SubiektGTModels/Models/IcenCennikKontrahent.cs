using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IcenCennikKontrahent
{
    public int IcenkId { get; set; }

    public int IcenkCennikId { get; set; }

    public int IcenkKhId { get; set; }

    public virtual IcenCennikiIndywidualne IcenkCennik { get; set; } = null!;

    public virtual KhKontrahent IcenkKh { get; set; } = null!;
}
