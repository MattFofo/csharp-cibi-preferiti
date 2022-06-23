//  inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi)

/**
 * Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
 * La lunghezza della classifica
 * La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
 * Il vostro cibo top (prima posizione della classifica)
 * Il vostro cibo preferito ma non troppo (ultima posizione della classifica)


BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 

**/

//init array
string[] favoriteFood = { "pizza", "gelato", "fragole", "filetto", "mele", "pesce" };

string userFavoriteFood;


//input user

bool isUserFoodinArray = false;
do
{   
    Console.WriteLine("Scrivi il tuo cibo preferito:");
    userFavoriteFood = Console.ReadLine();
    isUserFoodinArray = false;

    for (int i = 0; i < favoriteFood.Length; i++)
    {
        if (userFavoriteFood == favoriteFood[i])
        {
            isUserFoodinArray = true;
        }
    }
    if (!isUserFoodinArray)
    {
        Console.WriteLine("Cibo mancante. Riscrivi il tuo cibo preferito:");

    }
} while (!isUserFoodinArray);


//random number
Random rnd = new Random();
int num = rnd.Next(0, (favoriteFood.Length - 1));

string pcFood = favoriteFood[num];


//lunghezza della classifica
Console.WriteLine(favoriteFood.Length);


// La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
for (int i = 0; i < favoriteFood.Length; i++)
{
    if (userFavoriteFood == favoriteFood[i])
    {
        Console.WriteLine((i + 1) + " - " + favoriteFood[i] + " --> questo è il tuo cibo preferito");
    }
    else if (pcFood == favoriteFood[i])
    {
        Console.WriteLine((i + 1) + " - " + favoriteFood[i] + " --> questo è il mio cibo preferito");

    }
    else
    {
        Console.WriteLine((i + 1) + " - " + favoriteFood[i]);

    }
}


//Il vostro cibo top (prima posizione della classifica)
Console.WriteLine(favoriteFood[0]);


//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine(favoriteFood[favoriteFood.Length - 1]);

int median = favoriteFood.Length / 2;

if ((favoriteFood.Length) % 2 == 0)
{
    Console.WriteLine("Cibo in posizione mediana se lughezza array pari: " + favoriteFood[median]);
    Console.WriteLine("Cibo in posizione mediana se lughezza array pari: " + favoriteFood[median - 1]);
}
else
{
    decimal median2 = (decimal)favoriteFood.Length / 2;
    int index = (int)Math.Floor(median2);
    Console.WriteLine("Cibo in posizione mediana se lughezza array dispari: " + favoriteFood[index]);
    
}
