using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ApAp
{
    public int ApId { get; set; }

    public bool ApZablokowany { get; set; }

    public string ApNazwa { get; set; } = null!;

    public int ApIdRejestruKsiegowego { get; set; }

    public int ApTrybBilansowaniaDekretu { get; set; }

    public int ApTypDatyDokumentu { get; set; }

    public int ApTypDatyDekretacji { get; set; }

    public int ApTypDatyOperacji { get; set; }

    public int ApTypOpisuDekretu { get; set; }

    public string ApUOpisDekretu { get; set; } = null!;

    public int? ApSlIdOpisuDekretu { get; set; }

    public int ApTrybAutobilansowaniaDekretu { get; set; }

    public string ApKontoKorekty { get; set; } = null!;

    public virtual ICollection<ApLog> ApLogs { get; set; } = new List<ApLog>();

    public virtual SlOpi? ApSlIdOpisuDekretuNavigation { get; set; }

    public virtual ICollection<ApZapisy> ApZapisies { get; set; } = new List<ApZapisy>();
}
