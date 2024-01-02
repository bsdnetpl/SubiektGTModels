using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikUlgiPit0
{
    public int PwupId { get; set; }

    public int PwupIdWspolnika { get; set; }

    public DateTime PwupDataOd { get; set; }

    public DateTime? PwupDataDo { get; set; }

    public bool PwupDataKoncowaNieznana { get; set; }

    public bool PwupUlgaRodzina4Plus { get; set; }

    public bool PwupUlgaDlaSeniora { get; set; }

    public bool PwupUlgaNaPowrot { get; set; }

    public bool? PwupKsiegowane { get; set; }

    public virtual PdWspolnik PwupIdWspolnikaNavigation { get; set; } = null!;
}
