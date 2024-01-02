using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzWyciagBankowy
{
    public int WbId { get; set; }

    public int WbIdRachunku { get; set; }

    public int? WbProgram { get; set; }

    public int WbIdUtworzyl { get; set; }

    public string WbNr { get; set; } = null!;

    public bool WbZatwierdzony { get; set; }

    public int? WbIdZatwierdzil { get; set; }

    public DateTime? WbDataZatwierdzenia { get; set; }

    public int WbStatusKsiegowy { get; set; }

    public DateTime WbData { get; set; }

    public DateTime WbOkresOd { get; set; }

    public DateTime WbOkresDo { get; set; }

    public int? WbIdKategorii { get; set; }

    public string WbUwagi { get; set; } = null!;

    public decimal WbSaldoPoczatkowe { get; set; }

    public decimal WbSaldoKoncowe { get; set; }

    public int? WbIdWyciaguHb { get; set; }

    public virtual ICollection<NzWyciagBankowyOperacjaBankowa> NzWyciagBankowyOperacjaBankowas { get; set; } = new List<NzWyciagBankowyOperacjaBankowa>();

    public virtual SlKategorium? WbIdKategoriiNavigation { get; set; }

    public virtual RbRachBankowy WbIdRachunkuNavigation { get; set; } = null!;

    public virtual PdUzytkownik WbIdUtworzylNavigation { get; set; } = null!;

    public virtual HbNaglowekIstopka? WbIdWyciaguHbNavigation { get; set; }

    public virtual PdUzytkownik? WbIdZatwierdzilNavigation { get; set; }
}
