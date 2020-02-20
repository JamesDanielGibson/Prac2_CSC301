using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Prefix("hello there ."));
            Console.ReadLine();
        }

        public static string Prefix(string str)
        {
            if(str =="")
            {
                return "null";
            }
            else
            {
                int strLeng = str.Length;
                int numWords = 0;
                string[] strArr = str.Split();
                string[] symbols = new string[33]{"0","1","2","3","4","5","6","7","8","9","!","@","#","$","%","^","&","*","(",")","{","}","[","]",":","|","<",">",",","/","?","."," "};
                for(int i = 0; i<strArr.Length; i+=1 )
                {
                    bool isword = true;
                    for(int j = 0; j<symbols.Length; j+=1 )
                    {
                        if(strArr[i].Equals(symbols[j]))
                        {
                            isword=false;
                        }
                        
                    }
                    if(isword==true)
                    {
                        numWords+=1;
                    }

                }
                return strLeng+","+numWords+":"+str;
            }
        }
    }
}
