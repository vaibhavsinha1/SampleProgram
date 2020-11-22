using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class MergeSort
    {
        public void MergeSort1(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        public void Sort(int[] arr, int l , int r)
        {
            if(l<r)
            {
                int m = (l + r) / 2;

                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                Merge(arr, l, m, r);    
            }
        }

        public void Merge(int[] arr, int l, int m, int r)
        {
            int i,j;
            int n1 = (m - l) + 1;
            int n2 = r - m;
            //Create 2 temp array 
            int[] L = new int[n1];
            int[] R = new int[n2];

            //fill the 2 array
            for (i = 0; i < n1; i++)
                L[i] = arr[l+i];
            for (j = 0; j < n2; j++)
                R[j] = arr[m+1 + j];

            //Merge this 2 array
            i = 0; j = 0;
            int k = l;
            while(i<n1 && j<n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                arr[k] = L[i];
                k++;
                i++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                k++;
                j++;
            }

        }

    }
}
