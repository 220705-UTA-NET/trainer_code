using System;

namespace Neighbors
{
    public class Test
    {
        public int minDist(int N, int[] A)
        {
            Array.Sort(A);
            int dist = A[N-1];

            for (int i = 2; i < N; i++)
            {
                int check = A[i] - A[i-2];

                if (check < dist)
                    dist = check;
            }

            return dist;
        }
    }
}
