using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPanstwo
{
    public int PaId { get; set; }

    public string PaNazwa { get; set; } = null!;

    public string PaKodPanstwaUe { get; set; } = null!;

    public bool PaCzlonekUe { get; set; }

    public string? PaKodPanstwaIso { get; set; }

    public virtual ICollection<AdrEwid> AdrEwids { get; set; } = new List<AdrEwid>();

    public virtual ICollection<DokDokument> DokDokumentDokIdPanstwaKonsumentaNavigations { get; set; } = new List<DokDokument>();

    public virtual ICollection<DokDokument> DokDokumentDokIdPanstwaRozpoczeciaWysylkiNavigations { get; set; } = new List<DokDokument>();

    public virtual ICollection<KhParametr> KhParametrs { get; set; } = new List<KhParametr>();

    public virtual ICollection<KprKsiega> KprKsiegas { get; set; } = new List<KprKsiega>();

    public virtual ICollection<OssEwid> OssEwidOeIdPanstwaKonsumpcjiNavigations { get; set; } = new List<OssEwid>();

    public virtual ICollection<OssEwid> OssEwidOeIdPanstwaRozpWysylkiNavigations { get; set; } = new List<OssEwid>();

    public virtual ICollection<PrzPrzychod> PrzPrzychods { get; set; } = new List<PrzPrzychod>();

    public virtual ICollection<SlEwidVatOss> SlEwidVatOssEvoIdPanstwaKonsumpcjiNavigations { get; set; } = new List<SlEwidVatOss>();

    public virtual ICollection<SlEwidVatOss> SlEwidVatOssEvoIdPanstwaWysylkiNavigations { get; set; } = new List<SlEwidVatOss>();

    public virtual ICollection<SlObywatelstwo> SlObywatelstwos { get; set; } = new List<SlObywatelstwo>();

    public virtual ICollection<SlPanstwaMiejscaProwadzeniaDzialalnosci> SlPanstwaMiejscaProwadzeniaDzialalnoscis { get; set; } = new List<SlPanstwaMiejscaProwadzeniaDzialalnosci>();

    public virtual ICollection<SlStawkaVat> SlStawkaVats { get; set; } = new List<SlStawkaVat>();
}
