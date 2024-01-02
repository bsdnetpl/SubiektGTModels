using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrBo
{
    public int PboId { get; set; }

    public int PboIdPracownika { get; set; }

    public decimal PboPrzychodW { get; set; }

    public decimal PboPrzychodR { get; set; }

    public decimal PboPrzychod { get; set; }

    public decimal PboKupw { get; set; }

    public decimal PboKupr { get; set; }

    public decimal PboKup { get; set; }

    public decimal PboZaliczkiW { get; set; }

    public decimal PboZaliczkiR { get; set; }

    public decimal PboZaliczki { get; set; }

    public decimal PboPodstEmReW { get; set; }

    public decimal PboPodstEmReR { get; set; }

    public decimal PboPodstEmRe { get; set; }

    public decimal PboSklSpolW { get; set; }

    public decimal PboSklSpolR { get; set; }

    public decimal PboSklSpol { get; set; }

    public decimal PboSklZdrW { get; set; }

    public decimal PboSklZdrR { get; set; }

    public decimal PboSklZdr { get; set; }

    public decimal PboSklZdr2W { get; set; }

    public decimal PboSklZdr2R { get; set; }

    public decimal PboSklZdr2 { get; set; }

    public int PboDniChorobowe { get; set; }

    public int PboUrlopWyp { get; set; }

    public decimal PboChorPodst1 { get; set; }

    public decimal PboChorPodst2 { get; set; }

    public decimal PboChorPodst3 { get; set; }

    public decimal PboChorPodst4 { get; set; }

    public decimal PboChorPodst5 { get; set; }

    public decimal PboChorPodst6 { get; set; }

    public decimal PboChorPodst7 { get; set; }

    public decimal PboChorPodst8 { get; set; }

    public decimal PboChorPodst9 { get; set; }

    public decimal PboChorPodst10 { get; set; }

    public decimal PboChorPodst11 { get; set; }

    public decimal PboChorPodst12 { get; set; }

    public bool PboChorWpodst1 { get; set; }

    public bool PboChorWpodst2 { get; set; }

    public bool PboChorWpodst3 { get; set; }

    public bool PboChorWpodst4 { get; set; }

    public bool PboChorWpodst5 { get; set; }

    public bool PboChorWpodst6 { get; set; }

    public bool PboChorWpodst7 { get; set; }

    public bool PboChorWpodst8 { get; set; }

    public bool PboChorWpodst9 { get; set; }

    public bool PboChorWpodst10 { get; set; }

    public bool PboChorWpodst11 { get; set; }

    public bool PboChorWpodst12 { get; set; }

    public decimal PboUrSklSt1 { get; set; }

    public decimal PboUrSklSt2 { get; set; }

    public decimal PboUrSklSt3 { get; set; }

    public decimal PboUrSklSt4 { get; set; }

    public decimal PboUrSklSt5 { get; set; }

    public decimal PboUrSklSt6 { get; set; }

    public decimal PboUrSklSt7 { get; set; }

    public decimal PboUrSklSt8 { get; set; }

    public decimal PboUrSklSt9 { get; set; }

    public decimal PboUrSklSt10 { get; set; }

    public decimal PboUrSklSt11 { get; set; }

    public decimal PboUrSklSt12 { get; set; }

    public decimal PboUrSklZm1 { get; set; }

    public decimal PboUrSklZm2 { get; set; }

    public decimal PboUrSklZm3 { get; set; }

    public decimal PboUrSklZm4 { get; set; }

    public decimal PboUrSklZm5 { get; set; }

    public decimal PboUrSklZm6 { get; set; }

    public decimal PboUrSklZm7 { get; set; }

    public decimal PboUrSklZm8 { get; set; }

    public decimal PboUrSklZm9 { get; set; }

    public decimal PboUrSklZm10 { get; set; }

    public decimal PboUrSklZm11 { get; set; }

    public decimal PboUrSklZm12 { get; set; }

    public int PboUrGodz1 { get; set; }

    public int PboUrGodz2 { get; set; }

    public int PboUrGodz3 { get; set; }

    public int PboUrGodz4 { get; set; }

    public int PboUrGodz5 { get; set; }

    public int PboUrGodz6 { get; set; }

    public int PboUrGodz7 { get; set; }

    public int PboUrGodz8 { get; set; }

    public int PboUrGodz9 { get; set; }

    public int PboUrGodz10 { get; set; }

    public int PboUrGodz11 { get; set; }

    public int PboUrGodz12 { get; set; }

    public bool PboCiagloscZasChor { get; set; }

    public string PboOkresyNieskladkowe { get; set; } = null!;

    public bool PboChorobaWost3Mies { get; set; }

    public int PboChorobaMiesiac { get; set; }

    public decimal PboChorobaPodstawa { get; set; }

    public decimal PboPodstFep { get; set; }

    public decimal PboKosztyPrawAutor { get; set; }

    public int PboUrlopDobowyWymiar { get; set; }

    public decimal PboZwolZpit { get; set; }

    public decimal PboZwolZpitw { get; set; }

    public decimal PboZwolZpitr { get; set; }

    public decimal PboPrzychodWzwol { get; set; }

    public decimal PboPrzychodWzwolWykorzystany { get; set; }

    public decimal PboKupwzwol { get; set; }

    public decimal PboZaliczkiWzwol { get; set; }

    public decimal PboSklSpolWzwol { get; set; }

    public decimal PboSklSpolWzwolWykorzystany { get; set; }

    public decimal PboSklZdrWzwol { get; set; }

    public decimal PboSklZdrWzwolWykorzystany { get; set; }

    public decimal PboPrzychodRuz { get; set; }

    public decimal PboPrzychodRuzzwol { get; set; }

    public decimal PboPrzychodRuzzwolWykorzystany { get; set; }

    public decimal PboKupruz { get; set; }

    public decimal PboKupruzzwol { get; set; }

    public decimal PboZaliczkiRuz { get; set; }

    public decimal PboZaliczkiRuzzwol { get; set; }

    public decimal PboSklSpolRuzzwol { get; set; }

    public decimal PboSklSpolRuzzwolWykorzystany { get; set; }

    public decimal PboSklZdrRuzzwol { get; set; }

    public decimal PboSklZdrRuzzwolWykorzystany { get; set; }

    public decimal PboZasilkiW { get; set; }

    public decimal PboZasilkiZwolW { get; set; }

    public decimal PboPrzychodZwolnionyDlaRodzin4PlusWyp { get; set; }

    public decimal PboPrzychodZwolnionyDlaPowracajacychWyp { get; set; }

    public decimal PboPrzychodZwolnionyDlaSeniorowWyp { get; set; }

    public decimal PboPrzychodZwolnionyDlaRodzin4PlusRach { get; set; }

    public decimal PboPrzychodZwolnionyDlaPowracajacychRach { get; set; }

    public decimal PboPrzychodZwolnionyDlaSeniorowRach { get; set; }

    public int PboDniUrlopuOpiekunczego { get; set; }

    public int PboDniPracyZdalnejOkazjonalnej { get; set; }

    public int PboDniOpiekiNadDzieckiem { get; set; }

    public int PboGodzinyOpiekiNadDzieckiem { get; set; }

    public int PboDniUrlopuSilaWyzsza { get; set; }

    public int PboGodzinyUrlopuSilaWyzsza { get; set; }

    public virtual PrPracownik PboIdPracownikaNavigation { get; set; } = null!;

    public virtual ICollection<PrOkresyUrlopowBezplatnych> PrOkresyUrlopowBezplatnyches { get; set; } = new List<PrOkresyUrlopowBezplatnych>();
}
