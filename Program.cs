/*var panePrezzo = 1.50;
var lattePrezzo = 2f;
var uovaPrezzo = 1.50f;
var acquaPrezzo = 0.80f;
var cotollettePrezzo = 3.20;
var hambugerPrezzo = 8.90;
var tePrezzo = 1.10;*/



Console.WriteLine("abbiamo questi prodotti\n1. Pane 1.50$\n2. Latte 2$\n3. Uova 1.50$\n4. Acqua 1l 0.80$\n5. cotollette AIA 3.20$\n6. Hamburger Conad 8.90$" +
    "\n7. The 1.5L 1.10$");
Console.WriteLine("quanti Prodotti vuoi aggiungere al carrello?");
var numeroProdotti = int.Parse(Console.ReadLine()) ;
string[] listaSpesa = new string [numeroProdotti];
inserireProdotti();






void inserireProdotti()
{
    Console.WriteLine("quali prodotti vuoi inserire tra quelli sopra citati?");
    for (int i = 0; i < numeroProdotti; i++)
    {
       
        listaSpesa[i] = Console.ReadLine()?.ToLower();
        switch (listaSpesa[i])
        {
            case "pane":
                break;
            case "latte":
                break;
            case "uova":
                break;
            case "acqua":
                break;
            case "cotollette":
                break;
            case "hamburger":
                break;
            case "the":
                break;
            default:
                Console.WriteLine("errore digitare prodotto valido");
                break;
        }
    }

    Console.WriteLine("la tua spesa è la seguente:");

    for (int i = 0; i < listaSpesa.Length; i++)
    {
        Console.WriteLine(listaSpesa[i]);
    }
    modificareLista();

  }

void modificareLista()
{
    Console.WriteLine("la vuoi modificare?si/no");
    var scelta = Console.ReadLine()?.ToLower();
    if (scelta == "si")
    {
        Console.WriteLine("quanti prodotti vuoi rimuovere? ");
        int numeroOggettiDaRimuovere = int.Parse(Console.ReadLine());
        int nuovoNumeroProdotti = numeroProdotti - numeroOggettiDaRimuovere;
        string[] nuovaListaSpesa = new string [nuovoNumeroProdotti];
        listaSpesa = nuovaListaSpesa;
        numeroProdotti = nuovoNumeroProdotti;
        inserireProdotti();
    }
    else
    {
        Console.WriteLine("grazie");
    }
}

Console.ReadKey();