package com.fitStringInTwentyChars;

import java.util.Scanner;

public class FitStringInTwentyChars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        if (input.length() < 20)
        {
            System.out.println(input + "*".repeat(20 - input.length()));
        }
        else if (input.length() > 20)
        {
            System.out.println(input.substring(0, 20));
        }
        else
        {
            System.out.println(input);
        }
    }
}
