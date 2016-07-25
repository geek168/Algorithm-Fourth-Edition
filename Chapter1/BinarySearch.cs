using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    public class BinarySearch
    {

        public static int Search(int key)
        {

            var path = Path.Combine(Environment.CurrentDirectory + @"\largeW.txt");
            var lines = File.ReadAllLines(path);
            Array.Sort(lines);

            var hi = lines.Length - 1;
            var lo = 0;
           
            while(lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if(key < int.Parse(lines[mid]))
                {
                    hi = mid - 1;
                }
                else if(key > int.Parse(lines[mid]))
                {
                    lo = mid + 1;
                }
                else
                {
                    return mid;
                }
            }


            return -1;
        }



    }
}
