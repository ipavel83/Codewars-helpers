  using System;
  using System.Linq;
  using System.Collections.Generic;

    //Extention method
    public static (T first, T second) FirstTwoToTuple<T>(this IEnumerable<T> items)
    {
        return (items.First(), items.Skip(1).First());
    }

    public static IEnumerable<(T Item, int Count)> CountRepetition<T>(IEnumerable<T> source) where T : IComparable
      {
      if (source.Count() == 0)
        yield break;
      int count = 0;
      T last = source.First();
      foreach( var el in source)
        {
        if (el.CompareTo(last) != 0)
          {
          yield return (last, count);
          last = el;
          count = 1;
          }
        else
          count++;
        }
      yield return (last, count);
      }
  }
}
