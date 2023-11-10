// DON'T FORGET CREATE THE FOLDER AND CHANGE THIS
string file = "C:\\Users\\UPN\\Documents\\GitHub\\UPN_ESDAT\\Files\\LocalFiles\\data.txt";

// With using is more efficent
// Here, we are creating a file with this sentence
using(StreamWriter sw = new StreamWriter(file))
{
    int aux = 0;
    while (aux <= 10)
    {
        sw.WriteLine(aux); 
        aux++;
    }

    List<string> list = new List<string> { "A", "B", "C", "D", "F"};

    foreach (var item in list)
    {
        sw.WriteLine(item);
    }
}