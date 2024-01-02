using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWalutaBank
{
    public int WbnId { get; set; }

    public string WbnNazwa { get; set; } = null!;

    public bool WbnPodstawowy { get; set; }

    public virtual ICollection<DkrDokument> DkrDokuments { get; set; } = new List<DkrDokument>();

    public virtual ICollection<DkrPozycja> DkrPozycjas { get; set; } = new List<DkrPozycja>();

    public virtual ICollection<NzFinanse> NzFinanses { get; set; } = new List<NzFinanse>();

    public virtual ICollection<OssEwid> OssEwidOeIdBankuDeklaracjaVatNavigations { get; set; } = new List<OssEwid>();

    public virtual ICollection<OssEwid> OssEwidOeIdBankuKsiegowanieNavigations { get; set; } = new List<OssEwid>();

    public virtual ICollection<SlWalutaTabelaKursow> SlWalutaTabelaKursows { get; set; } = new List<SlWalutaTabelaKursow>();

    public virtual ICollection<VatParametr> VatParametrs { get; set; } = new List<VatParametr>();
}
