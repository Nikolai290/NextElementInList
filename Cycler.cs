using System;
using System.Collections.Generic;

namespace TestQuest
{
    public class Cycler
    {
        private List<string> list;
        private int iterator = 0;

        public Cycler(List<String> inputList)
        {
            list = inputList;

        }
        public string GetNext()
        {
            string outLine = list[iterator];

            if (iterator < list.Count-1)
                iterator++;
            else
                iterator = 0;

            return outLine;
        }


    }
}
