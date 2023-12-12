// See https://aka.ms/new-console-template for more information


using StreamReader reader = new StreamReader("day9.txt");
string? line;
List<int[]> intArrays = new List<int[]>();
int result = 0;

int[] calculateDifferenz(int[] startArray)
{
    int[] newArray = new int[startArray.Length - 1];
    for (int i = 0; i < startArray.Length - 1; i++)
    {
        newArray[i] = startArray[i + 1] - startArray[i];
    }
   /* foreach (int i in newArray)
    {
        Console.WriteLine(i);
    }*/
    return newArray;
}

bool checkNull(int[] arr)
{
    bool check = true;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            check = false;
            continue;
        }
    }
    return check;
}

int extrapolatedValue(List<int[]> liste)
{
    int val = 0;
    //bsp1
    /*for (int k = liste.Count - 1; k > 0; k--)
    {
        int[] over = liste[k - 1];
        val = over[over.Length - 1] + val;
    }*/
    //bsp2
    for(int k = liste.Count - 1; k > 0; k--){
        int[] over = liste[k-1];
        val = over[0] - val;
    }
    return val;
}



while ((line = reader.ReadLine()) != null)
{
    int[] lineArray = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int j;
    intArrays.Add(lineArray);
    for (j = 0; !checkNull(lineArray); j++)
    {
        lineArray = calculateDifferenz(lineArray);
        intArrays.Add(lineArray);
    }
    result += extrapolatedValue(intArrays);
    Console.WriteLine("in between: " + result);
    intArrays.Clear(); 

}
Console.WriteLine("result: " + result);
