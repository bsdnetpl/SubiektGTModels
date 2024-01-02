using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZwZdarzenieWindykacyjne
{
    public int ZwzId { get; set; }

    public int ZwzIdDluznika { get; set; }

    public int ZwzTypDluznika { get; set; }

    public DateTime ZwzOdsetkiNaDzien { get; set; }

    public decimal ZwzWartoscNaleznosci { get; set; }

    public decimal ZwzWartoscOdsetek { get; set; }

    public string? ZwzOpisWezwania { get; set; }

    public int ZwzTypWezwania { get; set; }

    public DateTime ZwzDataWystawieniaWezwania { get; set; }

    public DateTime ZwzTerminPlatnosci { get; set; }

    public int ZwzIdRachunekBankowy { get; set; }

    public int ZwzIdWystawil { get; set; }

    public string ZwzWaluta { get; set; } = null!;

    public int? ZwzIdHistAdr { get; set; }

    public virtual ICollection<ZdZadanie> ZdZadanies { get; set; } = new List<ZdZadanie>();

    public virtual ICollection<ZwRozrachunek> ZwRozrachuneks { get; set; } = new List<ZwRozrachunek>();

    public virtual RbRachBankowy ZwzIdRachunekBankowyNavigation { get; set; } = null!;

    public virtual PdUzytkownik ZwzIdWystawilNavigation { get; set; } = null!;

    public virtual SlFormaDzialaniaWindykacyjnego ZwzTypWezwaniaNavigation { get; set; } = null!;
}
