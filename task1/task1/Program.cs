// See https://aka.ms/new-console-template for more information

string targetString = "";

if (args.Length == 1)
{
    // You have 1 argument. Save this argument
    targetString = args[0];
    Console.WriteLine(targetString);
}
else
{
    Console.WriteLine("You doesn't have 1 arguments. Exit");
    Console.Read();
    return;
}

int max_count = 0;
int count = 1;
char previus_simbol = targetString[0]; // Inicialize as first char from target string

// I stay commented console output for debug

for (int i = 1; i < targetString.Length; i = i + 1)
{
    //Console.WriteLine("Previous: " + previus_simbol);
    //Console.WriteLine("current: " + targetString[i]);

    if (targetString[i] != previus_simbol)
    {
        // Console.WriteLine("this is true");
        count = count + 1;
    }
    else
    {
        //Console.WriteLine("This is false");
        count = 1;
    }
    if (max_count < count)
    {
        max_count = count;
        //Console.WriteLine("New max count");
    }
    previus_simbol = targetString[i];
    //Console.WriteLine("___________Current count = " + count + "  Max count = " + max_count);

}

Console.WriteLine("After for we have Max count = " + max_count);


// read symbol for awaiting
Console.Read();