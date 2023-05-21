using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
{
    public class BubbleSort<T>
    {

        public delegate int Comp(T a, T  b);
        public static void Sort(T[] nums,Comp comp)
        {
            
            for(int i=0;i<nums.Length;i++)
            {
                for (int j = 0; j < nums.Length-1; j++)
                {
                    if (comp(nums[j],nums[j+1])==-1)
                    {
#pragma warning disable IDE0180 // Use tuple to swap values
                        var temp = nums[j];
#pragma warning restore IDE0180 // Use tuple to swap values
                        nums[j]= nums[j+1];
                        nums[j+1] = temp;
                    }
                }

            }

            
        }
    }
}
