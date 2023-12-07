// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.IO;




int sum = 0;
try
{
    //Pass the file path and file name to the StreamReader constructor
    using StreamReader reader = new StreamReader("day1.txt");
    string line;
    int[] digits = new int[1];
    int j = 0;
    int k =0;
    int num;

    while ((line = reader.ReadLine()) != null)
    {
        if(line.Contains("one")){
            line = line.Replace("one", "o1e");
        }
        if(line.Contains("two")){
            line = line.Replace("two", "t2o");
        }
        if(line.Contains("three")){
            line = line.Replace("three", "t3e");
        }
        if(line.Contains("four")){
            line = line.Replace("four", "f4r");
        }
        if(line.Contains("five")){
            line = line.Replace("five", "f5e");
        }
        if(line.Contains("six")){
            line = line.Replace("six", "s6x");
        }
        if(line.Contains("seven")){
            line = line.Replace("seven", "s7n");
        }
        if(line.Contains("eight")){
            line = line.Replace("eight", "e8t");
        }
        if(line.Contains("nine")){
            line = line.Replace("nine", "n9e");
        }
        //Console.WriteLine(line);

        for(int i = 0; i < line.Length; i++){
            if(Char.IsDigit(line[i])){
                
                j++;
                //Console.WriteLine(line[i]);
            }
        }
        digits = new int[j];
        for(int i = 0; i<line.Length; i++){
            if(Char.IsDigit(line[i])){            
            num = int.Parse(line[i].ToString());
            digits[k] = num;
            //Console.WriteLine(digits[k]);
            k++;
            }
        }
        k=0;
        j=0;
        //Console.Write(digits[0]);
        //Console.WriteLine(digits[digits.Length-1]);

        sum += digits[0]*10 + digits[digits.Length-1];

        //Console.WriteLine(sum);



        
        
    }
    
    Console.WriteLine(sum);
    //close the file
    reader.Close();
    Console.ReadLine();
    
    
}
catch(Exception e)
{
    Console.WriteLine("Exception: " + e.Message);
}
finally
{
    Console.WriteLine("Executing finally block.");
}


