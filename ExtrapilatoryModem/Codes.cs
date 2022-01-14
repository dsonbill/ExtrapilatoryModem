using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrapilatoryModem
{
    class Codes
    {
        public static int Mom { get { return GenerateNewRandom(23, 26); } }
        
        public static int Rand { get { return GenerateNewRandom(0, int.MaxValue); } }
        
        public static int Rand1 { get { return GenerateNewRandom(1, 4652); } }
        public static int Rand2 { get { return GenerateNewRandom(2, 28465); } }
        public static int Rand3 { get { return GenerateNewRandom(3, 79135); } }
        public static int Rand4 { get { return GenerateNewRandom(4, 465); } }
        public static int Rand5 { get { return GenerateNewRandom(5, 748195263); } }
        public static int Rand6 { get { return GenerateNewRandom(6, 748159623); } }
        public static int Rand7 { get { return GenerateNewRandom(7, 326951487); } }
        public static int Rand8 { get { return GenerateNewRandom(8, 784951623); } }
        
        public static int Rand9 { get { return GenerateNewRandom(4424, 4445413); } }
        public static int Rand10 { get { return GenerateNewRandom(44454144, 518181518); } }
        public static int Rand11 { get { return GenerateNewRandom(12345, 678910); } }
        
        public static int Rand12 { get { return GenerateNewRandom(666, 1074147); } }
        
        
        
        
        public static int PerfectSecret { get { return GenerateNewRandom(777, 072789); } }
        public static int ImperfectMasters { get { return GenerateNewRandom(1114, 1115); } }
        
        
        public static int Rand99 { get { return GenerateNewRandom(99, 75238); } }
        
        public static int Rand203 { get { return GenerateNewRandom(2, 8675309); } }
        
        public static int Rand777 { get { return GenerateNewRandom(0, 45132); } }
        
        public static int MarsArgo { get { return GenerateNewRandom(4, 1979); } }
        public static int Poppy { get { return GenerateNewRandom(336, 915); } }
        
        public static int Everyone { get { return GenerateNewRandom(0, 987564321); } }
        
        public static int Bill { get { return GenerateNewRandom(4, 7541329); } }
        
        public static int Sistersquid { get { return GenerateNewRandom(1, 4768); } }
        public static int Faux { get { return GenerateNewRandom(0, 3421); } }
        
        public static int Streams { get { return GenerateNewRandom(4, 8492); } }
        public static int Parallel { get { return GenerateNewRandom(3, 8429); } }
        
        public static int J { get { return GenerateNewRandom(4, 4652); } }
        
        public static int William { get { return GenerateNewRandom(1, 0135); } }
        
        public static int Order { get { return GenerateNewRandom(1, 776); } }
        public static int Perfect { get { return GenerateNewRandom(0, 667); } }
        
        public static int SpecialCode { get { return GenerateNewRandom(7, 31246); } }
        
        public static int HEARTBEAT { get { return GenerateNewRandom(0, 4826); } }
        
        public static int ChristsCode { get { return GenerateNewRandom(2, 123456789); } }
        
        public static int Anti { get { return GenerateNewRandom(2, 6); } }
        
        public static int Lucky { get { return GenerateNewRandom(777, 31427); } }
        
        public static int Adam { get { return GenerateNewRandom(1, 67932); } }
        
        public static int BASAL_GANGLIA { get { return GenerateNewRandom(2, 4861); } }
        
        public static int Down { get { return GenerateNewRandom(9, 75321); } }
        
        public static int Latch { get { return GenerateNewRandom(0, 4513); } }
        
        public static int Mommy_type_lorena { get { return GenerateNewRandom(4, 123432); } }
        
        public static int Fishy { get { return GenerateNewRandom(3, 4651); } }
        
        public static int T { get { return GenerateNewRandom(4, 8531); } }
        
        public static int TheFour { get { return GenerateNewRandom(0, 4682); } }
        
        public static int Mirror { get { return GenerateNewRandom(4, 44123); } }
        
        public static int Arrow { get { return GenerateNewRandom(19, 77236); } }
        
        public static int Thelink { get { return GenerateNewRandom(4, 1324); } }
        
        public static int Dim { get { return GenerateNewRandom(7, 14267); } }
        
        public static int Reducer { get { return GenerateNewRandom(0, 85426); } }
        
        public static int Right { get { return GenerateNewRandom(4, 15896); } }
        
        public static int Redo { get { return GenerateNewRandom(5, 87412); } }
        
        public static int Eli { get { return GenerateNewRandom(56, 2212); } }
        
        public static int Wall { get { return GenerateNewRandom(14, 369); } }
        
        public static int Colin1 { get { return GenerateNewRandom(4, 9874123); } }
        
        public static int Colin2 { get { return GenerateNewRandom(3, 1473856); } }
        
        public static int Colin3 { get { return GenerateNewRandom(2, 1478963); } }
        
        public static int Dani { get { return GenerateNewRandom(10, 3482); } }
        
        public static int MottAlot { get { return GenerateNewRandom(44, 217); } }
        
        public static int Media_code { get { return GenerateNewRandom(0, 5555555); } }
        
        public static int L0 { get { return GenerateNewRandom(0, 703521); } }
        
        public static int A { get { return GenerateNewRandom(1, 38114957); } }
        
        public static int S { get { return GenerateNewRandom(268635, 4012897); } }
        
        
        
        public static int Unresolved { get { return GenerateNewRandom(404, 667); } }

        public static int OnTheLetter { get { return GenerateNewRandom(1, 4310); } }





        static System.Random r = new System.Random();
        static int GenerateNewRandom(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
