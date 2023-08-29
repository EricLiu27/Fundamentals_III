// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//1. Iterate and print values

static void PrintList(List<string> MyList)
{
    // Your code here
    foreach (string name in MyList)
    {
        Console.WriteLine(name);

    }

}
List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
PrintList(TestStringList);


//2. Print Sum

static void SumOfNumbers(List<int> IntList)
{
    // Your code here
    int sum = 0;
    int i = 0;
    while (i < IntList.Count)
    {
        sum += IntList[i];
        i++;
    }
    Console.WriteLine(sum);

}
List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
// You should get back 33 in this example
SumOfNumbers(TestIntList);




//3. Find Max

static int FindMax(List<int> IntList)
{
    // Your code here
    int max = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        if (IntList[i] > max)
        {
            max = IntList[i];
        }
    }
    Console.WriteLine(max);
    return max;


}
List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
// You should get back 17 in this example
FindMax(TestIntList2);


//4. Square the Values

static List<int> SquareValues(List<int> IntList)
{
    // Your code here

    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] *= IntList[i];
        Console.WriteLine(IntList[i]);

    }
    // foreach(int number in IntList)
    // {
    //     Console.WriteLine(number);

    // }
    return IntList;

}
List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);


//5. Replace Negative Numbers with 0

static int[] NonNegatives(int[] IntArray)
{
    // Your code here
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);


//6. Print Dictionary

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    // Your code here
    foreach (KeyValuePair<string, string> heroes in MyDictionary)
    {
        Console.WriteLine($"{heroes.Key} - {heroes.Value}");
    }
}
Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", " Genius, billionaire, playboy, philanthropist");
PrintDictionary(TestDict);





//7. Find Key

static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    // Your code here
    foreach (string key in MyDictionary.Keys)
    {
        if (SearchTerm == key)
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));





//8. Generate a Dictionary

// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    Dictionary<string, int> pairs = new Dictionary<string, int>();
    for (int i = 0; i < Names.Count; i++)
    {
        pairs.Add(Names[i], Numbers[i]);
    }
    return pairs;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
static void TestDictionary(Dictionary<string, int> MyDictionary)
{
    // Your code here
    foreach (KeyValuePair<string, int> heroes in MyDictionary)
    {
        Console.WriteLine($"{heroes.Key} - {heroes.Value}");
    }
}
List<string> name = new List<string>() { "Julie", "Harold", "James", "Monica" };
List<int> number = new List<int>() { 6, 12, 7, 10 };
TestDictionary(GenerateDictionary(name, number));