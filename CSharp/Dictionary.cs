  public static Dictionary<TResult,int> CountElements<T, TResult>(
                    IEnumerable<T> seq, Func<T,TResult> keyFunc, Func<T,int> summator)
    {
    var counter = new Dictionary<TResult, int>();
        foreach (var el in seq)
          {
            TResult key = keyFunc(el);
            if (counter.ContainsKey(key))
              counter[key]+= summator(el);
            else 
              counter.Add(key,summator(el));
          }
        return counter;
    }
