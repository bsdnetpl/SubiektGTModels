using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrnaliczeniaPotracenium
{
    public int Ident { get; set; }

    public int Status { get; set; }

    public int Typ { get; set; }

    public DateTime Data { get; set; }

    public string? Pracownik { get; set; }

    public string? Umowa { get; set; }

    public string Skladnik { get; set; } = null!;

    public string SkladnikNazwaNaLisciePlac { get; set; } = null!;

    public bool SkladnikOpodotkowany { get; set; }

    public bool SkladnikDoPodstEmRe { get; set; }

    public bool SkladnikDoPodstChWy { get; set; }

    public bool SkladnikDoPodstZdr { get; set; }

    public decimal Kwota { get; set; }

    public string? DokumentRozliczajacy { get; set; }

    public int Sposob { get; set; }

    public string Opis { get; set; } = null!;

    public int? IdPracownika { get; set; }
}
