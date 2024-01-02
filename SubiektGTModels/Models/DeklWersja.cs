using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklWersja
{
    public int DwId { get; set; }

    public string DwDeklNazwa { get; set; } = null!;

    public string DwOpis { get; set; } = null!;

    public bool DwNarastajaca { get; set; }

    public bool DwStandard { get; set; }

    public int DwTypOkresu { get; set; }

    public int DwTypDla { get; set; }

    public int DwProgramy { get; set; }

    public int DwWersjaOryg { get; set; }

    public int DwWersja { get; set; }

    public DateTime? DwWaznaOd { get; set; }

    public DateTime? DwWaznaDo { get; set; }

    public int DwStrony { get; set; }

    public string DwWersjaOd { get; set; } = null!;

    public int DwPoleDoPrzelewu { get; set; }

    public int DwPoleKorekta { get; set; }

    public bool DwZalacznik { get; set; }

    public byte[]? DwDefinicja { get; set; }

    public byte[]? DwDefinicjaDef { get; set; }

    public byte[]? DwWydrukStr01 { get; set; }

    public byte[]? DwWydrukStr02 { get; set; }

    public byte[]? DwWydrukStr03 { get; set; }

    public byte[]? DwWydrukStr04 { get; set; }

    public byte[]? DwWydrukStr05 { get; set; }

    public byte[]? DwWydrukStr06 { get; set; }

    public byte[]? DwWydrukStr07 { get; set; }

    public byte[]? DwWydrukStr08 { get; set; }

    public byte[]? DwWydrukStr09 { get; set; }

    public byte[]? DwWydrukStr10 { get; set; }

    public bool DwWidocznosc { get; set; }

    public int DwPoleOperatorImie { get; set; }

    public int DwPoleOperatorNazwisko { get; set; }

    public int? DwPrzeliczPolaDeklaracji { get; set; }

    public bool DwObslugaPodpDaneAutoryzujace { get; set; }

    public int? DwPoleDoDaneAutoryzujace { get; set; }

    public int? DwPoleStatusDok { get; set; }

    public bool DwNowyWydruk { get; set; }

    public int DwPoleNadplata { get; set; }

    public int DwPoleDoPrzeniesienia { get; set; }

    public int DwTypDeklaracji { get; set; }

    public int DwPolePdstSkladkiZdrowotnej { get; set; }

    public int DwPolePrzychod { get; set; }

    public int DwPoleDochodZaPoprzMiesiac { get; set; }

    public int DwPoleWartoscZaliczki { get; set; }

    public int DwPoleDochodZaMiesiac { get; set; }

    public int DwPoleRocznaKwotaDochodu { get; set; }

    public int DwPoleRocznaKwotaPodatkuNaleznego { get; set; }

    public int DwPoleRocznaPodstawaSkladkiZdrowotnej { get; set; }

    public int DwPoleRocznaSkladkaZdrowotna { get; set; }

    public int DwPoleSumaMiesiecznychNaleznychZaliczek { get; set; }
}
