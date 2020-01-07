﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace eHairdresserSalon_API.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class FrizerskiSalonEntities : DbContext
{
    public FrizerskiSalonEntities()
        : base("name=FrizerskiSalonEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<DodatniTretmani> DodatniTretmanis { get; set; }

    public virtual DbSet<Frizeri> Frizeris { get; set; }

    public virtual DbSet<Klijenti> Klijentis { get; set; }

    public virtual DbSet<Takmicenja> Takmicenjas { get; set; }

    public virtual DbSet<Termini> Terminis { get; set; }

    public virtual DbSet<Usluge> Usluge { get; set; }

    public virtual DbSet<DodatniTretmaniOcjene> DodatniTretmaniOcjene { get; set; }

    public virtual DbSet<UslugeOcjene> UslugeOcjene { get; set; }

    public virtual DbSet<Skladiste> Skladiste { get; set; }

    public virtual DbSet<KlijentiTakmicenja> KlijentiTakmicenja { get; set; }

    public virtual DbSet<VrsteUsluga> VrsteUsluga { get; set; }

    public virtual DbSet<KlijentiNagrade> KlijentiNagrade { get; set; }

    public virtual DbSet<Nagrade> Nagrade { get; set; }


    public virtual ObjectResult<Klijenti_Result> esp_Klijenti_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Klijenti_Result>("esp_Klijenti_SelectAll");
    }


    public virtual ObjectResult<Klijenti> esp_Klijenti_SelectByKorisnickoIme(string korisnickoIme)
    {

        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Klijenti>("esp_Klijenti_SelectByKorisnickoIme", korisnickoImeParameter);
    }


    public virtual ObjectResult<Klijenti> esp_Klijenti_SelectByKorisnickoIme(string korisnickoIme, MergeOption mergeOption)
    {

        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Klijenti>("esp_Klijenti_SelectByKorisnickoIme", mergeOption, korisnickoImeParameter);
    }


    public virtual ObjectResult<Klijenti_Result> esp_Klijenti_SelectByImePrezime(string imePrezime)
    {

        var imePrezimeParameter = imePrezime != null ?
            new ObjectParameter("ImePrezime", imePrezime) :
            new ObjectParameter("ImePrezime", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Klijenti_Result>("esp_Klijenti_SelectByImePrezime", imePrezimeParameter);
    }


    public virtual int esp_Klijenti_Update(Nullable<int> klijentID, string ime, string prezime, Nullable<System.DateTime> datumRodjenja, string adresa, string email, string brojTelefona, string napomena, string korisnickoIme, string lozinkaSalt, string lozinkaHash, Nullable<int> terminiCount, Nullable<bool> aktivan)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("KlijentID", klijentID) :
            new ObjectParameter("KlijentID", typeof(int));


        var imeParameter = ime != null ?
            new ObjectParameter("Ime", ime) :
            new ObjectParameter("Ime", typeof(string));


        var prezimeParameter = prezime != null ?
            new ObjectParameter("Prezime", prezime) :
            new ObjectParameter("Prezime", typeof(string));


        var datumRodjenjaParameter = datumRodjenja.HasValue ?
            new ObjectParameter("DatumRodjenja", datumRodjenja) :
            new ObjectParameter("DatumRodjenja", typeof(System.DateTime));


        var adresaParameter = adresa != null ?
            new ObjectParameter("Adresa", adresa) :
            new ObjectParameter("Adresa", typeof(string));


        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var brojTelefonaParameter = brojTelefona != null ?
            new ObjectParameter("BrojTelefona", brojTelefona) :
            new ObjectParameter("BrojTelefona", typeof(string));


        var napomenaParameter = napomena != null ?
            new ObjectParameter("Napomena", napomena) :
            new ObjectParameter("Napomena", typeof(string));


        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        var lozinkaSaltParameter = lozinkaSalt != null ?
            new ObjectParameter("LozinkaSalt", lozinkaSalt) :
            new ObjectParameter("LozinkaSalt", typeof(string));


        var lozinkaHashParameter = lozinkaHash != null ?
            new ObjectParameter("LozinkaHash", lozinkaHash) :
            new ObjectParameter("LozinkaHash", typeof(string));


        var terminiCountParameter = terminiCount.HasValue ?
            new ObjectParameter("TerminiCount", terminiCount) :
            new ObjectParameter("TerminiCount", typeof(int));


        var aktivanParameter = aktivan.HasValue ?
            new ObjectParameter("Aktivan", aktivan) :
            new ObjectParameter("Aktivan", typeof(bool));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Klijenti_Update", klijentIDParameter, imeParameter, prezimeParameter, datumRodjenjaParameter, adresaParameter, emailParameter, brojTelefonaParameter, napomenaParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter, terminiCountParameter, aktivanParameter);
    }


    public virtual ObjectResult<Takmicenja_Result> esp_Takmicenja_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja_Result>("esp_Takmicenja_SelectAll");
    }


    public virtual ObjectResult<Takmicenja_Result> esp_Takmicenja_SelectByMjesto(string mjesto)
    {

        var mjestoParameter = mjesto != null ?
            new ObjectParameter("Mjesto", mjesto) :
            new ObjectParameter("Mjesto", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja_Result>("esp_Takmicenja_SelectByMjesto", mjestoParameter);
    }


    public virtual int esp_Farbe_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Farbe_SelectAll");
    }


    public virtual int esp_Farbe_SelectByNaziv(string nazivFarbe)
    {

        var nazivFarbeParameter = nazivFarbe != null ?
            new ObjectParameter("NazivFarbe", nazivFarbe) :
            new ObjectParameter("NazivFarbe", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Farbe_SelectByNaziv", nazivFarbeParameter);
    }


    public virtual int esp_Preparati_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Preparati_SelectAll");
    }


    public virtual int esp_Preparati_SelectByNaziv(string nazivPreparata)
    {

        var nazivPreparataParameter = nazivPreparata != null ?
            new ObjectParameter("NazivPreparata", nazivPreparata) :
            new ObjectParameter("NazivPreparata", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Preparati_SelectByNaziv", nazivPreparataParameter);
    }


    public virtual ObjectResult<Usluge_Result> esp_Usluge_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usluge_Result>("esp_Usluge_SelectAll");
    }


    public virtual ObjectResult<Usluge_Result> esp_Usluge_SelectByNaziv(string nazivUsluge)
    {

        var nazivUslugeParameter = nazivUsluge != null ?
            new ObjectParameter("NazivUsluge", nazivUsluge) :
            new ObjectParameter("NazivUsluge", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usluge_Result>("esp_Usluge_SelectByNaziv", nazivUslugeParameter);
    }


    public virtual ObjectResult<DodatniTretmani_Result> esp_DodatniTretmani_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Result>("esp_DodatniTretmani_SelectAll");
    }


    public virtual ObjectResult<DodatniTretmani_Result> esp_DodatniTretmani_SelectByNaziv(string nazivTretmana)
    {

        var nazivTretmanaParameter = nazivTretmana != null ?
            new ObjectParameter("NazivTretmana", nazivTretmana) :
            new ObjectParameter("NazivTretmana", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Result>("esp_DodatniTretmani_SelectByNaziv", nazivTretmanaParameter);
    }


    public virtual ObjectResult<Frizeri_Result> esp_Frizeri_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Frizeri_Result>("esp_Frizeri_SelectAll");
    }


    public virtual ObjectResult<Termini_Result> esp_Termini_SelectAllD()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Termini_Result>("esp_Termini_SelectAllD");
    }


    public virtual ObjectResult<Termini_Result> esp_Termini_SelectByDatum(Nullable<System.DateTime> datum)
    {

        var datumParameter = datum.HasValue ?
            new ObjectParameter("Datum", datum) :
            new ObjectParameter("Datum", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Termini_Result>("esp_Termini_SelectByDatum", datumParameter);
    }


    public virtual ObjectResult<Nullable<int>> esp_Termini_Insert(Nullable<System.DateTime> datum, Nullable<System.TimeSpan> vrijeme, string klijentImePrezime, string frizerImePrezime, string nazivUsluge)
    {

        var datumParameter = datum.HasValue ?
            new ObjectParameter("Datum", datum) :
            new ObjectParameter("Datum", typeof(System.DateTime));


        var vrijemeParameter = vrijeme.HasValue ?
            new ObjectParameter("Vrijeme", vrijeme) :
            new ObjectParameter("Vrijeme", typeof(System.TimeSpan));


        var klijentImePrezimeParameter = klijentImePrezime != null ?
            new ObjectParameter("KlijentImePrezime", klijentImePrezime) :
            new ObjectParameter("KlijentImePrezime", typeof(string));


        var frizerImePrezimeParameter = frizerImePrezime != null ?
            new ObjectParameter("FrizerImePrezime", frizerImePrezime) :
            new ObjectParameter("FrizerImePrezime", typeof(string));


        var nazivUslugeParameter = nazivUsluge != null ?
            new ObjectParameter("NazivUsluge", nazivUsluge) :
            new ObjectParameter("NazivUsluge", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("esp_Termini_Insert", datumParameter, vrijemeParameter, klijentImePrezimeParameter, frizerImePrezimeParameter, nazivUslugeParameter);
    }


    public virtual int esp_TerminiUsluge_Insert(Nullable<int> terminID, Nullable<int> uslugaID, Nullable<int> klijentID, Nullable<int> frizerID)
    {

        var terminIDParameter = terminID.HasValue ?
            new ObjectParameter("TerminID", terminID) :
            new ObjectParameter("TerminID", typeof(int));


        var uslugaIDParameter = uslugaID.HasValue ?
            new ObjectParameter("UslugaID", uslugaID) :
            new ObjectParameter("UslugaID", typeof(int));


        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("KlijentID", klijentID) :
            new ObjectParameter("KlijentID", typeof(int));


        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("FrizerID", frizerID) :
            new ObjectParameter("FrizerID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_TerminiUsluge_Insert", terminIDParameter, uslugaIDParameter, klijentIDParameter, frizerIDParameter);
    }


    public virtual ObjectResult<Klijenti_Result> esp_Klijenti_SelectByDatumRodjenja()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Klijenti_Result>("esp_Klijenti_SelectByDatumRodjenja");
    }


    public virtual int esp_Frizeri_Update(Nullable<int> frizerID, string ime, string prezime, string korisnickoIme, string lozinkaSalt, string lozinkaHash, string opis, byte[] profilnaSlika, byte[] slikaThumb, Nullable<int> vrstaUslugeID)
    {

        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("FrizerID", frizerID) :
            new ObjectParameter("FrizerID", typeof(int));


        var imeParameter = ime != null ?
            new ObjectParameter("Ime", ime) :
            new ObjectParameter("Ime", typeof(string));


        var prezimeParameter = prezime != null ?
            new ObjectParameter("Prezime", prezime) :
            new ObjectParameter("Prezime", typeof(string));


        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        var lozinkaSaltParameter = lozinkaSalt != null ?
            new ObjectParameter("LozinkaSalt", lozinkaSalt) :
            new ObjectParameter("LozinkaSalt", typeof(string));


        var lozinkaHashParameter = lozinkaHash != null ?
            new ObjectParameter("LozinkaHash", lozinkaHash) :
            new ObjectParameter("LozinkaHash", typeof(string));


        var opisParameter = opis != null ?
            new ObjectParameter("Opis", opis) :
            new ObjectParameter("Opis", typeof(string));


        var profilnaSlikaParameter = profilnaSlika != null ?
            new ObjectParameter("ProfilnaSlika", profilnaSlika) :
            new ObjectParameter("ProfilnaSlika", typeof(byte[]));


        var slikaThumbParameter = slikaThumb != null ?
            new ObjectParameter("SlikaThumb", slikaThumb) :
            new ObjectParameter("SlikaThumb", typeof(byte[]));


        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Frizeri_Update", frizerIDParameter, imeParameter, prezimeParameter, korisnickoImeParameter, lozinkaSaltParameter, lozinkaHashParameter, opisParameter, profilnaSlikaParameter, slikaThumbParameter, vrstaUslugeIDParameter);
    }


    public virtual int esp_Takmicenja_Update(Nullable<int> takmicenjeID, string naziv, Nullable<System.DateTime> datum, string mjesto, string opis, Nullable<int> frizerID)
    {

        var takmicenjeIDParameter = takmicenjeID.HasValue ?
            new ObjectParameter("TakmicenjeID", takmicenjeID) :
            new ObjectParameter("TakmicenjeID", typeof(int));


        var nazivParameter = naziv != null ?
            new ObjectParameter("Naziv", naziv) :
            new ObjectParameter("Naziv", typeof(string));


        var datumParameter = datum.HasValue ?
            new ObjectParameter("Datum", datum) :
            new ObjectParameter("Datum", typeof(System.DateTime));


        var mjestoParameter = mjesto != null ?
            new ObjectParameter("Mjesto", mjesto) :
            new ObjectParameter("Mjesto", typeof(string));


        var opisParameter = opis != null ?
            new ObjectParameter("Opis", opis) :
            new ObjectParameter("Opis", typeof(string));


        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("FrizerID", frizerID) :
            new ObjectParameter("FrizerID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Takmicenja_Update", takmicenjeIDParameter, nazivParameter, datumParameter, mjestoParameter, opisParameter, frizerIDParameter);
    }


    public virtual ObjectResult<Nullable<bool>> esp_Klijenti_ProvjeriKorisnickoIme(string korisnickoIme)
    {

        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<bool>>("esp_Klijenti_ProvjeriKorisnickoIme", korisnickoImeParameter);
    }


    public virtual int esp_Usluge_Update(Nullable<int> uslugaID, string nazivUsluge, Nullable<int> trajanjeMinute, Nullable<decimal> cijenaUsluge, Nullable<int> vrstaUslugeID)
    {

        var uslugaIDParameter = uslugaID.HasValue ?
            new ObjectParameter("UslugaID", uslugaID) :
            new ObjectParameter("UslugaID", typeof(int));


        var nazivUslugeParameter = nazivUsluge != null ?
            new ObjectParameter("NazivUsluge", nazivUsluge) :
            new ObjectParameter("NazivUsluge", typeof(string));


        var trajanjeMinuteParameter = trajanjeMinute.HasValue ?
            new ObjectParameter("TrajanjeMinute", trajanjeMinute) :
            new ObjectParameter("TrajanjeMinute", typeof(int));


        var cijenaUslugeParameter = cijenaUsluge.HasValue ?
            new ObjectParameter("CijenaUsluge", cijenaUsluge) :
            new ObjectParameter("CijenaUsluge", typeof(decimal));


        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Usluge_Update", uslugaIDParameter, nazivUslugeParameter, trajanjeMinuteParameter, cijenaUslugeParameter, vrstaUslugeIDParameter);
    }


    public virtual int esp_Termini_Update(Nullable<int> terminID, Nullable<System.DateTime> datum, Nullable<System.TimeSpan> vrijeme, Nullable<int> klijentID, Nullable<int> frizerID, Nullable<int> uslugaID, Nullable<bool> zauzeto, Nullable<int> tretmanID, Nullable<bool> ocijenjenaUsluga, Nullable<bool> ocijenjenTretman, Nullable<bool> prosaoTermin)
    {

        var terminIDParameter = terminID.HasValue ?
            new ObjectParameter("TerminID", terminID) :
            new ObjectParameter("TerminID", typeof(int));


        var datumParameter = datum.HasValue ?
            new ObjectParameter("Datum", datum) :
            new ObjectParameter("Datum", typeof(System.DateTime));


        var vrijemeParameter = vrijeme.HasValue ?
            new ObjectParameter("Vrijeme", vrijeme) :
            new ObjectParameter("Vrijeme", typeof(System.TimeSpan));


        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("KlijentID", klijentID) :
            new ObjectParameter("KlijentID", typeof(int));


        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("FrizerID", frizerID) :
            new ObjectParameter("FrizerID", typeof(int));


        var uslugaIDParameter = uslugaID.HasValue ?
            new ObjectParameter("UslugaID", uslugaID) :
            new ObjectParameter("UslugaID", typeof(int));


        var zauzetoParameter = zauzeto.HasValue ?
            new ObjectParameter("Zauzeto", zauzeto) :
            new ObjectParameter("Zauzeto", typeof(bool));


        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("TretmanID", tretmanID) :
            new ObjectParameter("TretmanID", typeof(int));


        var ocijenjenaUslugaParameter = ocijenjenaUsluga.HasValue ?
            new ObjectParameter("OcijenjenaUsluga", ocijenjenaUsluga) :
            new ObjectParameter("OcijenjenaUsluga", typeof(bool));


        var ocijenjenTretmanParameter = ocijenjenTretman.HasValue ?
            new ObjectParameter("OcijenjenTretman", ocijenjenTretman) :
            new ObjectParameter("OcijenjenTretman", typeof(bool));


        var prosaoTerminParameter = prosaoTermin.HasValue ?
            new ObjectParameter("ProsaoTermin", prosaoTermin) :
            new ObjectParameter("ProsaoTermin", typeof(bool));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Termini_Update", terminIDParameter, datumParameter, vrijemeParameter, klijentIDParameter, frizerIDParameter, uslugaIDParameter, zauzetoParameter, tretmanIDParameter, ocijenjenaUslugaParameter, ocijenjenTretmanParameter, prosaoTerminParameter);
    }


    public virtual int esp_DodatniTretmani_Update(Nullable<int> tretmanID, string nazivTretmana, Nullable<int> cijena, Nullable<int> vrstaUslugeID)
    {

        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("TretmanID", tretmanID) :
            new ObjectParameter("TretmanID", typeof(int));


        var nazivTretmanaParameter = nazivTretmana != null ?
            new ObjectParameter("NazivTretmana", nazivTretmana) :
            new ObjectParameter("NazivTretmana", typeof(string));


        var cijenaParameter = cijena.HasValue ?
            new ObjectParameter("Cijena", cijena) :
            new ObjectParameter("Cijena", typeof(int));


        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_DodatniTretmani_Update", tretmanIDParameter, nazivTretmanaParameter, cijenaParameter, vrstaUslugeIDParameter);
    }


    public virtual ObjectResult<Frizeri> esp_Frizeri_SelectByKorisnickoIme(string korisnickoIme)
    {

        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Frizeri>("esp_Frizeri_SelectByKorisnickoIme", korisnickoImeParameter);
    }


    public virtual ObjectResult<Frizeri> esp_Frizeri_SelectByKorisnickoIme(string korisnickoIme, MergeOption mergeOption)
    {

        var korisnickoImeParameter = korisnickoIme != null ?
            new ObjectParameter("KorisnickoIme", korisnickoIme) :
            new ObjectParameter("KorisnickoIme", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Frizeri>("esp_Frizeri_SelectByKorisnickoIme", mergeOption, korisnickoImeParameter);
    }


    public virtual ObjectResult<Termini_Result2> esp_Termini_GetSlobodniByFrizer(Nullable<int> frizerID)
    {

        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("frizerID", frizerID) :
            new ObjectParameter("frizerID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Termini_Result2>("esp_Termini_GetSlobodniByFrizer", frizerIDParameter);
    }


    public virtual ObjectResult<Termini_Result3> esp_Termini_GetTerminiByKlijent(Nullable<int> klijentID)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Termini_Result3>("esp_Termini_GetTerminiByKlijent", klijentIDParameter);
    }


    public virtual ObjectResult<Skladiste_Result> esp_Skladiste_GetSkladistaAll(string tretman)
    {

        var tretmanParameter = tretman != null ?
            new ObjectParameter("tretman", tretman) :
            new ObjectParameter("tretman", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Skladiste_Result>("esp_Skladiste_GetSkladistaAll", tretmanParameter);
    }


    public virtual ObjectResult<Takmicenja_GetTakmicenjaByDatum_Result> Takmicenja_GetTakmicenjaByDatum(Nullable<int> klijentID)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja_GetTakmicenjaByDatum_Result>("Takmicenja_GetTakmicenjaByDatum", klijentIDParameter);
    }


    public virtual ObjectResult<Takmicenja> esp_Takmicenja_GetTakmicenjaByDatum(Nullable<int> klijentID)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja>("esp_Takmicenja_GetTakmicenjaByDatum", klijentIDParameter);
    }


    public virtual ObjectResult<Takmicenja> esp_Takmicenja_GetTakmicenjaByDatum(Nullable<int> klijentID, MergeOption mergeOption)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja>("esp_Takmicenja_GetTakmicenjaByDatum", mergeOption, klijentIDParameter);
    }


    public virtual int esp_Skladiste_Update(Nullable<int> skladisteID, Nullable<int> tretmanID, Nullable<int> kolicina)
    {

        var skladisteIDParameter = skladisteID.HasValue ?
            new ObjectParameter("SkladisteID", skladisteID) :
            new ObjectParameter("SkladisteID", typeof(int));


        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("TretmanID", tretmanID) :
            new ObjectParameter("TretmanID", typeof(int));


        var kolicinaParameter = kolicina.HasValue ?
            new ObjectParameter("Kolicina", kolicina) :
            new ObjectParameter("Kolicina", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Skladiste_Update", skladisteIDParameter, tretmanIDParameter, kolicinaParameter);
    }


    public virtual ObjectResult<Takmicenja_Result> esp_Takmicenja_GetTakmicenjaByKlijent(Nullable<int> klijentID)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja_Result>("esp_Takmicenja_GetTakmicenjaByKlijent", klijentIDParameter);
    }


    public virtual ObjectResult<Termini_Result> esp_Termini_GetAktivniTermini()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Termini_Result>("esp_Termini_GetAktivniTermini");
    }


    public virtual ObjectResult<Frizeri_Result2> esp_Frizeri_GetProsjecnaOcjena(Nullable<int> frizerID)
    {

        var frizerIDParameter = frizerID.HasValue ?
            new ObjectParameter("FrizerID", frizerID) :
            new ObjectParameter("FrizerID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Frizeri_Result2>("esp_Frizeri_GetProsjecnaOcjena", frizerIDParameter);
    }


    public virtual ObjectResult<Takmicenja_Report> esp_Takmicenja_GetPrijavljeniByTakmicenje(Nullable<int> takmicenjeID)
    {

        var takmicenjeIDParameter = takmicenjeID.HasValue ?
            new ObjectParameter("TakmicenjeID", takmicenjeID) :
            new ObjectParameter("TakmicenjeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Takmicenja_Report>("esp_Takmicenja_GetPrijavljeniByTakmicenje", takmicenjeIDParameter);
    }


    public virtual ObjectResult<DodatniTretmani_Result2> esp_DodatniTretmani_Recommender(Nullable<int> uslugaID)
    {

        var uslugaIDParameter = uslugaID.HasValue ?
            new ObjectParameter("uslugaID", uslugaID) :
            new ObjectParameter("uslugaID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Result2>("esp_DodatniTretmani_Recommender", uslugaIDParameter);
    }


    public virtual ObjectResult<DodatniTretmani_Ocjene_Result> esp_DodatniTretmani_Ocjene()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Ocjene_Result>("esp_DodatniTretmani_Ocjene");
    }


    public virtual ObjectResult<DodatniTretmani> esp_Recommender_TretmaniByKlijent(Nullable<int> klijentID, Nullable<int> tretmanID, Nullable<int> vrstaUslugeID)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("tretmanID", tretmanID) :
            new ObjectParameter("tretmanID", typeof(int));


        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("vrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("vrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani>("esp_Recommender_TretmaniByKlijent", klijentIDParameter, tretmanIDParameter, vrstaUslugeIDParameter);
    }


    public virtual ObjectResult<DodatniTretmani> esp_Recommender_TretmaniByKlijent(Nullable<int> klijentID, Nullable<int> tretmanID, Nullable<int> vrstaUslugeID, MergeOption mergeOption)
    {

        var klijentIDParameter = klijentID.HasValue ?
            new ObjectParameter("klijentID", klijentID) :
            new ObjectParameter("klijentID", typeof(int));


        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("tretmanID", tretmanID) :
            new ObjectParameter("tretmanID", typeof(int));


        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("vrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("vrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani>("esp_Recommender_TretmaniByKlijent", mergeOption, klijentIDParameter, tretmanIDParameter, vrstaUslugeIDParameter);
    }


    public virtual ObjectResult<DodatniTretmani_Ocjene_Result> esp_DodatniTretmani_SearchByID(Nullable<int> tretmanID)
    {

        var tretmanIDParameter = tretmanID.HasValue ?
            new ObjectParameter("tretmanID", tretmanID) :
            new ObjectParameter("tretmanID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Ocjene_Result>("esp_DodatniTretmani_SearchByID", tretmanIDParameter);
    }


    public virtual ObjectResult<VrsteUsluga_Result> esp_VrsteUsluga_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VrsteUsluga_Result>("esp_VrsteUsluga_SelectAll");
    }


    public virtual ObjectResult<Usluge_Result> esp_Usluge_SelectByVrstaUsluge(Nullable<int> vrstaUslugeID)
    {

        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usluge_Result>("esp_Usluge_SelectByVrstaUsluge", vrstaUslugeIDParameter);
    }


    public virtual ObjectResult<Nagrade_Result> esp_Nagrade_SelectAll()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nagrade_Result>("esp_Nagrade_SelectAll");
    }


    public virtual int esp_Nagrade_Update(Nullable<int> nagradaID, string naziv, Nullable<System.DateTime> od, Nullable<System.DateTime> @do)
    {

        var nagradaIDParameter = nagradaID.HasValue ?
            new ObjectParameter("NagradaID", nagradaID) :
            new ObjectParameter("NagradaID", typeof(int));


        var nazivParameter = naziv != null ?
            new ObjectParameter("Naziv", naziv) :
            new ObjectParameter("Naziv", typeof(string));


        var odParameter = od.HasValue ?
            new ObjectParameter("Od", od) :
            new ObjectParameter("Od", typeof(System.DateTime));


        var doParameter = @do.HasValue ?
            new ObjectParameter("Do", @do) :
            new ObjectParameter("Do", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("esp_Nagrade_Update", nagradaIDParameter, nazivParameter, odParameter, doParameter);
    }


    public virtual ObjectResult<Nagrade_Result> esp_Nagrade_SelectByNaziv(string naziv)
    {

        var nazivParameter = naziv != null ?
            new ObjectParameter("Naziv", naziv) :
            new ObjectParameter("Naziv", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nagrade_Result>("esp_Nagrade_SelectByNaziv", nazivParameter);
    }


    public virtual ObjectResult<Frizeri_Result> esp_Frizeri_SelectUposlenikByVrstaUsluge(Nullable<int> vrstaUslugeID)
    {

        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Frizeri_Result>("esp_Frizeri_SelectUposlenikByVrstaUsluge", vrstaUslugeIDParameter);
    }


    public virtual ObjectResult<DodatniTretmani_Ocjene_Result> esp_DodatniTretmaniOcjene_SelectTretmanByVrstaUsluge(Nullable<int> vrstaUslugeID)
    {

        var vrstaUslugeIDParameter = vrstaUslugeID.HasValue ?
            new ObjectParameter("VrstaUslugeID", vrstaUslugeID) :
            new ObjectParameter("VrstaUslugeID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DodatniTretmani_Ocjene_Result>("esp_DodatniTretmaniOcjene_SelectTretmanByVrstaUsluge", vrstaUslugeIDParameter);
    }

}

}
