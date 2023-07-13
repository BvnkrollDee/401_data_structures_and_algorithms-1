using System.Collections;
namespace CodeChallenges
{
    public class CodeChallenge1
    {
        public static int[] ReverseArray(int[] array)
        {

      int[] newArray = new int[array.Length];

      for(int i = array.Length - 1; i >= 0; i--)

      {
        int newIndex = (array.Length - 1) - i;
        newArray[newIndex] = array[i];
      }
            return newArray;
        }
    }



















}