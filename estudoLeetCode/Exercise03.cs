namespace estudoLeetCode;

public class Exercise03
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> sequence = new Dictionary<char, int>();
        int maxLength = 0;
        int left = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (sequence.ContainsKey(s[right]) && sequence[s[right]] >= left)
            {
                left = sequence[s[right]] + 1;
            }
            else
            {
                maxLength = Math.Max(maxLength, right - left + 1);
            }
            
            sequence[s[right]] = right;
        }
        
        return maxLength;
    }

    public int LengthOfLongestSubstringBrutalMode(string s)
    {
        if(s.Length == 0)            
            return 0;
        
        int max_length = 1;
        Dictionary<char, int> max_caracters_sequence = new Dictionary<char, int>();
        
        max_caracters_sequence.Add(s[0], 0);
        
        for (int i = 1; i < s.Length; i++)
        {
            if (!max_caracters_sequence.ContainsKey(s[i]))
            {
                max_caracters_sequence.Add(s[i], i);
                
                if (max_caracters_sequence.Count > max_length)
                    max_length = max_caracters_sequence.Count;
                
                continue;
            }
            
            
            
            int charfind = max_caracters_sequence.Keys.ToList().IndexOf(s[i]) + 1;
            max_caracters_sequence = max_caracters_sequence.ToArray()[charfind..(max_caracters_sequence.Count)]
                .ToDictionary(x => x.Key, x => x.Value);
            i--;
            
        }

        return max_length;
    }
}