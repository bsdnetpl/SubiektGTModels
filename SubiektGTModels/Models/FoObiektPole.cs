using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FoObiektPole
{
    public int FopId { get; set; }

    public int FopIdZakladki { get; set; }

    public string FopNazwa { get; set; } = null!;

    public string FopNazwaOkno { get; set; } = null!;

    public string FopNazwaGrid { get; set; } = null!;

    public int FopTyp { get; set; }

    public int FopKolejnosc { get; set; }

    public string FopKolumna { get; set; } = null!;

    public string? FopKolumnaParametr { get; set; }

    public bool FopWymagane { get; set; }

    public bool FopWidocznoscZakladka { get; set; }

    public int FopWidocznoscModul { get; set; }

    public bool FopWidocznoscParametr { get; set; }

    public bool FopSzeroka { get; set; }

    public int FopWiersze { get; set; }

    public int FopRozmiar { get; set; }

    public string? FopTekst { get; set; }

    public string? FopSql { get; set; }

    public string? FopGridCfg { get; set; }

    public byte[]? FopGridColumnsInfo { get; set; }

    public byte[]? FopGridColumnsVisibility { get; set; }

    public byte[]? FopGridListInfo { get; set; }

    public byte[]? FopGridTableInfo { get; set; }

    public string? FopPozycjaIdent { get; set; }

    public bool FopTylkoDoOdczytu { get; set; }

    public bool FopPodsumowanie { get; set; }

    public string? FopWyliczanieSql { get; set; }

    public string? FopWarunekSql { get; set; }

    public int? FopWyliczanieSqlZdarzenie { get; set; }

    public int? FopSlownikId { get; set; }

    public bool FopUnikalne { get; set; }

    public bool FopLinkJakoPrzycisk { get; set; }

    public string FopFiltrWlasnySql { get; set; } = null!;
}
