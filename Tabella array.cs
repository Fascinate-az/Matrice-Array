
string[] materie = {"Matematica", "Storia", "Arte", "Fisica", };
string[] nomi = {"Edoardo", "Alessia", "Ilaria", "Lida"};


int[,] valutazioni = new int[,] { 
    {6,8,3,5} ,
    {10,7,9,4} ,
    {5,3,4,6} ,
    {6,6,6,5} ,

};

for (int i = 0; i < materie.Length; i++) 
    
{
    Console.Write("          " + materie[i] );
    
}
for (int i = 0; i <nomi.Length; i++)
{
    Console.WriteLine(" ");
    Console.WriteLine(nomi[i]);

    for (int j = 0; j < materie.Length; j++)
    {
        
        Console.Write("               " +valutazioni[i, j] );
        
    }
    
}

