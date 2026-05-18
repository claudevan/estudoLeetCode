namespace estudoLeetCode;

public class Exercise238
{
    // Time: O(n^2) Brutal Force
    /*public int[] ProductExceptSelf(int[] nums)
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
    }*/
    
    //Resolution with O(n) Time and O(1) Space
    public int[] ProductExceptSelf(int[] nums)
    {
        int arrayLenght = nums.Length;
        int[] conj = new int[arrayLenght];
        
        conj[0] = 1;
        
        var leftProduct = 1;
        for (int i = 0; i < arrayLenght; i++)
        {
            conj[i] = leftProduct;
            leftProduct *= nums[i];
        }
        
        var rightProduct = 1;
        for (int i = arrayLenght -1; i > 0 -1; i--)
        {
            conj[i] *= rightProduct;
            rightProduct *= nums[i];
        }
        
        return conj;
    }
}