package com.largestThreeNumbers;

import java.util.Arrays;
import java.util.Scanner;

public class LargestThreeNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        numbers = Arrays.stream(numbers).sorted().toArray();

        for (int i = numbers.length - 1; i >= numbers.length - 3; i--)
        {
            if (i >= 0)
            {
                System.out.println(numbers[i]);
            }
        }
    }
}
