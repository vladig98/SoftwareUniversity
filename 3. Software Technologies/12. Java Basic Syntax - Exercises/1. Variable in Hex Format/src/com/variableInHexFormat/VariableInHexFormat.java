package com.variableInHexFormat;

import java.util.Scanner;

public class VariableInHexFormat {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        int number = Integer.parseInt(input, 16);

        System.out.println(number);
    }
}
