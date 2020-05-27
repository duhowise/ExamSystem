using System;

namespace ExamSystem
{
    public static class Shuffle
    {
        private static Random rand = new Random();

        public static void DoShuffle(this int[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int temp = objects[i];
                objects[i] = objects[j];
                objects[j] = temp;
            }
        }

    }
}
