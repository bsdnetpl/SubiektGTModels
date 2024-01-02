using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikSwiadczenie
{
    public int PwwId { get; set; }

    public int PwwIdWspolnika { get; set; }

    public DateTime PwwMiesiac { get; set; }

    public DateTime PwwDataOd { get; set; }

    public DateTime PwwDataDo { get; set; }

    public int PwwLiczbaDni { get; set; }

    public string PwwKodSwiadczenia { get; set; } = null!;

    public string PwwKodChoroby { get; set; } = null!;

    public decimal PwwKwota { get; set; }

    public virtual PdWspolnik PwwIdWspolnikaNavigation { get; set; } = null!;

    public virtual SlKodSwiadczenium PwwKodSwiadczeniaNavigation { get; set; } = null!;
}
