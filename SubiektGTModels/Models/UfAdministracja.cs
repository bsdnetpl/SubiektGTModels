using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfAdministracja
{
    public int UadId { get; set; }

    public bool UadZapisTransmisji { get; set; }

    public bool UadCzyRtdni { get; set; }

    public int UadRtdni { get; set; }

    public bool UadCzyRtliczba { get; set; }

    public int UadRtliczba { get; set; }

    public bool UadCzySynchronizacja { get; set; }

    public int UadUsuwanieOperacji { get; set; }

    public int UadCzyszczenieKolejki { get; set; }
}
