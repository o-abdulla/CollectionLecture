using System.Collections;     // package

// Generics my love <3
// Lists
List<decimal> prices = new List<decimal>();
prices.Add(1.99m);
prices.Add(2.99m);
prices.Add(5.00m);
prices.Insert(0, 3.99m);         // puts 3.99 in the beginning because of the 0
foreach (decimal p in prices)
{
    Console.WriteLine(p);
}
Console.WriteLine(prices[1]);
Console.WriteLine(prices.Count);       // how many objects in the array

int index = prices.IndexOf(2.99m);     // returns index of matching item. -1 if not found
prices[index] = 2.50m;      

prices.Remove(5.00m);               // remove by value
prices.RemoveAt(0);                 // remove by index
foreach (decimal p in prices)
{
    Console.WriteLine(p);
}

// Create list with starting values
List<string> shows = new List<string>()
{
    "Spongebob",
    "Breaking Bad",
    "The Price is Right"
};

foreach (string s in shows)
{
    Console.WriteLine(s);
}


// Dictionaries
Dictionary<string, bool> tasty = new Dictionary<string, bool>();
tasty.Add("Chicken Curry", true);
tasty.Add("Asparagus", false);

Console.WriteLine(tasty["Chicken Curry"]);

foreach (KeyValuePair<string, bool> kvp in tasty)       // (string is key, bool is value)
{
    if (kvp.Value == true)
    {
        Console.WriteLine($"{kvp.Key} is tasty!");
    }
    else
    {
        Console.WriteLine($"{kvp.Key} is nasty");
    }
}


// Excercises

// 1
// Create a list of strings
// loop
// Ask the user to enter text
// Add the input into the list
// Display all in list
// Ask if they want to add more

List<string> ex1 = new List<string>();
while (true)
{
    Console.WriteLine("Please enter some text");
    string input = Console.ReadLine();
    ex1.Add(input);
    foreach (string s in ex1)
    {
        Console.WriteLine(s);
    }
    Console.WriteLine("Continue? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        break;
    }
}


// 2
// Create a dictionary called translate
// key = string (English)
// value = string (Spanish)
// add 5 or more words to translate
// ask user for an english word
// display the translation (value)

Dictionary<string, string> translate = new Dictionary<string, string>();
translate.Add("hello", "hola");
translate.Add("food", "comida");
translate.Add("world", "mundo");
translate.Add("computer", "computadora");
translate.Add("exercise", "ejercicio");

Console.WriteLine("Please enter a word in english");
string english = Console.ReadLine();
if (translate.ContainsKey(english))
{
    string spanish = translate[english];
    Console.WriteLine($"{english} in spanish is {spanish}");
}
else
{
    Console.WriteLine("word doesn't exist");
}



















// --------------------------------------------------------------
// Non generics
// Do not use or else Justin will fight


//ArrayList trashList = new ArrayList();
//trashList.Add(2);
//trashList.Add(9);
//trashList.Add(new Random());
//trashList.Add(new ArrayList());
//foreach (var x in trashList)
//{
//    Console.WriteLine(x);
//}

//// hashtable
//Hashtable trashTable = new Hashtable();
//trashTable.Add("Taco Bell", 1234567890);
//trashTable.Add("Mcdonalds", "123-456-1212");

//Console.WriteLine(trashTable["Taco Bell"]);