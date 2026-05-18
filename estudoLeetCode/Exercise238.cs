namespace estudoLeetCode;

public class Exercise238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        Dictionary<int, int> conj = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = 0; j < nums.Length; j++)
            {
                if (i != j)
                {
                    if (conj.ContainsKey(i))
                    {
                        conj[i] *= nums[j];
                    }
                    else
                    {
                        conj.Add(i, nums[j]);
                    }
                }
            }   
        }
        
        return conj.Values.ToArray();
    }
}