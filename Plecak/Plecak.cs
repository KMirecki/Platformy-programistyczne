using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject"), InternalsVisibleTo("GUI")]
namespace Problem
{

    internal class Plecak
    {
        private int number;
        internal List<Item> items { get; set; }
        public Plecak(int n, int seed)
        {
            if (n < 0)
            {
                n = 0;
            }
            items = GenerateItems(n, seed);
            number = n;
            foreach (var item in items)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public List<Item> GenerateItems(int n, int seed)
        {
            List<Item> generatedItems = new List<Item>();
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
            {
                generatedItems.Add(new Item(i, random.Next(1, 11), random.Next(1, 11)));
            }
            return generatedItems;
        }
        public Result Solve(int capacity)
        {
            if (capacity < 0)
            {
                capacity = 0;
            }
            int current_capacity=0;
            Result result = new Result();
            List<Item> sortedList = items.OrderByDescending(o => o.value/o.weight).ToList();
            for(int i =0; i<items.Count(); i++)
            {
                if (current_capacity + sortedList[i].weight <= capacity)
                {
                    result.takeItem(sortedList[i]);
                    current_capacity += sortedList[i].weight;
                }
                if(current_capacity == capacity) 
                {
                    break;    
                }
            }
            return result;
        }
        public Result Solve2(int capacity)
        {
            if (capacity < 0)
            {
                capacity = 0;
            }
            // Tablica do przechowywania rozwiazan mniejszych problemow 
            // A[i,j] to wartosc dla problemu z pierwszymi przedmiotami od 1 do i przy pojemnosci plecaka j
            // Pierwszy wiersz i kolumna zawsze beda zerowe bo 0 miejca = 0 itemow wzietych i 0 itemow do wziecia = 0 itemow wzietych
            // default value dla inta to 0 wiec nie trzeba manualnie tego robic (+1 w wymiarach bo np. capacity chcemy od 0-20 to 21 wartosci)
            int[,] A = new int[items.Count() + 1, capacity + 1];

            // Wypełnianie tablicy
            for (int i = 1; i <= items.Count(); i++)
            {
                for (int j = 1; j <= capacity; j++)
                {
                    if (items[i - 1].weight <= j) // jak item sie miesci to wybieramy wybieramy maxa jak na wikipedii
                    {
                        A[i, j] = Math.Max(A[i - 1, j], A[i - 1, j - items[i - 1].weight] + items[i - 1].value);
                    }
                    else // jak sie nie miesci to przepisujemy wartosc z gornego wiersza
                    {
                        A[i, j] = A[i - 1, j];
                    }
                }
            }


            Result result = new Result();
            int remainingCapacity = capacity;

            // Trzeba przejsc od konca sprawdzajac ktore itemy wzielismy
            for (int i = items.Count(); i > 0 && remainingCapacity > 0; i--)
            {
                // jezeli wynik rozni sie od wyniku wiersz wyzej to znaczy ze wzielismy ten item
                if (A[i, remainingCapacity] != A[i - 1, remainingCapacity])
                {
                    result.takeItem(items[i - 1]);
                    remainingCapacity -= items[i - 1].weight;
                }
            }

            return result;
        }
    }
}