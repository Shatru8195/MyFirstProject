using Assignment3_Lead_ITC_.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Lead_ITC_
{
    class Program
    {
        static void Main(string[] args)
        {

            ExecutionClass execution = new ExecutionClass();
            //execution.AccessCode();

            ReadXmlAllData readXmlAll = new ReadXmlAllData();
            //readXmlAll.ReadXmlValueFun();
            readXmlAll.ReadAllXmlValue();
            Console.ReadLine();
        }
    }
}
