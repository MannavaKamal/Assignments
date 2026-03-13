namespace _04_03_2026_Class_diagram_creation_and_Coding_standards__ArrayTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = { "Kamal", "Ravi", "Anu" };
            // string details using forLoop
            for (int i = 0; i < stringArr.Length; i++)
            {
                Console.WriteLine(stringArr[i]);
                Console.WriteLine($"index = {i}");
                Console.WriteLine($"string length = {stringArr[i].Length}");
            }
            // string details using forEach
            int j = 0;
            foreach (string name in stringArr)
            {
                Console.WriteLine(name);
                Console.WriteLine($"index = {j++}");
                Console.WriteLine($"string length = {name.Length}");
            }
        }
    }
}
