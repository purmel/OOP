using System;
using System.Collections.Generic;
using System.Text;

namespace s1_1.Polimorfism__mosteniri
{
    public class Client
    {
        public void run(IOps obiectDeTest)
        {
            Console.WriteLine("Rezultat f1: " + obiectDeTest.f1(12, 18));
            Console.WriteLine("Rezultat f2: " + obiectDeTest.f2(12, 18));
            Console.WriteLine("---------------------------------------");
        }
    }

    //avand in vedere ca avem 2 Main-uri, pentru a functiona Program.cs se va comenta 
    //main-ul din clasa Client, si modifica numele din Program.cs din Main_Vechi -> Main

    //daca se vrea functionarea Main-ului din client, se schimba numele Main-ului din
    //Program.cs in altul
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            A obiectA = new A();
            B obiectB = new B();
            D obiectD = new D();

            Console.WriteLine("Testam Clasa A - suma si concatenare");
            client.run(obiectA);

            Console.WriteLine("Testam Clasa B - CMMDC si CMMMC");
            client.run(obiectB);

            Console.WriteLine("Testam Clasa D - suma cifrelor si divizorilor");
            client.run(obiectD);

            Console.ReadLine();
        }
    }
}
