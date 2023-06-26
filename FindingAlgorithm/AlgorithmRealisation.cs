﻿using System;

namespace FindingAlgorithm
{

    public class AlgorithmRealisation
    {
        static void Main(string[] args)
        {
            int[] health = new int[10_000];
            int[] topValues = new int[10];
            AlgorithmRealisation p = new AlgorithmRealisation();

            p.FillArrayRandomly(health);
            p.MergeSort(health, 0, health.Length - 1);

            Array.Copy(health, health.Length - 10, topValues, 0, 10);
            p.DisplayArray(topValues);

            Console.Read();
        }

        public void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void FillArrayRandomly(int[] arr)
        {
            var random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, int.MaxValue);
            }
        }

        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        public void Merge(int[] array, int left, int middle, int right)
        {
            int[] temp = new int[right - left + 1];
            int i = left;
            int j = middle + 1;
            int k = 0;

            while (i <= middle && j <= right)
            {
                if (array[i] < array[j])
                {
                    temp[k] = array[i];
                    i++;
                }
                else
                {
                    temp[k] = array[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                temp[k] = array[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = array[j];
                j++;
                k++;
            }

            for (int x = 0; x < temp.Length; x++)
            {
                array[left + x] = temp[x];
            }
        }
    }
}
