namespace s1_1
{
    internal class Program
    {
        //avand in vedere ca avem 2 Main-uri, pentru a functiona Program.cs se va comenta 
        //main-ul din clasa Client, si modifica numele din Program.cs din Main_Vechi -> Main

        //daca se vrea functionarea Main-ului din client, se schimba numele Main-ului din
        //Program.cs in altul 
        static void Main_Vechi(string[] args)
        {
            // ==========================================
            // 1. TESTARE CLASA DATE
            // ==========================================
            Console.WriteLine("--- Testare Clasa Date ---");

            // Cream doua obiecte folosind constructorul cu parametri
            Date data1 = new Date(2024, 6, 15);
            Date data2 = new Date(2024, 6, 20);

            // Afisam datele (se va apela automat metoda ToString())
            Console.WriteLine($"Data 1 este: {data1}");
            Console.WriteLine($"Data 2 este: {data2}");

            // Testam operatorul de inegalitate (<)
            if (data1 < data2)
            {
                Console.WriteLine("Data 1 este cronologic inaintea Datei 2.");
            }

            // Testam operatorul minus (-)
            int diferentaZile = data2 - data1;
            Console.WriteLine($"Diferenta dintre cele doua date este de {diferentaZile} zile.\n");


            // ==========================================
            // 2. TESTARE CLASA TIME
            // ==========================================
            Console.WriteLine("--- Testare Clasa Time ---");

            // Cream doua obiecte Time
            Time timp1 = new Time(10, 45, 30); // 10:45:30
            Time timp2 = new Time(2, 20, 40);  // 02:20:40

            Console.WriteLine($"Timp 1 este: {timp1}");
            Console.WriteLine($"Timp 2 este: {timp2}");

            // Testam operatorul de adunare (+)
            Time sumaTimp = timp1 + timp2;
            Console.WriteLine($"Suma celor doi timpi este: {sumaTimp}");

            // Testam metoda CompareTo
            int rezultatComparare = timp1.CompareTo(timp2);
            if (rezultatComparare == 1)
            {
                Console.WriteLine("Timp 1 este mai tarziu decat Timp 2.");
            }
            else if (rezultatComparare == -1)
            {
                Console.WriteLine("Timp 1 este mai devreme decat Timp 2.");
            }
            else
            {
                Console.WriteLine("Timpii sunt perfect egali.");
            }

            Console.ReadLine();
        }
    }
}
