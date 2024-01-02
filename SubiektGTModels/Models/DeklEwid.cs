using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklEwid
{
    public int DeId { get; set; }

    public int DeIdWzorca { get; set; }

    public int DeTypObiektu { get; set; }

    public int? DeIdObiektu { get; set; }

    public string DeNazwaObiektu { get; set; } = null!;

    public DateTime DeOkresOd { get; set; }

    public DateTime DeOkresDo { get; set; }

    public string DeOkres { get; set; } = null!;

    public DateTime DeDataAktualizacji { get; set; }

    public decimal? DeDoZaplaty { get; set; }

    public bool? DeKorekta { get; set; }

    public int? DeIdDeklGlownej { get; set; }

    public bool? DeCzyGlownyZal { get; set; }

    public bool? DeZmienionoWpisUe { get; set; }

    public int? DeIdNaliczeniaPpk { get; set; }

    public int? DeIdOperacjiBankowej { get; set; }

    public decimal? DeNadwyzka { get; set; }

    public decimal? DeDoPrzeniesienia { get; set; }

    public bool DeWyeksportowanoDoPliku { get; set; }

    public string? DeNumerUmowy { get; set; }

    public bool DeCzyExportowac { get; set; }

    public decimal? DePdstSkladkiZdrowotnej { get; set; }

    public bool DeCzyWystapilyBledy { get; set; }

    public bool? DeWersjaRobocza { get; set; }

    public decimal? DeDochodPrzychodPdstSklZdr { get; set; }

    public string DeDla { get; set; } = null!;

    public virtual DekpNaliczenie? DeIdNaliczeniaPpkNavigation { get; set; }

    public virtual ICollection<DeklCukierDokument> DeklCukierDokuments { get; set; } = new List<DeklCukierDokument>();

    public virtual ICollection<DeklDeklViudo> DeklDeklViudos { get; set; } = new List<DeklDeklViudo>();

    public virtual ICollection<DeklEDekl> DeklEDekls { get; set; } = new List<DeklEDekl>();

    public virtual ICollection<DeklIntrastatPole> DeklIntrastatPoles { get; set; } = new List<DeklIntrastatPole>();

    public virtual ICollection<DeklJpkV7pole> DeklJpkV7poles { get; set; } = new List<DeklJpkV7pole>();

    public virtual ICollection<DeklPfron> DeklPfrons { get; set; } = new List<DeklPfron>();

    public virtual ICollection<DeklPitZdPole> DeklPitZdPoles { get; set; } = new List<DeklPitZdPole>();

    public virtual ICollection<DeklPoleViudo> DeklPoleViudos { get; set; } = new List<DeklPoleViudo>();

    public virtual ICollection<DeklPole> DeklPoles { get; set; } = new List<DeklPole>();

    public virtual ICollection<DeklVatUePole> DeklVatUePoles { get; set; } = new List<DeklVatUePole>();

    public virtual ICollection<DeklVatZdPole> DeklVatZdPoles { get; set; } = new List<DeklVatZdPole>();

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();

    public virtual ICollection<PrParametryWplatPpk> PrParametryWplatPpks { get; set; } = new List<PrParametryWplatPpk>();

    public virtual ICollection<PrPpk> PrPpks { get; set; } = new List<PrPpk>();

    public virtual ICollection<PrRezygnacjaPpk> PrRezygnacjaPpks { get; set; } = new List<PrRezygnacjaPpk>();
}
