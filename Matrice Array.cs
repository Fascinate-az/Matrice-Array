string[] materie = { "Matematica", "Storia", "Arte", "Fisica", };
string[] nomi = { "Edoardo", "Alessia", "Ilaria", "Lida" };


int[,] valutazioni = new int[,] { 
    {6,8,3,5} ,
    {10,7,9,4} ,
    {5,3,4,6} ,
    {6,6,6,5} ,

};

for (int i = 0; i < materie.Length; i++) 
{
    Console.WriteLine(materie[i]);
    
        for (int j = 0; j < materie.Length; j++) //usiamo materie.length perche deve scorrere per 4
        {
            Console.WriteLine(nomi[j] + "=" +   valutazioni[j,i] );//nomi usa la J perche rappresenta la riga e deve scorrere tutta la riga per 
        }
}
