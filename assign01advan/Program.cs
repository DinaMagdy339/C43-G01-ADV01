using assign01advan.GRange;
using Microsoft.VisualBasic;
using System.Collections;
namespace assign01advan
{
    internal class Program
    {         
        public static void Main(string[] args)
        {
            #region 1

            //Range<int> range = new Range<int>(17, 28);
            //Console.WriteLine(range.ToString());
            //Console.WriteLine($"if 15 in Range : {range.IsInRange(15)}"); 
            //Console.WriteLine($"if 25 in Range : {range.IsInRange(25)}");
            //Console.WriteLine($"Length between start and end = {range.Length()}");      

            #endregion

            #region 2

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Helper.ReverseArray(array);
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + ",");
            //}

            #endregion

            #region 3

            //List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] % 2 == 0)
            //    {
            //       List<int>list01 = new List<int> { list[i] };
            //        list01.ForEach(Console.WriteLine);
            //    }
            //}

            #endregion

            #region 4

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(3);

            //fixedSizeList.Add(4);
            //fixedSizeList.Add(3);
            //fixedSizeList.Add(5);
            ////fixedSizeList.Add(4);  
            
            //Console.WriteLine(fixedSizeList.Get(1)); 
            //Console.WriteLine(fixedSizeList.Get(4));

            #endregion

            #region 5

            //string s = "ahmedmohamedx";
            //Helper.FirstIndexNonRepeatedCharacter(s);
            #endregion

        }
    }
}
