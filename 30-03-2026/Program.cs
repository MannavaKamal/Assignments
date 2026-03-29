using System.Collections;
using System.Collections.Generic;

namespace _30_03_2026;

internal class Program
{
    static void Main(string[] args)
    {
        // 1> Create a poc on  List,Set,Dictionary . Do crud operation on each
        List();
        HashSet();
        Dictionary();
        //2> Create an employee polymorhism application where each employee have id,name,basicSalary . Specific employees are Manager,Developer and Tester.
        List<Employee> employees = new List<Employee>()
        {
            new Manager(1, "Alice", 50000),
            new Developer(2, "Bob", 40000),
            new Tester(3, "Charlie", 30000)
        };

        foreach (Employee emp in employees)
        {
            emp.Display();  
        }
    }

    static void List()
    {
     //List
        List<int> myList = new List<int> ();
        //Add
        myList.Add (1);
        myList.Add (2);
        myList.Add(3);
        Console.WriteLine("Initial List: " + string.Join(", ", myList));
        //Read
        Console.WriteLine("Element at index 1: " + myList[1]);
        //Update
        myList[1] = 20; // updating the value at index 1
        Console.WriteLine("After updating the element at index 1  =  " + string.Join(", ", myList));
        //Delete
        myList.Remove(1);
        Console.WriteLine("My List After All operations = " + string.Join(", ", myList));
    }
    
    static void HashSet()
    {
        HashSet<int> myHashSet = new HashSet<int>();
        //Add
        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);
        myHashSet.Add(3);
        Console.WriteLine("Initial List: " + string.Join(", ", myHashSet));
        //Read
        Console.WriteLine("Element at index 1: " + myHashSet.ElementAt(1));        
        List<int> myList =  myHashSet.ToList();
        //Update 
        myList[1] = 10; // Updating the element at index 1
        Console.WriteLine("After updating: " + string.Join(", ", myList));
        //Delete
        myList.RemoveAt(1); // removing the element at index 1
        //Converting List to HashSet
        myHashSet = new HashSet<int>(myList);
        Console.WriteLine("Final List: " + string.Join(", ", myHashSet));

    }

    static void Dictionary()
    {
        Dictionary<int , string> myDic = new Dictionary<int , string>();
        //Add or Create
        myDic.Add(1, "pen");
        myDic.Add(2, "book");
        myDic.Add(3, "color");
        myDic.Add(4, "pencil");

        //Read
        Console.WriteLine(myDic[1]);// value based on key
        //Update
        myDic[2] = "color book"; // updating the value bsed on key
        //Delete
        myDic.Remove(3);// removing the element based on key
        //printing the final emelents
        foreach (KeyValuePair<int,string> kvp in myDic)
        {
            Console.WriteLine(kvp.Key + " : " + kvp.Value);
        }
    }
}
