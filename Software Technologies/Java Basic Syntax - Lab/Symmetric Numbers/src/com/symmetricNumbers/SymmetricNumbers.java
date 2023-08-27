package com.symmetricNumbers;

import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.next();

        int number = Integer.parseInt(input);

        for (int i = 1; i <= number; i++)
        {
            if (i == reverseInt(i))
            {
                if (i == 1)
                {
                    System.out.print(i);
                }
                else
                {
                    System.out.print(" " + i);
                }
            }
        }
    }

    public static int reverseInt(int input) {
        long reversedNum = 0;
        long input_long = input;

        while (input_long != 0) {
            reversedNum = reversedNum * 10 + input_long % 10;
            input_long = input_long / 10;
        }

        return (int) reversedNum;
    }
}
