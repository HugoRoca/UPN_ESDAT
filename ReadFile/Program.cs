string file = "C:\\Users\\UPN\\Documents\\GitHub\\UPN_ESDAT\\ReadFile\\File\\Data.txt";

// Method that create file 
string[] fileLines = File.ReadAllLines(file);

/*
 1. Open file
 2. Count lines
 3. Create array with lines length
 4. Set value in variable
 5. Close the file0
 */

// Loop array lines
foreach (var item in fileLines)
{
    Console.WriteLine(item);
}