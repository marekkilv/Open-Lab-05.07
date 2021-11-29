using System;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            var a = nums.ToList();
            a.Remove(nums.Min());
            return a.ToArray();
        }
    }
}
