using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrapilatoryModem
{
    public class ACMemory
    {
        readonly float min = 500;
        readonly float max = 2500;

        char space = " ".ToCharArray()[0];
        char relative = "$".ToCharArray()[0];
        char platform = "#".ToCharArray()[0];

        public float degree = 360;
        public float ejection = 40;

        public float signal = 4.7912f;

        public Dictionary<char, float> Data = new Dictionary<char, float>();

        System.Random r = new System.Random();
        public int GenerateNewRandom(int min, int max)
        {
            return r.Next(min, max);
        }

        float RecoverData(double obfuscated)
        {
            float Proof = (float)Math.Sqrt(obfuscated) * signal;
            Proof = (Proof * (float)obfuscated) + 2;
            Proof = Proof / (float)obfuscated;
            Proof = Proof * ejection;
            Proof = Proof - degree;
            Proof = Proof / ejection;
            Proof = Proof * (float)obfuscated;
            Proof = Proof / ((float)obfuscated - 2);
            //Snap-Point
            Proof = Proof / ((float)obfuscated + 2);
            Proof = Proof * (float)obfuscated;
            Proof = Proof / ejection;
            Proof = Proof + degree;
            Proof = Proof * ejection;
            Proof = Proof / (float)obfuscated;
            Proof = (Proof * (float)obfuscated) + 2;
            Proof = (float)Math.Sqrt(Proof) * signal;

            return Proof;
        }

        string ReplacementSystem(string input, char replacement, int start, int end)
        {
            string output = input;
            for (int i = start; i <= end; i++)
            {
                output = output.Replace((char)i, replacement);
            }
            return output;
        }


        float ScaleBetweenNumber(float measurement, float scaleMin, float scaleMax)
        {
            return ((measurement - min) / (max - min)) * (scaleMax - scaleMin) + scaleMin;
        }

        public string GetOutput(double input)
        {
            return ((char)((int)ScaleBetweenNumber(RecoverData(input), 0, 24) + 65)).ToString();
        }

        public char[] Transpose()
        {
            string output = "";

            output += GetOutput(Codes.Mom);
            output += GetOutput(Codes.Rand);
            output += GetOutput(Codes.Rand1);
            output += GetOutput(Codes.Rand2);
            output += GetOutput(Codes.Rand3);
            output += GetOutput(Codes.Rand4);
            output += GetOutput(Codes.Rand5);
            output += GetOutput(Codes.Rand6);
            output += GetOutput(Codes.Rand7);
            output += GetOutput(Codes.Rand8);
            output += GetOutput(Codes.Rand9);
            output += GetOutput(Codes.Rand10);
            output += GetOutput(Codes.Rand11);
            output += GetOutput(Codes.Rand12);
            output += GetOutput(Codes.PerfectSecret);
            output += GetOutput(Codes.ImperfectMasters);
            output += GetOutput(Codes.Rand99);
            output += GetOutput(Codes.Rand203);
            output += GetOutput(Codes.Rand777);
            output += GetOutput(Codes.MarsArgo);
            output += GetOutput(Codes.Poppy);
            output += GetOutput(Codes.Everyone);
            output += GetOutput(Codes.Bill);
            output += GetOutput(Codes.Sistersquid);
            output += GetOutput(Codes.Faux);
            output += GetOutput(Codes.Streams);
            output += GetOutput(Codes.Parallel);
            output += GetOutput(Codes.J);
            output += GetOutput(Codes.William);
            output += GetOutput(Codes.Order);
            output += GetOutput(Codes.Perfect);
            output += GetOutput(Codes.SpecialCode);
            output += GetOutput(Codes.HEARTBEAT);
            output += GetOutput(Codes.ChristsCode);
            output += GetOutput(Codes.Anti);
            output += GetOutput(Codes.Lucky);
            output += GetOutput(Codes.Adam);
            output += GetOutput(Codes.BASAL_GANGLIA);
            output += GetOutput(Codes.Latch);
            output += GetOutput(Codes.Mommy_type_lorena);
            output += GetOutput(Codes.Fishy);
            output += GetOutput(Codes.T);
            output += GetOutput(Codes.TheFour);
            output += GetOutput(Codes.Mirror);
            output += GetOutput(Codes.Arrow);
            output += GetOutput(Codes.Thelink);
            output += GetOutput(Codes.Dim);
            output += GetOutput(Codes.Reducer);
            output += GetOutput(Codes.Right);
            //output += GetOutput(Codes.Redo);
            output += GetOutput(Codes.Eli);
            output += GetOutput(Codes.Wall);
            output += GetOutput(Codes.Colin1);
            output += GetOutput(Codes.Colin2);
            output += GetOutput(Codes.Colin3);
            output += GetOutput(Codes.MottAlot);
            output += GetOutput(Codes.Dani);
            output += GetOutput(Codes.Media_code);
            //output += GetOutput(Codes.L0);
            //output += GetOutput(Codes.A);
            //output += GetOutput(Codes.S);
            //output += GetOutput(Codes.Unresolved);
            //output += GetOutput(Codes.OnTheLetter);


            //Encoding
            string theory = output.Replace((char)66, space).Replace((char)65, space);

            char[] encoded = theory.ToCharArray();

            return encoded;
        }

        public void SetMemory(char[] data)
        {
            //Memory System
            string target = data[1].ToString();


            string dataString = "";
            foreach(char c in data)
            {
                dataString += c.ToString();
            }

            StringBuilder sb = new StringBuilder(dataString);
            sb[16] = " ".ToCharArray()[0];
            sb[20] = " ".ToCharArray()[0];
            sb[22] = " ".ToCharArray()[0];
            sb[33] = " ".ToCharArray()[0];

            string theory = sb.ToString();
            theory = theory.Replace(" ", "");

            string solver = data[51].ToString() + data[52].ToString() + data[53].ToString();

            Func<int, double> solverFunction = (input) => { return 0; };
            switch(solver)
            {
                case "D":
                    solverFunction = (input) => { return DecimalFuntion((double)input); };
                    break;
                case "C":
                    solverFunction = (input) => { return VariableFunction((double)input); };
                    break;
                case "DC":
                    solverFunction = (input) => { return DecimalFuntion(VariableFunction((double)input)); };
                    break;
                case "CC":
                    solverFunction = (input) => { return VariableFunction(VariableFunction((double)input)); };
                    break;
                case "DCC":
                    solverFunction = (input) => { return DecimalFuntion(VariableFunction(VariableFunction((double)input))); };
                    break;
                case "CCC":
                    solverFunction = (input) => { return VariableFunction(VariableFunction(VariableFunction((double)input))); };
                    break;
            }

            char[] arr = theory.ToCharArray();
            float x = 0;

            bool check = false;
            foreach (Char c in arr)
            {
                if (!check)
                {
                    check = true;
                    continue;
                }
                x += (float)solverFunction((int)c);
            }

            Data[arr[0]] = x;
        }

        double DecimalFuntion(double data)
        {
            return data - 65;
        }

        double VariableFunction(double data)
        {
            double Y = Math.Asin((signal / Math.Sin(degree)) / ejection);
            double a = 180 - degree - Y;

            double i = (Math.Sin(a) * ejection) / Math.Sin(degree);

            return i * data;
        }


    }
}