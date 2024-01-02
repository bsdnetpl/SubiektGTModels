using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyPrzelewParam
{
    public int WppId { get; set; }

    public string WppDrukarka { get; set; } = null!;

    public bool WppAuto { get; set; }

    public string WppCzcionka { get; set; } = null!;

    public byte WppCzcionkaGrupa { get; set; }

    public short WppCzcionkaRozmiar { get; set; }

    public string WppOgranicznik { get; set; } = null!;

    public bool WppPokazujParametry { get; set; }

    public byte WppStdForm { get; set; }

    public byte WppStdFormOryg { get; set; }

    public bool WppStdDrukujSymbol { get; set; }

    public bool WppStdDopasuj { get; set; }

    public short WppStdPrzesuniecieX { get; set; }

    public short WppStdPrzesuniecieY { get; set; }

    public short WppStdSkalaX { get; set; }

    public short WppStdSkalaY { get; set; }

    public bool WppStdDrukujNaOryg { get; set; }

    public bool WppStdNieDrukujDaty { get; set; }

    public bool WppStdDrukujTypOperacji { get; set; }

    public byte WppZusForm { get; set; }

    public byte WppZusFormOryg { get; set; }

    public bool WppZusDrukujSymbol { get; set; }

    public bool WppZusDopasuj { get; set; }

    public short WppZusPrzesuniecieX { get; set; }

    public short WppZusPrzesuniecieY { get; set; }

    public short WppZusSkalaX { get; set; }

    public short WppZusSkalaY { get; set; }

    public bool WppZusDrukujNaOryg { get; set; }

    public bool WppZusNieDrukujNumeruRachunku { get; set; }

    public byte WppUsForm { get; set; }

    public byte WppUsFormOryg { get; set; }

    public bool WppUsDrukujSymbol { get; set; }

    public bool WppUsDopasuj { get; set; }

    public short WppUsPrzesuniecieX { get; set; }

    public short WppUsPrzesuniecieY { get; set; }

    public short WppUsSkalaX { get; set; }

    public short WppUsSkalaY { get; set; }

    public bool WppUsDrukujNaOryg { get; set; }

    public bool WppUsDrukujTypOperacji { get; set; }

    public bool WppUsNieDrukujDaty { get; set; }

    public bool WppZusDrukujTylkoCyfryOkRodzSkladek { get; set; }
}
