using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfZadanie
{
    public int UzaId { get; set; }

    public int UzaIdOperacja { get; set; }

    public int UzaIdKonfiguracja { get; set; }

    public int UzaIdUzytkownik { get; set; }

    public int? UzaIdTransmisja { get; set; }

    public int UzaLp { get; set; }

    public DateTime UzaDataCzas { get; set; }

    public int UzaStatus { get; set; }

    public string UzaNazwa { get; set; } = null!;

    public int UzaTyp { get; set; }

    public byte[]? UzaParametry { get; set; }

    public virtual ICollection<UfSynchronizacja> UfSynchronizacjas { get; set; } = new List<UfSynchronizacja>();

    public virtual UfKonfiguracja UzaIdKonfiguracjaNavigation { get; set; } = null!;

    public virtual UfOperacja UzaIdOperacjaNavigation { get; set; } = null!;

    public virtual UfTransmisja? UzaIdTransmisjaNavigation { get; set; }

    public virtual PdUzytkownik UzaIdUzytkownikNavigation { get; set; } = null!;
}
