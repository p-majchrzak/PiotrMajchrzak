namespace Konsola.Test
{
    public class PlikTest
    {
        [Fact]
        public void DlaMetodyPobierzPlik_KiedyDaneSczytaneZPliku_WtedyZgodnoscPorownywanychDanych()
        {
            List<Piosenka> listaPoprawnych = new List<Piosenka>();
            Piosenka poprawneDane1 = new Piosenka("Sprawdzian", "\"5TP1\"", 11, 2018, 11000102);
            listaPoprawnych.Add(poprawneDane1); 
            Piosenka poprawneDane2 = new Piosenka("Piotr", "\"Majchrzak\"", 11, 2018, 11000102);
            listaPoprawnych.Add(poprawneDane2);

            List<Piosenka> listaPiosenek = Plik.PobierzPlik("PlikTestowy.txt");
            bool weryfikacja = false;
            
            for(int i = 0; i<listaPiosenek.Count; i++)
            {
                if (listaPiosenek[i].Artysta == listaPoprawnych[i].Artysta && listaPiosenek[i].Album == listaPoprawnych[i].Album
                && listaPiosenek[i].numerPobran == listaPoprawnych[i].numerPobran && listaPiosenek[i].Rok == listaPoprawnych[i].Rok
                && listaPiosenek[i].piosenkaNumer == listaPoprawnych[i].piosenkaNumer)
                {
                    weryfikacja = true;
                }
                else
                {
                    weryfikacja = false;
                    break;
                }
            }
            Assert.True(weryfikacja);
        }
    }
}