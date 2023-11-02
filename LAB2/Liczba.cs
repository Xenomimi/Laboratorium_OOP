using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Liczba
    {
        private int[] cyfry;

    public Liczba(string liczbaStr)
    {
        UstawLiczbe(liczbaStr);
    }

    public void UstawLiczbe(string liczbaStr)
    {
        int dlugosc = liczbaStr.Length;
        cyfry = new int[dlugosc];

        for (int i = 0; i < dlugosc; i++)
        {
            cyfry[i] = int.Parse(liczbaStr[i].ToString());
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (int cyfra in cyfry)
        {
            sb.Append(cyfra);
        }
        return sb.ToString();
    }

    public void PomnozPrzez(int mnoznik)
    {
        if (mnoznik < 0)
        {
            throw new ArgumentException("Mnożnik musi być liczbą nieujemną.");
        }

        int[] wynik = new int[cyfry.Length + 1];
        int przeniesienie = 0;

        for (int i = cyfry.Length - 1; i >= 0; i--)
        {
            int iloczyn = cyfry[i] * mnoznik + przeniesienie;
            wynik[i + 1] = iloczyn % 10;
            przeniesienie = iloczyn / 10;
        }

        wynik[0] = przeniesienie;
        cyfry = wynik;
    }

    public int Silnia()
    {
        int n = int.Parse(this.ToString());
        int wynik = 1;

        for (int i = 2; i <= n; i++)
        {
            wynik *= i;
        }

         return wynik;
    }
    }
}
