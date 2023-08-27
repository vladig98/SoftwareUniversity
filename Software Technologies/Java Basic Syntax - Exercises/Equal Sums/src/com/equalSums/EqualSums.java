package com.equalSums;

import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        for (int i = 0; i < numbers.length; i++)
        {
            int sumLeft = 0;
            int sumRight = 0;
            for (int j = 0; j < i; j++)
            {
                sumLeft += numbers[j];
            }
            for (int j = i + 1; j < numbers.length; j++)
            {
                sumRight += numbers[j];
            }
            if (sumLeft == sumRight)
            {
                System.out.println(i);
                return;
            }
        }

        System.out.println("no");
    }
}
