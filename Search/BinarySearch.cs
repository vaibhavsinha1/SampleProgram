using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class BinarySearch
    {
        public int BinarySearch1(int[] arr, int x)
        {
            if (arr.Length == 0)
                return -1;
            //if(arr.Length == 1)
            //{
            //    if (arr[0] == x)
            //        return 0;
            //    else
            //        return -1;
            //}
            return Search1(arr, 0, arr.Length, x);
        }

        private int Search1(int[] arr, int l, int r, int x)
        {
            
            if(r>=l)
            {
                int mid = (l + r) / 2;
                if (arr[mid] == x)
                    return mid;

                if(arr[mid] > x)
                {
                    return Search1(arr, l, mid - 1, x);
                }
                else
                {
                    return Search1(arr, mid+1, r, x);
                }
            }

            return -1;
        }

    }
}
