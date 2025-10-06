// See https://aka.ms/new-console-template for more informat
using System.Linq.Expressions;

Console.WriteLine("HELLO MY NAME IS AIMAN");
int[] nums = new int[10];
for (int i = 0; i < 10; i++)

{
    Console.WriteLine("ENTER NUMBERS");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < 10; i++)
{
    Console.Write(nums[i] + " ");
}
Console.WriteLine();
int max = 0;
for(int i = 0; i < nums.Length; i++)
{
    if (max < nums[i])
    {
        max = nums[i];
    }
}

Console.WriteLine($" THE MAXIMUM NUMBER IN ARRAY IS {max}");
///COUNTING AN ELEMENT FREQUENCY IN C#
///

int count = 0;
int search = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < nums.Length; i++)
{
    if (search == nums[i])
    {
        count++;
    }
}
Console.WriteLine($"countt of {search} is {count}");
//IMPLEMENTING LINEAR SEARCH ALGORITHMS
Console.WriteLine("LINEAR SEARCH ALGORITHM");
bool element_found = false;
for(int i = 0; i < nums.Length; i++)
{
    if (nums[i] == search)
    {
        element_found = true;
    }
}
Console.WriteLine($"ELEMENT FOUND : {element_found}");

Console.WriteLine("COPYING ONE ELEMENT TO ANOTHER");
int [] nums_copy = new int [10];
for(int i = 0; i < nums.Length; i++)
{
    nums_copy[i] = nums[i];
}

Console.WriteLine("PRINTING COPIED ARRAY");
foreach(int i in nums_copy)
{
    Console.Write(i + " ");
}
Console.WriteLine("COLLECTION OF C# LANGAUGE");
List<int> reg_id = new List<int>();
reg_id.Add(2);
reg_id.Add(3);
reg_id.Add(1);
reg_id.Add(2);
reg_id.Add(1);
reg_id.Add(2);
reg_id.Add(9);
Console.WriteLine("MY REGISTRATION IDS");
foreach(int i in reg_id)
{
    Console.Write(i + "  ");
}

//Console.WriteLine("")