using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbEcpParametr
{
    public int EcppId { get; set; }

    public decimal EcppNocneProcent { get; set; }

    public int EcppNocneJak { get; set; }

    public decimal EcppNadliczboweProcent { get; set; }

    public decimal EcppNadliczboweNocneProcent { get; set; }

    public decimal EcppNadliczboweWolneProcent { get; set; }

    public int EcppNadliczboweWolneJak { get; set; }

    public decimal EcppNadliczboweSwiateczneProcent { get; set; }

    public int EcppNadliczboweSwiateczneJak { get; set; }

    public bool EcppDniWolneDoUrlopowego { get; set; }

    public int EcppNadliczboweSkladnik { get; set; }

    public int EcppPotracenieChor { get; set; }

    public int EcppZaokrZasilkow { get; set; }

    public int EcppZaokrWynChor { get; set; }

    public int EcppLiczbaDniWynChor { get; set; }

    public int EcppNadliczboweGodziny { get; set; }

    public decimal EcppNadliczbowePierwszeProcent { get; set; }

    public int EcppLiczbaDniWynChorPoLatach { get; set; }

    public int EcppWiekPracDniWynChorPoLatach { get; set; }

    public bool EcppUzupPrzeprDzien { get; set; }

    public bool EcppZerujWynGdyMcNieobecnosci { get; set; }

    public bool EcppGodzinyPonadwymiarowe { get; set; }

    public int EcppNocneZrodloGodzin { get; set; }

    public int EcppNieprzepracowaneZrodloGodzin { get; set; }
}
