namespace estudoLeetCode;

public class Exercise49
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string sortedWord = SortWithArraySort(str);

            if (anagrams.ContainsKey(sortedWord))
            {
                anagrams[sortedWord].Add(str);
            }
            else
            {
                anagrams.Add(sortedWord, new List<string> { str });
            }
        }
        
        SortedList<string, List<string>> sortedAnagrams = new SortedList<string, List<string>>(anagrams);

        return anagrams.Values.Select(list => (IList<string>)list).ToList();
    }
    
    string SortWithArraySort(string word)
    {
        var arr = word.ToCharArray();
        Array.Sort(arr);
        return new string(arr);
    }
}

