using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlParametrUmowyCp
{
    public int PucpId { get; set; }

    public int PucpGenerowanyRaport { get; set; }

    public bool PucpSkladkaUbezpEm { get; set; }

    public bool PucpSkladkaUbezpRe { get; set; }

    public bool PucpSkladkaUbezpChor { get; set; }

    public bool PucpSkladkaUbezpWyp { get; set; }

    public bool PucpSkladkaUbezpZdr { get; set; }

    public bool PucpSkladkaFp { get; set; }

    public bool PucpSkladkaFgsp { get; set; }

    public int PucpPrzelewNaKonto { get; set; }

    public decimal PucpPrzelewKwota { get; set; }

    public decimal PucpRachPodatek { get; set; }

    public decimal PucpRachKup { get; set; }
}
