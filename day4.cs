// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Xml.XPath;

int result = 0;
int[] MatchesPerCard = new int[2186];
int[] counter = new int[218];

//int sum = 0;
try
{
    //Pass the file path and file name to the StreamReader constructor
    using StreamReader reader = new StreamReader("day4.txt");
    string line;
    int index = 0;

    string[] all = new string[2];





    while ((line = reader.ReadLine()) != null)
    {
        int matches = 0;

        line = line.Split(':')[1];
        //Console.WriteLine(line);
        all = line.Split('|');
        /*foreach(string s in all){
            Console.WriteLine(s);
        }*/

        string[] win = all[0].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        string[] input = all[1].Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int[] winNumbers = new int[win.Length];
        int[] inputNumbers = new int[input.Length];
        for (int i = 0; i < win.Length; i++)
        {
            winNumbers[i] = int.Parse(win[i]);
        }
        for (int i = 0; i < input.Length; i++)
        {
            inputNumbers[i] = int.Parse(input[i]);
        }

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            for (int j = 0; j < winNumbers.Length; j++)
            {
                //part1
                /*if(inputNumbers[i] == winNumbers[j] && matches == 0){
                    matches = 1;
                }
                else if(inputNumbers[i] == winNumbers[j] && matches > 0){
                    matches = matches*2;
                }*/
                if (inputNumbers[i] == winNumbers[j])
                {
                    matches++;
                }
            }
        }
        MatchesPerCard[index] = matches;
        index++;
        //part1
        /*sum += matches;
        Console.WriteLine(matches);*/


    }
    for (int i = 0; i < 218; i++)
    {
        counter[i] = 1;
    }
    foreach (int num in MatchesPerCard)
    {
        Console.WriteLine(num);
    }
    foreach (int num in counter)
    {
        Console.WriteLine(num);
    }
    for (int i = 0; i < 218; i++)
    {
        
            result += counter[i];
            Console.WriteLine("zwischenresult:" + result);
            for (int k = 1; k <= MatchesPerCard[i]; k++)
            {
                counter[i + k] += counter[i];

            }
        

    }
    /*for(int i = 0; i<6; i++){
        Console.WriteLine("counter"+ counter[i] + "matches"+MatchesPerCard[i]);
        result += counter[i];
    }*/
    Console.WriteLine("result:" + result);
    reader.Close();
    Console.ReadLine();


}
catch (Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}





