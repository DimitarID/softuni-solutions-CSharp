﻿int n = int.Parse(Console.ReadLine());
int leftSum = 0;

for (int i = 1; i <= n; i++)
{
    leftSum = leftSum + int.Parse(Console.ReadLine());
}

int rightSum = 0;

for (int i = 0; i < n; i++)
{
    rightSum += int.Parse(Console.ReadLine());
}

if (leftSum == rightSum)
{
    Console.WriteLine("Yes, sum = " + leftSum);
}

else
{
    int diff = Math.Abs(rightSum - leftSum);
    Console.WriteLine("No, diff = " + diff);
}