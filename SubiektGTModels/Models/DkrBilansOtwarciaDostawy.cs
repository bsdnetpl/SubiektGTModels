using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrBilansOtwarciaDostawy
{
    public int BorId { get; set; }

    public string? BorDokument { get; set; }

    public decimal BorKwota { get; set; }

    public decimal BorKurs { get; set; }

    public int BorLiczbaJednostek { get; set; }

    public int BorIdPozycji { get; set; }

    public int BorLp { get; set; }

    public int? BorIdPozycjiZrodlowej { get; set; }

    public int? BorIdPozycjiZrodlowejBo { get; set; }

    public virtual DkrBilansOtwarciaDostawy? BorIdPozycjiZrodlowejBoNavigation { get; set; }

    public virtual DkrPozycja? BorIdPozycjiZrodlowejNavigation { get; set; }

    public virtual ICollection<DkrBilansOtwarciaDostawy> InverseBorIdPozycjiZrodlowejBoNavigation { get; set; } = new List<DkrBilansOtwarciaDostawy>();
}
