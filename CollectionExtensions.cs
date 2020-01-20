using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public static class CollectionExtensions
{
private static Random rng = new Random();
      /// <summary>
      /// https://www.extensionmethod.net/1616/csharp/observablecollection-t/addrange-t
      /// </summary>
      /// <typeparam name="T"></typeparam>
      /// <param name="oc"></param>
      /// <param name="collection"></param>
      public static void AddRange<T>(this ObservableCollection<T> oc, IEnumerable<T> collection)
      {
          if (collection == null)
          {
              throw new ArgumentNullException("collection");
          }
          foreach (var item in collection)
          {
              oc.Add(item);
          }
      }
      /// <summary>
        /// Reorders the elements in a list.
        /// </summary>
        /// <typeparam name="T">The object type of the list</typeparam>
        /// <param name="list"></param>
        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// Shuffles the elements in an array.
        /// </summary>
        /// <param name="list"></param>
        public static void Shuffle(this object[] list)
        {
            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                object value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
      /// <summary>
        /// Creates a string with all of the elements of a collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="separator">A string that is placed between each item in the list.</param>
        /// <returns></returns>
        public static string PrintOut<T>(this ICollection<T> list, string separator = ", ")
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            foreach (var item in list)
            {
                sb.Append(item);
                if (i + 1 < list.Count)
                {
                    sb.Append(separator);
                }
                sb.Append(separator);
                i++;
            }

            return sb.ToString();
        }
      
}
