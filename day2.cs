// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.IO;




try
{
    using StreamReader reader = new StreamReader("day2.txt");
    string line;
    int j = 1;
    int sum = 0;;
    char[] separaterChars = { ':', ',', ';'};
    bool allChecked = true;
    int red = 0;
    int blue = 0;
    int green = 0;

    while ((line = reader.ReadLine()) != null)
    {
        line = line.Replace(" ", string.Empty);
        string[] inputArray = line.Split(separaterChars);

        foreach(string input in inputArray){
            string check = input;
            //Console.WriteLine(check[0]);
            int num;
            if(check.Contains("blue")){
                
                if (Char.IsDigit(check[1])){
                    num = int.Parse(check[0].ToString())*10 + int.Parse(check[1].ToString());
                }
                else{                    
                    num = int.Parse(check[0].ToString());
                }
                Console.WriteLine(num);
                if(num > blue){
                    blue = num;;
                }
                Console.WriteLine($" blue {blue}");
            }
            if(check.Contains("red")){
                if (Char.IsDigit(check[1])){
                    num = int.Parse(check[0].ToString())*10 + int.Parse(check[1].ToString());
                }
                else{
                    num = int.Parse(check[0].ToString());
                }
                if(num > red){
                    red = num;
                }
                Console.WriteLine($" red {red}");
            }
            if(check.Contains("green")){
                if (Char.IsDigit(check[1])){
                    num = int.Parse(check[0].ToString())*10 + int.Parse(check[1].ToString());
                }
                else{
                    num = int.Parse(check[0].ToString());
                }
                if(num > green){
                    green = num;
                }
                Console.WriteLine($" green {green}");
            }            
        }
        //Console.WriteLine(allChecked);
        /*if(allChecked){
            sum += j;
        }*/
        int pow = red*blue*green;
        Console.WriteLine(pow);
        sum += pow;
        allChecked=true;
        //Console.WriteLine(sum);
        j++;
        red = 0;
        blue = 0;
        green = 0;
        



        
        
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


