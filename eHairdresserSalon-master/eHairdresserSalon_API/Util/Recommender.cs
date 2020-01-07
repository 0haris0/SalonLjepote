using eHairdresserSalon_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eHairdresserSalon_API.Util
{
    public class Recommender
    {
        private FrizerskiSalonEntities dm = new FrizerskiSalonEntities();
        Dictionary<int, List<DodatniTretmaniOcjene>> tretmani = new Dictionary<int, List<DodatniTretmaniOcjene>>();

        public List<DodatniTretmani_Ocjene_Result> GetSlicneProizvode(int klijentID, int tretmanID, int vrstaUslugeID)
        {
            UcitajTretmane(klijentID, tretmanID, vrstaUslugeID);
            List<DodatniTretmaniOcjene> ocjenePosmatranogProizvoda = dm.DodatniTretmaniOcjene.Where(x => x.TretmanID == tretmanID).OrderBy(x => x.KlijentID).ToList();

            List<DodatniTretmaniOcjene> zajednickeOcjene1 = new List<DodatniTretmaniOcjene>();
            List<DodatniTretmaniOcjene> zajednickeOcjene2 = new List<DodatniTretmaniOcjene>();
            List<DodatniTretmani_Ocjene_Result> preporuceniTretmani = new List<DodatniTretmani_Ocjene_Result>();

            foreach (var item in tretmani)
            {
                foreach (DodatniTretmaniOcjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KlijentID == o.KlijentID).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KlijentID == o.KlijentID).First());
                    }
                }
                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                if (slicnost > 0.90)
                {
                    preporuceniTretmani.Add(dm.esp_DodatniTretmani_SearchByID(item.Key).First());
                }
                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }


            if (preporuceniTretmani.Count() > 5)
            {
                preporuceniTretmani = preporuceniTretmani.OrderByDescending(p => p.ProsjecnaOcjena).Take(5).ToList(); 
            }

            List<DodatniTretmani_Ocjene_Result> tempListaZaSortiranje = new List<DodatniTretmani_Ocjene_Result>();
            foreach (var item in dm.DodatniTretmanis.Where(x => x.TretmanID != tretmanID).ToList())
            {
                tempListaZaSortiranje.Add(dm.esp_DodatniTretmani_SearchByID(item.TretmanID).First());
            }
            tempListaZaSortiranje = tempListaZaSortiranje.OrderByDescending(x => x.ProsjecnaOcjenaDec).ToList();

            if (preporuceniTretmani.Count() == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    preporuceniTretmani.Add(dm.esp_DodatniTretmani_SearchByID(tempListaZaSortiranje[i].TretmanID).First());
                }
            }

            if (preporuceniTretmani.Count() > 0 && preporuceniTretmani.Count() < 5)
            {
                foreach (var item in tempListaZaSortiranje)
                {
                    while (preporuceniTretmani.Count() < 5)
                    {
                        preporuceniTretmani.Add(item);
                    }
                }
                
            }

            preporuceniTretmani = preporuceniTretmani.OrderByDescending(p => p.ProsjecnaOcjenaDec).ToList();
            return preporuceniTretmani;
        }

        private double GetSlicnost(List<DodatniTretmaniOcjene> zajednickeOcjene1, List<DodatniTretmaniOcjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count() != zajednickeOcjene2.Count())
                return 0;

            double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;
            for (int i = 0; i < zajednickeOcjene1.Count(); i++)
            {
                brojnik += Convert.ToDouble(zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena);
                nazivnik1 += Convert.ToDouble(zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena);
                nazivnik2 += Convert.ToDouble(zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena);
            }
            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);
            double nazivnik = nazivnik1 * nazivnik2;
            if (nazivnik == 0)
                return 0;
            return brojnik / nazivnik;
        }

        private void UcitajTretmane(int klijentID, int tretmanID, int vrstaUslugeID)
        {
            List<DodatniTretmani> sviTretmani = dm.esp_Recommender_TretmaniByKlijent(klijentID, tretmanID, vrstaUslugeID).ToList();
            List<DodatniTretmaniOcjene> ocjene = new List<DodatniTretmaniOcjene>();
            foreach (DodatniTretmani item in sviTretmani)
            {
                ocjene = dm.DodatniTretmaniOcjene.Where(x => x.TretmanID == item.TretmanID).OrderBy(x => x.KlijentID).ToList();
                if (ocjene.Count() > 0)
                    tretmani.Add(item.TretmanID, ocjene);
            }
        }
    }
}