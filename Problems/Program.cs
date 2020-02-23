using System;

namespace Problems
{
    public class Program
    {
         static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(Program.Prefix("what    ...  did you say?? "));
            Console.ReadLine();
        }

        public static string Prefix(string str)
        {
            if(str =="")
            {
                return "0,0:";
            }
            else
            {
                int strLeng = str.Length;
                int numWords = 0;
                string[] strArr = str.Split();
                
                for(int i = 0; i<strArr.Length; i+=1 )
                {
                    
                    if(isWord(strArr[i]))
                    {
                        numWords +=1;
                    }

                }
                return strLeng+","+numWords+":"+str;
            }
        }

        private static bool isWord(string str)
        {
            string[] symbols = new string[32]{" ","0","1","2","3","4","5","6","7","8","9","!","@","#","$","%","^","&","*","(",")","{","}","[","]",":","|","<",">",",","/","?"};
            bool isword = true;
            for(int j = 0; j<32; j+=1 )
            {
                if(str.Equals(""))
                {
                    isword=false;
                }        
                else if(str[0].Equals(symbols[j]))
                {
                    isword=false;            
                }
                        
            }
            if(isword==true)
            {
               return true;
            }
            return false;
        }
    }
}
