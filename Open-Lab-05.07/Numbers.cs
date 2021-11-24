using System;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            var list = nums.ToList();
            list.Remove(nums.Min());
            return list.ToArray();
        }
    }
}
