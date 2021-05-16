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
            int[] nums = { 3,3};
            int target = 6;
                  
            TwoSum obj = new TwoSum();
            var result = obj.twoSum(nums, target);
            
        }
        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int,int> numsDictionary = new Dictionary<int, int>();

            int complement;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                int index;
                if ( numsDictionary.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }

                if (!numsDictionary.ContainsKey(nums[i]))
                {
                    numsDictionary.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }
    }

}
