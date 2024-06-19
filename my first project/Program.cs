using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace my_first_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //practice(1)//

            //Console.WriteLine("plz insert your age");
            //string input = Console.ReadLine();
            //int age = Convert.ToInt32(input);

            //if(age > 18)
            //{
            //    Console.WriteLine("welcome!");
            //}
            //else 
            //{
            //    Console.WriteLine("you are not allowed to continue!");
            //}
            //Console.ReadKey();

            //===============================================================================================

            //practice(2)//

            //string[] movies = new string[3] { "movies1","movies2","movies3"};
            //List<int> ranks = new List<int>();
            //for (int i = 0; i < movies.Length; i++) {
            //    string text = "Please insert your rank (1-10) for the movie: " + movies[i] + ":";
            //    Console.WriteLine(text);
            //    int rank = Convert.ToInt32(Console.ReadLine());
            //    ranks.Add(rank);
            //}
            //double average = CalculateAverage(ranks);
            //Console.WriteLine("The average rank is :");
            //Console.WriteLine(average);
            //Console.ReadKey();

            //===============================================================================================

            //practice(3)//

            //Manager mng = new Manager();
            //mng.name = "Jonh";
            //Client cli1 = mng.AddClient("Alex");
            //cli1.buy("book2");
            //Console.WriteLine(cli1.name);
            //Console.WriteLine(cli1.GetPoint());
            //cli1.buy("book87");
            //Console.WriteLine(cli1.name);
            //Console.WriteLine(cli1.GetPoint());

            //Client cli2 = mng.AddClient("Marry");
            //cli2.buy("book87");
            //Console.WriteLine(cli2.name);
            //Console.WriteLine(cli2.GetPoint());

            //Console.ReadKey();



            //===============================================================================================


            //practice(4)//

            //AudioBook book1 = new AudioBook("Animal Farm","George Orwell","john");
            //book1.PrintInfo();

            //PdfBook book2 = new PdfBook("Animal Farm", "George Orwell", "john publications");
            //book2.Price = 23.5;
            //book2.PrintInfo();
            //book2.PrintInfo(book2.Publisher,book2.Price);

            //Console.ReadKey();



            //===============================================================================================
        }

        //practice(3)//

        //public class Client
        //{
        //    public string name;
        //    private int point = 0;

        //    public int GetPoint()
        //    {
        //        return point;
        //    }

        //    public void buy(string product)
        //    {
        //        point++;
        //    }
        //}

        //public class Manager
        //{
        //    public string name;
        //    public Client AddClient(string clientName)
        //    {
        //        Client client1 = new Client();
        //        client1.name = clientName;
        //        return client1;
        //    }
        //}

        //===============================================================================================



        //practice(4)//


        //public class book
        //{
        //    public string Name;
        //    public string Author;

        //    public virtual void PrintInfo()
        //    {
        //        Console.WriteLine(Name + " - " + Author);
        //    }

        //}

        //public class AudioBook : book 
        //{
        //    public string Narrator;

        //    public AudioBook(string name, string author, string narrator)
        //    {
        //        Name = name;
        //        Author = author;
        //        Narrator = narrator;
        //    }

        //    public override void PrintInfo()
        //    {
        //        Console.WriteLine(Name + " - " + Author + "(" + Narrator + ")");
        //    }

        //}

        //public class PdfBook : book
        //{
        //    public string Publisher;
        //    public double Price;

        //    public PdfBook(string name, string author, string publisher)
        //    {
        //        Name = name;
        //        Author = author;
        //        Publisher = publisher;
        //    }

        //    public void PrintInfo(string publisher, double price)
        //    {
        //        Console.WriteLine(Name + " - " + Author + " - " + publisher + " - " + price + "$" );
        //    }
        //}



        //===============================================================================================



        //practice(2)//

        //public static double CalculateAverage(List<int> userrRnks)
        //{
        //    double sum = 0;
        //    for (int i = 0;i < userrRnks.Count;i++)
        //    {
        //        sum += userrRnks[i];
        //    }
        //    double avg = sum / userrRnks.Count;
        //    return avg;
        //}

        //===============================================================================================

    }
}
