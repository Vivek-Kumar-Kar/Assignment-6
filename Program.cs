﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] studentScores = new int[3][];
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            Console.WriteLine("Scores of each student:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write($"{studentScores[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nAverage score of each student:");
            for (int i = 0; i < studentScores.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = (double)sum / studentScores[i].Length;
                Console.WriteLine($"Student {i + 1}: {average:F2}");
            }
            Console.WriteLine("Average score for all students combined:");
            int totalSum = 0;
            int totalCount = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }
            double totalAverage = (double)totalSum / totalCount;
            Console.WriteLine($"{totalAverage:F2}");



        }
    }
}
