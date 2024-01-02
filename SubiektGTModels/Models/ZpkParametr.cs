using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZpkParametr
{
    public int ZpkpId { get; set; }

    public bool ZpkpBrakKontrahenta { get; set; }

    public bool ZpkpKontrolaNumeru { get; set; }

    public bool ZpkpPrzeszpiszKhId { get; set; }

    public bool ZpkpPrzepiszKatId { get; set; }

    public bool ZpkpPrzepiszData { get; set; }

    public bool ZpkpPrzepiszDataGosp { get; set; }

    public bool ZpkpPrzepiszArt17 { get; set; }

    public bool ZpkpPrzepiszOpis { get; set; }

    public bool ZpkpPrzepiszBo { get; set; }

    public bool ZpkpPrzepiszBowolny { get; set; }

    public bool ZpkpPrzepiszVat { get; set; }

    public bool ZpkpPrzepiszWydDochZwol { get; set; }

    public bool ZpkpPrzepiszWydDochZwolLataub { get; set; }
}
