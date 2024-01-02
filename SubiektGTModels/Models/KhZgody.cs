using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhZgody
{
    public int ZgId { get; set; }

    public int ZgIdObiektu { get; set; }

    public int ZgTypObiektu { get; set; }

    public int ZgIdCelu { get; set; }

    public int ZgStatus { get; set; }

    public DateTime? ZgDataZgody { get; set; }

    public DateTime? ZgDataWycofania { get; set; }

    public DateTime? ZgDataWygasniecia { get; set; }

    public int ZgStatusWyliczony { get; set; }

    public virtual CpCelPrzetwarzanium ZgIdCeluNavigation { get; set; } = null!;
}
