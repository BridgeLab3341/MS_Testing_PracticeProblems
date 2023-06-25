using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS_Testing_PracticeProblems
{
    public class PurchaseListOperation
    {
        int count = 0;
        public int OneTimeSold(int[] array)
        {
            List<int> list = new List<int>();
            int one=array.Length;
            int[] two= new int[one];
            for(int i=0; i<one; i++)
            {
                count = 0;
                for(int j=0; j<i-1; j++)
                {
                    if (array[i]  == array[j])
                    {
                        count++;
                    }
                }
                for(int k=i+1; k<one; k++)
                {
                    if (array[i] == array[k])
                    {
                        count++;
                    }
                    if (array[i] == array[i+1])
                    {
                        i++;
                    }
                }
                if(count == 0)
                {
                    list.Add(array[i]);
                }
            }
            return list[0];
        }
        public int SoldMore(int[] arr)
        {
            List<int> list = new List<int>();
            int n = arr.Length;
            int j = 0, i = 0, k = 0, ctr = 0;
            int[] b = new int[arr.Length];
            for (i = 0; i < n; i++)
            {
                ctr = 0;
                for (j = 0; j < i - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        ctr++;
                    }

                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
                if (ctr > 0)
                {
                    list.Add(arr[i]);
                }
            }
            return list[0];
        }
    }
}
