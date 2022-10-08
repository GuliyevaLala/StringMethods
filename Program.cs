using System;

namespace StringsClasswork
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ClassTask
            //int a = 9;
            //int b = a;
            //b = 12;
            //Console.WriteLine(a + "  " + b);

            //int[] nums = { 4, 77, 1, 36, 20, 58 };
            //int[] nums1 = nums;
            //nums1[0] = 9;
            //Console.WriteLine(nums[0] + "  " + nums1[0]);

            //int num = 25;
            //ShowNumber(num);
            //Console.WriteLine(num);

            //int num = 25;
            //Console.WriteLine(num);
            //num += 5;
            //ShowNumber(num);
            //Console.WriteLine(num);

            //int num = 30;
            //Console.WriteLine(num);
            //num += 10;
            //ShowNumber(num);
            //num -= 5;
            //Console.WriteLine(num);

            //int num = 30;
            //num += 5;
            //ShowNumber(ref num);
            //Console.WriteLine(num);

            //int num;
            //ShowNumber(out num);
            //num += 10;
            //Console.WriteLine(num);


            //string name1 = "Audrey";
            //name1 = "Ali";
            //Console.WriteLine(name1);

            //string name = "Audrey";
            //string name1 = name;
            //name1 = "Ali";
            //Console.WriteLine(name);
            //Console.WriteLine(name1);

            //string name;
            //Check(out name);
            //Console.WriteLine(name);

            //StringBuilder name = new StringBuilder();
            //name.Append("La");
            //name.Append("la");
            //Console.WriteLine(name);

            //string name1 = "Lana";
            //string name2 = "Del Rey";
            //string result = name1 + name2;
            //Console.WriteLine(result);

            //String name3 = new String("Smith");
            //Console.WriteLine(name3);

            //string name = "Audrey";
            //Console.WriteLine(name.Length);

            //string name = "RasulHasanov";
            //Console.WriteLine(name.Substring(3, 9));

            //string name = "        Audrey    ";
            //Console.WriteLine(name.Trim());

            //string name = String.Empty;
            //name = "";

            //string name = "Audrey";

            //Console.WriteLine(name.StartsWith("Aud"));

            //Console.WriteLine(name.EndsWith("rey"));

            //if (name.StartsWith("A"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Console.WriteLine(name.ToLower());

            //Console.WriteLine(name.ToUpper());

            //string name = "      Audrey   ";

            //name = name.ToUpper();
            //if (name.Trim().ToLower().StartsWith("a"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //string name = "Audrey";
            //Console.WriteLine(name.IndexOf("a"));

            //string name = "Abdullah";
            //Console.WriteLine(name.LastIndexOf("a"));

            //string name = "Smith";
            //name = name.Replace("Smith", "Audrey");
            //Console.WriteLine($"Hello, {name}");

            //string name = "Lana";
            //Console.WriteLine(name.Remove(4, 2));


            //string[] names = { "Lana", "John", "Laura" };
            //var result = string.Join("-", names);
            //Console.WriteLine(result);

            //string name = "Audrey";
            //if (string.IsNullOrEmpty(name))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //string text = null;
            //if (string.IsNullOrWhiteSpace(text))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion

            string firstname;
            string lastname;


            firstname = "Audrey";
            lastname = "Hepburn";


            Console.WriteLine(firstname.Clone());
            Console.WriteLine(firstname.CompareTo(lastname));
            Console.WriteLine(firstname.Contains("rey")); 
            Console.WriteLine(lastname.EndsWith("z")); 
            Console.WriteLine(firstname.Equals(lastname));
            Console.WriteLine(firstname.GetHashCode());
            Console.WriteLine(lastname.GetType());
            Console.WriteLine(firstname.GetTypeCode());
            Console.WriteLine(firstname.IndexOf("e")); 
            Console.WriteLine(lastname.ToLower());
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(lastname.Insert(0, "Hello"));
            Console.WriteLine(firstname.IsNormalized());
            Console.WriteLine(lastname.LastIndexOf("e")); 
            Console.WriteLine(firstname.Remove(3));
            Console.WriteLine(firstname.Replace('c', 'i'));
            string[] split = firstname.Split(new char[] { 'e' });
            Console.WriteLine(split[0]);
            Console.WriteLine(split[1]);
            Console.WriteLine(split[2]);

            Console.WriteLine(firstname.StartsWith("A"));

            Console.WriteLine(lastname.Substring(2, 5));

            Console.WriteLine(firstname.ToCharArray());

            Console.WriteLine(lastname.Trim());


        }
    }
}

      