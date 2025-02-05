float [,] statistichePianeti=new float [,]{

    {0.39f,0.24f,4.878f,3.3f,5.4f},
    {0.72f,0.62f,12.120f,48.7f,5.2f},
    {1.00f,1.00f,12.756f,59.8f,5.5f},
    {1.52f,1.88f,6.787f,6.4f,3.9f},
    {5.20f,11.86f,142.948f,18.991f,1.3f},
    {9.54f,29.46f,120.536f,5.686f,0.7f}
};

string[] menuSuperiore = { "Pianeti","Distanza Dal Sole", "Periodo Riv.", "Diamentro", "Massa", "Densità" };
string[] pianeti = { "Mercurio", "Venere", "Terra", "Marte", "Giove", "Saturno" };

for (int i = 0; i < menuSuperiore.Length; i++)
{
    Console.Write(menuSuperiore[i].ToUpper());
    Console.Write("|");
}

Console.WriteLine();
for (int i = 0; i < pianeti.Length; i++)
{
    Console.WriteLine();
    Console.WriteLine(pianeti[i]);
    

    for (int j = 0; j <5; j++)  // lunghezza 5 perche deve lunghe le colonne dell array che sono 5 partendo da 0
    {
        Console.Write("        ");
        Console.Write(statistichePianeti[i, j]);
        Console.Write(" ");
    }
}

