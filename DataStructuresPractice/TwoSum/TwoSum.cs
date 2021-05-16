using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TwoSum
{
    class TwoSum
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,2,4};
            int target = 6;
                  
            TwoSum obj = new TwoSum();
            var result = obj.twoSum(nums, target);
            
        }
        public int[] twoSum(int[] nums, int target)
        {
            List<Numbers> numbers = new List<Numbers>();
            for (int i = 0; i < nums.Length; i++)
            {
                numbers.Add(new Numbers() { number=nums[i],position=i});
            }
            var lookup = numbers.ToLookup(x => x.number);
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (lookup.Contains(complement))
                {
                    return new int[] { 0,0 };
                }

            }
            return new int[] { -1,-1 };
        }
    }
    public class Numbers
    {
        public int number { get; set; }
        public int position { get; set; }
    }
}
