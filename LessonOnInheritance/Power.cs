using System;
using System.Collections.Generic;
using System.Text;

namespace LessonOnInheritance
{
    class Power
    {
        int x, y;

        public int PowerNum(int x, int y) 
        {
            int X = x;
            for (int i = 1; i < y; i++)
            {
                X *= x;
            }

            return X;
        }

    }
}
