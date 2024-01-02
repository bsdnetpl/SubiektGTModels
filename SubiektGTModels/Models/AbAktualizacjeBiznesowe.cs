using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class AbAktualizacjeBiznesowe
{
    public int AbId { get; set; }

    public int AbKursyWalutTyp { get; set; }

    public DateTime? AbKursyWalutHarmonogram { get; set; }

    public string? AbKursyWalutStanowisko1 { get; set; }

    public string? AbKursyWalutStanowisko2 { get; set; }

    public string? AbKursyWalutStanowisko3 { get; set; }

    public int AbParamPodatkTyp { get; set; }

    public DateTime? AbParamPodatkHarmonogram { get; set; }

    public string? AbParamPodatkStanowisko1 { get; set; }

    public string? AbParamPodatkStanowisko2 { get; set; }

    public string? AbParamPodatkStanowisko3 { get; set; }

    public int AbKursyWalutEbctyp { get; set; }

    public DateTime? AbKursyWalutEbcharmonogram { get; set; }

    public string? AbKursyWalutEbcstanowisko1 { get; set; }

    public string? AbKursyWalutEbcstanowisko2 { get; set; }

    public string? AbKursyWalutEbcstanowisko3 { get; set; }
}
