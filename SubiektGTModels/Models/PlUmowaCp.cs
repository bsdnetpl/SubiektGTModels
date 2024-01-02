using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlUmowaCp
{
    public int UcpId { get; set; }

    public int UcpIdPracownika { get; set; }

    public string UcpNumer { get; set; } = null!;

    public string UcpOpis { get; set; } = null!;

    public string UcpTresc { get; set; } = null!;

    public decimal UcpKwota { get; set; }

    public int UcpRodzaj { get; set; }

    public DateTime UcpDataOd { get; set; }

    public DateTime? UcpDataDo { get; set; }

    public DateTime? UcpDataRozwiazania { get; set; }

    public string UcpPowodRozwiazania { get; set; } = null!;

    public string UcpTytulUbezp { get; set; } = null!;

    public int UcpGenerowanyRaport { get; set; }

    public bool UcpSkladkaUbezpEm { get; set; }

    public bool UcpSkladkaUbezpRe { get; set; }

    public bool UcpSkladkaUbezpChor { get; set; }

    public bool UcpSkladkaUbezpWyp { get; set; }

    public bool UcpSkladkaUbezpZdr { get; set; }

    public bool UcpSkladkaFp { get; set; }

    public bool UcpSkladkaFgsp { get; set; }

    public int UcpPrzelewNaKonto { get; set; }

    public decimal UcpPrzelewKwota { get; set; }

    public bool UcpRozwiazana { get; set; }

    public bool UcpZwolnienieZpodatku { get; set; }

    public bool UcpUmowaZlecenie { get; set; }

    public bool UcpCzyNaliczacZaliczke { get; set; }

    public bool UcpCzyOdraczacPoborZaliczki { get; set; }

    public bool UcpCzyOdliczacUlge { get; set; }

    public int UcpWymiarUlgiPodatkowej { get; set; }

    public virtual ICollection<PlRachunekDoUmowyCp> PlRachunekDoUmowyCps { get; set; } = new List<PlRachunekDoUmowyCp>();

    public virtual PrPracownik UcpIdPracownikaNavigation { get; set; } = null!;

    public virtual SlTytulUbezpieczenium UcpTytulUbezpNavigation { get; set; } = null!;
}
