using System;

namespace RGBLights
{
    public class Test
    {
        public string RGBLight(string lights, int time)
        {
            string changed = "";
            char[] sequence = {'R', 'G', 'B'};    
            time = time % 3;

            foreach (char l in lights)
            {
                int pos = Array.IndexOf(sequence, l) + time;
                pos = pos % 3;
                changed = changed + sequence[pos];
            }

            return changed;
        }
    }
}
