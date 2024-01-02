using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class Sf2KomponentSferyczny
{
    public int Sf2ksId { get; set; }

    public string Sf2ksGuid { get; set; } = null!;

    public string Sf2ksGuidBiblioteki { get; set; } = null!;

    public int Sf2ksObiekt { get; set; }

    public string Sf2ksNazwa { get; set; } = null!;

    public string Sf2ksOpis { get; set; } = null!;

    public string Sf2ksWersja { get; set; } = null!;

    public string Sf2ksProducentNazwa { get; set; } = null!;

    public string Sf2ksProducentWww { get; set; } = null!;

    public string Sf2ksProducentEmail { get; set; } = null!;

    public string Sf2ksProducentAdres { get; set; } = null!;

    public string Sf2ksProducentTelefon1 { get; set; } = null!;

    public string Sf2ksProducentTelefon2 { get; set; } = null!;

    public string Sf2ksProducentFax { get; set; } = null!;

    public int? Sf2ksIdRozszerzenia { get; set; }

    public int? Sf2ksTimer { get; set; }

    public string? Sf2ksGrid { get; set; }

    public int? Sf2ksIdDefinicji { get; set; }

    public virtual ICollection<Sf2OperacjaSferyczna> Sf2OperacjaSferycznas { get; set; } = new List<Sf2OperacjaSferyczna>();

    public virtual ICollection<Sf2Skrypt> Sf2Skrypts { get; set; } = new List<Sf2Skrypt>();
}
