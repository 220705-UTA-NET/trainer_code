using System;

namespace MinMax
{
    public class Test
    {
        public int addingNumbers(string line)
        {
            int x, y;

            char[] ch = new char[line.Length];

            for (int i = 0; i < line.Length; i++)
            {
                ch[i] = line[i];
            }

            int a1 = Array.IndexOf(ch, 'a');
            int a2 = Array.LastIndexOf(ch, 'a');

            x = a2 - a1;

            var bPos = new List<int>();

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'b')
                    bPos.Add(i);
            }

            y = bPos.Count;

            for (int i = 1; i < bPos.Count; i++)
            {
                int check = (bPos[i] - bPos[i-1]);
                if (check < y)
                    y = check;
            }

            int result = x + y;
            return result;
        }
    }
}
