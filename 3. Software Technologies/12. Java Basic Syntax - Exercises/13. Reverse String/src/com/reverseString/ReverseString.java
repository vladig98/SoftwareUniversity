package com.reverseString;

import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        System.out.println(new StringBuilder(new String(input)).reverse().toString());
    }
}
