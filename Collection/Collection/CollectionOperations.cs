using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class CollectionOperations : ICollectionOperations
    {
        public void ListOperations(List<string> list)
        {
            if (list != null && list.Count > 0)
            {
                list.RemoveAt(list.Count / 2);

                if (list.Contains("mama"))
                {
                    list.Add("6");

                }

                if (list.Contains("course59") && list.IndexOf("course59") % 2 != 0)
                {
                    list.Reverse();

                }

                List<string> distinctList = list.Distinct().ToList();
                if (distinctList.Count == 3)
                {
                    string[] listToADD = { "2", "3", "4" };
                    list.InsertRange(2, listToADD);
                }

            }
        }

        public void DictionaryOperations(Dictionary<string, int> dictionary)
        {
            if (dictionary != null && dictionary.Count > 0)
            {
                if (dictionary.ContainsKey("scuba") && dictionary["scuba"] == 6)
                {
                    dictionary.Add("dive", 6);

                }

            }

        }

        public void StackOperations(Stack<DateTime> stack)
        {
            if (stack != null && stack.Count > 0) 
            {
                DateTime today = DateTime.Now;
                if(stack.First() < today)
                {
                    stack.Pop();
                    stack.Push(today);

                }

            }

        }

    }
}
