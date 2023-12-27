using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2v7
{
    class Catalog
    {
        private List<Composition> compositions = new List<Composition>();

        public void AddComposition(Composition composition)
        {
            compositions.Add(composition);
        }

        public void RemoveComposition(Composition composition)
        {
            compositions.Remove(composition);
        }

        public List<Composition> Search(string criteria)
        {
            // Пример простого поиска по критерию в названии или исполнителе
            return compositions.FindAll(c =>
                c.Artist.Contains(criteria, StringComparison.OrdinalIgnoreCase) ||
                c.Title.Contains(criteria, StringComparison.OrdinalIgnoreCase));
        }

        public List<Composition> Search(string artistCriteria, string TitleCriteria)
        {
            // Пример простого поиска по критерию в названии или исполнителе
            return compositions.FindAll(c =>
                c.Artist.Contains(artistCriteria, StringComparison.OrdinalIgnoreCase) ||
                c.Title.Contains(TitleCriteria, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayAllCompositions()
        {
            if (compositions.Count > 0)
            {
                Console.WriteLine("All composiotion in catalog:");
                foreach (var composition in compositions)
                {
                    Console.WriteLine(composition);
                }
            } else
            {
                Console.WriteLine("Catalog empty");
            }
        }
    }
}
