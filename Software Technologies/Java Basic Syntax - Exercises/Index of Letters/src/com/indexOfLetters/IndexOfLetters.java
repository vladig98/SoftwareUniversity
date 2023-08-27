package com.indexOfLetters;

import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] chars = scan.nextLine().toCharArray();

        for (int i = 0; i < chars.length; i++)
        {
            System.out.println(chars[i] + " -> " + (chars[i] - 97));
        }
    }
}
