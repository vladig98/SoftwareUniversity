package com.maxSequenceOfEqualElements;

import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int currentNumber = numbers[0];
        int currentLength = 1;
        int bestNumber = numbers[0] - 1;
        int longestLength = -1;
        Boolean hasFailed = false;

        for (int i = 0; i < numbers.length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                currentLength++;
            }
            else
            {
                hasFailed = true;
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    bestNumber = currentNumber;
                }
                currentLength = 1;
                currentNumber = numbers[i + 1];
            }
        }

        if (bestNumber == numbers[0] - 1 && hasFailed == false)
        {
            bestNumber = currentNumber;
        }

        if (longestLength == -1)
        {
            longestLength = currentLength;
        }

        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            bestNumber = currentNumber;
        }

        System.out.println(new String(new char[longestLength]).replace("\0", bestNumber + " "));
    }
}
