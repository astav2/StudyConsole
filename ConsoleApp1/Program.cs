using ConsoleApp1.Type.Call_FLow;
using ConsoleApp1.Type.DP;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Solution;
using ConsoleApp1.Type.Algorithms;
using ConsoleApp1.Type.DS;
using static ConsoleApp1.Type.BST.Binary_Inorder_Traversal;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Start();

        }

        private static void Start()
        {
            // new CallFlow().CreateWOTasksWithFlow();

            //new ContainsNearbyDuplicate2().ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            new ContainsNearbyAlmostDuplicate2().ContainsNearbyAlmostDuplicate(new int[] { -2147483648, 2147483647 },1,1);
        
            //int x1 = Convert.ToInt32(firstMultipleInput[0]);

            //int v1 = Convert.ToInt32(firstMultipleInput[1]);

            //int x2 = Convert.ToInt32(firstMultipleInput[2]);

            //int v2 = Convert.ToInt32(firstMultipleInput[3]);

            //string result = Result.kangaroo(x1, v1, x2, v2);
            //// new Solution().IsValid("()[]{}");          
            //new Solution().LetterCombinations("2458");
            //new Solution().LetterCombinations("");
            LinkedListNode<int> lists = new LinkedListNode<int>(2);

            //new Solution().RemoveNthFromEnd([1, 2, 3, 4, 5],2);
            // new Solution().ThreeSumClosest(new int[] { -1, 2, 1, -4, 4, 6, 7 },7);
        }
        //static void Main(string[] args)
        //{
        //    //ListNode head =insertListNode(new int[] { 1,2,6,3,4,5,6});
        //    int val = 6;
        //    string url = "https://uhsmcdev2.crm.dynamics.com:443/main.aspx?etc=3&id=73f055d3-42bd-eb11-8236-000d3a8d0fda&histKey=155920496&newWindow=true&pagetype=entityrecord";
        //    var x = url.Split('&');
        //    var id = x[1].Replace("id=", "");
        //    GroupByEx1();
        //}
        //public static void GroupByEx1()
        //{
        //    // Create a list of pets.
        //    List<Pet> pets =
        //        new List<Pet>{ new Pet { Name="Barley", Age=8 },
        //               new Pet { Name="Boots", Age=4 },
        //               new Pet { Name="Whiskers", Age=1 },
        //               new Pet { Name="Daisy", Age=4 } };

        //    // Group the pets using Age as the key value
        //    // and selecting only the pet's Name for each value.
        //    IEnumerable<IGrouping<int, string>> query =
        //        pets.GroupBy(pet => pet.Age, pet => pet.Name);
        //    DataTable dt = new DataTable();
        //    dt = ToDataTable(pets);
        //    var x=dt.AsEnumerable().GroupBy(r => r.Field<int>("Age")).Select(g=> g.Key);

        //    // Iterate over each IGrouping in the collection.
        //    foreach (IGrouping<int, string> petGroup in query)
        //    {
        //        // Print the key value of the IGrouping.
        //        Console.WriteLine(petGroup.Key);
        //        // Iterate over each value in the
        //        // IGrouping and print the value.
        //        foreach (string name in petGroup)
        //            Console.WriteLine("  {0}", name);
        //    }
        //}
        ///* private static ListNode insertListNode(int[] vs)
        // {

        // }*/
        //public static DataTable ToDataTable<T>(List<T> items)
        //{
        //    DataTable dataTable = new DataTable(typeof(T).Name);

        //    //Get all the properties
        //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo prop in Props)
        //    {
        //        //Defining type of data column gives proper data table 
        //        var type = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType);
        //        //Setting column names as Property names
        //        dataTable.Columns.Add(prop.Name, type);
        //    }
        //    foreach (T item in items)
        //    {
        //        var values = new object[Props.Length];
        //        for (int i = 0; i < Props.Length; i++)
        //        {
        //            //inserting property values to datatable rows
        //            values[i] = Props[i].GetValue(item, null);
        //        }
        //        dataTable.Rows.Add(values);
        //    }
        //    //put a breakpoint here and check datatable
        //    return dataTable;
        //}
    }
}
