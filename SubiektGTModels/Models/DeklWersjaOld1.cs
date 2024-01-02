using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklWersjaOld1
{
    public int Dwo1Id { get; set; }

    public string Dwo1DeklNazwa { get; set; } = null!;

    public string Dwo1Opis { get; set; } = null!;

    public bool Dwo1Narastajaca { get; set; }

    public bool Dwo1Standard { get; set; }

    public int Dwo1TypOkresu { get; set; }

    public int Dwo1TypDla { get; set; }

    public int Dwo1Programy { get; set; }

    public int Dwo1WersjaOryg { get; set; }

    public int Dwo1Wersja { get; set; }

    public DateTime? Dwo1WaznaOd { get; set; }

    public DateTime? Dwo1WaznaDo { get; set; }

    public int Dwo1Strony { get; set; }

    public string Dwo1WersjaOd { get; set; } = null!;

    public int Dwo1PoleDoPrzelewu { get; set; }

    public int Dwo1PoleKorekta { get; set; }

    public bool Dwo1Zalacznik { get; set; }

    public byte[]? Dwo1Definicja { get; set; }

    public byte[]? Dwo1DefinicjaDef { get; set; }

    public byte[]? Dwo1WydrukStr01 { get; set; }

    public byte[]? Dwo1WydrukStr02 { get; set; }

    public byte[]? Dwo1WydrukStr03 { get; set; }

    public byte[]? Dwo1WydrukStr04 { get; set; }

    public byte[]? Dwo1WydrukStr05 { get; set; }

    public byte[]? Dwo1WydrukStr06 { get; set; }

    public byte[]? Dwo1WydrukStr07 { get; set; }

    public byte[]? Dwo1WydrukStr08 { get; set; }

    public byte[]? Dwo1WydrukStr09 { get; set; }

    public byte[]? Dwo1WydrukStr10 { get; set; }

    public bool Dwo1Widocznosc { get; set; }

    public int Dwo1PoleOperatorImie { get; set; }

    public int Dwo1PoleOperatorNazwisko { get; set; }

    public int? Dwo1PrzeliczPolaDeklaracji { get; set; }

    public bool Dwo1ObslugaPodpDaneAutoryzujace { get; set; }

    public int? Dwo1PoleDoDaneAutoryzujace { get; set; }

    public int? Dwo1PoleStatusDok { get; set; }

    public bool Dwo1NowyWydruk { get; set; }

    public int Dwo1PoleNadplata { get; set; }

    public int Dwo1PoleDoPrzeniesienia { get; set; }

    public int Dwo1TypDeklaracji { get; set; }
}
