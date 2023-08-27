package com.maxSequenceOfIncreasingElements;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int currentLength = 1;
        ArrayList<Integer> currentSequence = new ArrayList<>(Arrays.asList(numbers[0]));
        int bestLength = 0;
        ArrayList<Integer> bestSequence = new ArrayList<>();

        for (int i = 0; i < numbers.length - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                currentSequence.add(numbers[i + 1]);
                currentLength++;
            }
            else
            {
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestSequence = currentSequence;
                }
                currentLength = 1;
                currentSequence = new ArrayList<>(Arrays.asList(numbers[i + 1]));
            }
        }

        if (bestLength == 0)
        {
            bestLength = currentLength;
            bestSequence = currentSequence;
        }

        if (currentLength > bestLength)
        {
            bestLength = currentLength;
            bestSequence = currentSequence;
        }

        System.out.println(bestSequence.stream().map(Object::toString).collect(Collectors.joining(" ")));
    }
}
