using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ExtrapilatoryModem
{
    public class ACReceiver
    {
        readonly float min = 20000;
        readonly float max = 2.1474836e09F;

        char space = " ".ToCharArray()[0];
        char relative = "$".ToCharArray()[0];
        char platform = "#".ToCharArray()[0];

        public float degree = 360;
        public float ejection = 40;

        public float signal = 4.7912f;

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
            Proof = MathF.Sin(Proof) * 2;
            Proof = Proof / ((float)obfuscated + 2);
            Proof = Proof * (float)obfuscated;
            Proof = Proof / ejection;
            Proof = Proof + degree;
            Proof = Proof * ejection;
            Proof = Proof / (float)obfuscated;
            Proof = (Proof * (float)obfuscated) + 2;
            Proof = (float)Math.Pow(Proof, 2) * signal;

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
            output += GetOutput(Codes.Redo);
            output += GetOutput(Codes.Eli);
            output += GetOutput(Codes.Wall);
            output += GetOutput(Codes.Colin1);
            output += GetOutput(Codes.Colin2);
            output += GetOutput(Codes.Colin3);
            output += GetOutput(Codes.MottAlot);
            output += GetOutput(Codes.Dani);
            output += GetOutput(Codes.Media_code);
            output += GetOutput(Codes.L0);
            output += GetOutput(Codes.A);
            output += GetOutput(Codes.S);
            output += GetOutput(Codes.Unresolved);
            output += GetOutput(Codes.OnTheLetter);


            //Encoding
            string theory = output.Replace((char)65, relative);
            theory = theory.Replace((char)76, space);

            char[] encoded = theory.ToCharArray();

            bool carrier = encoded[34] == relative ? true : false;
            Console.WriteLine(carrier);

            string target = encoded[0].ToString();
            theory = theory.Replace(target.ToCharArray()[0], platform);
            encoded = theory.ToCharArray();


            return encoded;
        }

        
    }
}