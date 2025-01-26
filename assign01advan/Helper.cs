using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign01advan
{
    internal class Helper
    {
        #region ReverseArray
        public static void ReverseArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                T temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
        }
        #endregion

        #region FirstIndexNonRepeatedCharacter
        public static void FirstIndexNonRepeatedCharacter(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        break;
                    }
                    if (j == s.Length - 1)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
            }
        }
        #endregion
    }
}
