package com.booleanVariable;

import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        boolean isTrue = Boolean.parseBoolean(input);

        String output = "";

        output = isTrue == true ? "Yes" : "No";

        System.out.println(output);
    }
}
