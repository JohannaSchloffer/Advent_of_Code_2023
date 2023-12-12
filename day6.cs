// See https://aka.ms/new-console-template for more information

long[] timeArray = new long[1];
long[] distanceArray = new long[1];


string[] getInput()
{
    string[] inputArray = File.ReadAllLines("day6.txt");
    return inputArray;

}

void splitArrays(string[] input)
{
    string placeholder = input[0].Replace("Time:", string.Empty);
    placeholder = placeholder.Replace(" ", string.Empty);
    Console.WriteLine(placeholder);
    timeArray[0] = (long)Convert.ToDouble(placeholder.ToString());
    placeholder = input[1].Replace("Distance:", string.Empty);
    placeholder = placeholder.Replace(" ", string.Empty);
    Console.WriteLine(placeholder);
    distanceArray[0] = (long)Convert.ToDouble(placeholder.ToString());
    //part 1, changed type of arrays to long
    /*List<string> placeholder = input[0].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
    placeholder.RemoveAt(0);
    timeArray = Array.ConvertAll(placeholder.ToArray(), Convert.ToInt32);
    placeholder = input[1].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
    placeholder.RemoveAt(0);
    distanceArray = Array.ConvertAll(placeholder.ToArray(), Convert.ToInt32);*/
}

long calculatePossibilities(int n)
{

    long time = timeArray[n];
    long mindistance = distanceArray[n];
    List<int> wins = new List<int>();
    long counter = 0;

    for (int j = 0; j < time; j++)
    {
        long distance = j * (time - j);
        if (distance > mindistance)
        {
            counter++;
            wins.Add(j);
        }
    }
    return counter;
}



string[] input = getInput();
splitArrays(input);
long possible = 1;
for (int i = 0; i < timeArray.Length; i++)
{
    possible *= calculatePossibilities(i);
}
Console.WriteLine("Result:" + possible);




