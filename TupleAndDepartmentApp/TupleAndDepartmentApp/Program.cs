using AppClasses.Models;
using System.Diagnostics;

namespace TupleAndDepartmentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tuple task
            //1. int arrayi qebul eden methodunuz olur. Bu arraydeki tek ve cut ededlerin cemini toplayib geriye qaytaran method yazirsiniz.
            //Yeni: bu method sonda geriye Teklerin cemini ve Cutlerin cemini qaytarir. (Tuple)

            //int[] numberArray = { 2, 3, 4, 6, 11, 12, 7, 17, 18, 19, 20, 21 };
            //SumOfEvenOddNumbers(numberArray);
            #endregion

            #region DepartmentConsoleApp
            Department department = new Department();

            Console.Write("Yeni Department yaradin: ");
            string departmentName = Console.ReadLine();
            department.Name = departmentName;


            string option;
            do
            {
                Console.WriteLine("\nChoose operation");
                Console.WriteLine($"1. Isci yarat ve {departmentName} Departmentine elave et" +
                    "\n2. Adina gore isci axtar " +
                    "\n3. Tecrubeye gore isci axtar" +
                    "\n4. Butun iscileri goster" +
                    "\n0. Proqrami bitir");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        department.AddWorker(CreateWorker());
                        break;
                    case "2":
                        Console.Write("axtaris ucun ad daxil edin: ");
                        string searchedName = Console.ReadLine();
                       
                        department.SearchWorker(searchedName);
                        break;
                    case "3":
                        string maxSearchedExper;
                        string minSearchedExper;
                        double max;
                        double min = 0;
                        bool parse1;
                        bool parse2;
                        Console.Write("axtaris ucun tecrube araligi daxil edin");
                        do
                        {
                            Console.Write("\nmaximum deyer daxil edin: ");
                            maxSearchedExper = Console.ReadLine();
                            Console.Write("minimum deyer daxil edin: ");
                            minSearchedExper = Console.ReadLine();

                            parse1 = double.TryParse(maxSearchedExper, out max);
                            parse2 = double.TryParse(minSearchedExper, out min);

                            if (!parse1 && !parse2)
                            {
                                Console.Write("deyerleri duzgun daxil edin");
                            }

                        } while (!parse1 && !parse2);

                        department.SearchWorker(min, max);
                        break;
                    case "4":
                        department.ShowAllWorkers();
                        break;
                    default:
                        break;
                }
            } while (option != " ");
            #endregion

        }

        public static (int even, int odd) SumOfEvenOddNumbers(int[] numArr)
        {
            int sumEven = 0;
            int sumOdd = 0;

            foreach (int num in numArr)
            {
                if (num % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }

            }
            Console.WriteLine($"Cut ededlerin cemi:{sumEven} , Tek ededlerin cemi:{sumOdd}");

            return (sumEven, sumOdd);
        }

        public static Worker CreateWorker()
        {

            Console.Write("Isci adini daxil edin: ");
            string workerName = Console.ReadLine();

            Console.Write("Isci Soyadini daxil edin: ");
            string workerSurname = Console.ReadLine();

            double experience;
            string experStr;

            do
            {
                Console.Write("Iscinin tecrubesini daxil edin:");
                experStr = Console.ReadLine();

            } while (!double.TryParse(experStr, out experience));

            Worker worker = new Worker(workerName.Trim(), workerSurname.Trim(), experience);

            return worker;

        }


    }
}