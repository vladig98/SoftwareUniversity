package com.sumNIntegers;

import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        int sum = 0;
        Scanner scan = new Scanner(System.in);
        int readUntil = scan.nextInt();
        for (int i = 0; i < readUntil; i++)
        {
            sum += scan.nextInt();
        }
        System.out.println("Sum = " + sum);
    }
}
