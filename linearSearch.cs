/* Linear Search Algorithm
*/

using System;

class linearSearch
{
  /* search function */
  public static int search(int[] arr, int x)
  {
    int n = arr.Length;
    for (int i = 0; i < n; i++){
      if  (arr[i] == x)
        return i;
      return -1
    }
  }
	
  public static void Main()
	{
	int[] arr = {0,1, 2, 3, 4, 5}
	int x = 3;
	int result = search(arr,x);
	if (result == -1)
		Console.Writeline("Element not in array.");
	else
		Console.WriteLine("Element at index: " + result);
	}
}  
