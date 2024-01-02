using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbParametr
{
    public int GpId { get; set; }

    public int? GpRokStartu { get; set; }

    public DateTime? GpMcPierwszejWyplaty { get; set; }

    public int GpZasilkiWyplaca { get; set; }

    public int GpDzienPrzekazaniaSkladek { get; set; }

    public bool GpBlokujOperBankoweWsubiekcie { get; set; }

    public bool GpPrzeliczajSkladkiZus { get; set; }

    public int GpMiesSkladStale { get; set; }

    public int GpMiesSkladZmienne { get; set; }

    public int GpDofinansowanieSkladek { get; set; }

    public bool GpZaokraglanieSkladkiZdr { get; set; }

    public bool GpWysylajNrDowodu { get; set; }

    public int GpLiczbaUbezpieczonych { get; set; }

    public bool GpNaliczajNieobecnosciPlatne { get; set; }

    public bool GpNieNaliczajFpfgsp { get; set; }

    public int GpLimitWiekuFpfgspkobiet { get; set; }

    public int GpLimitWiekuFpfgspmezczyzn { get; set; }

    public bool GpUwzgledniajKosztyIulge { get; set; }

    public bool GpKosztyIpodOdZasRachunki { get; set; }

    public bool GpNieUwzglUlgPodPoZwoln { get; set; }

    public int GpWersjaPlatnika { get; set; }

    public bool GpNieUzupPodstChorUcznia { get; set; }

    public int GpRodzajUbezpieczenia { get; set; }

    public bool GpBlokujWydrukUjemnejWyplaty { get; set; }

    public bool GpZ3bezEdycji { get; set; }

    public bool GpOgraniczenieSklZdrOdZalNaPodatek { get; set; }

    public bool GpKupPoZwolnieniu { get; set; }

    public DateTime? GpKreatorKorektNowyLadPrzypominaj { get; set; }
}
