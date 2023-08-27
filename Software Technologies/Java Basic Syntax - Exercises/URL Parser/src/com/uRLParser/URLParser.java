package com.uRLParser;

import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;

public class URLParser {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        String[] tokens = input.split("\\:\\/\\/");

        if (tokens.length != 1)
        {
            System.out.println("[protocol] = \"" + tokens[0] + "\"");
            String[] subTokens = tokens[1].split("\\/");
            if (subTokens.length != 1)
            {
                System.out.println("[server] = \"" + subTokens[0] + "\"");
                System.out.println("[resource] = \"" + Arrays.stream(subTokens).skip(1).collect(Collectors.joining("/")) + "\"");
            }
            else
            {
                System.out.println("[server] = \"" + subTokens[0] + "\"");
                System.out.println("[resource] = \"\"");
            }
        }
        else
        {
            System.out.println("[protocol] = \"\"");
            String[] subTokens = tokens[0].split("\\/");
            if (subTokens.length != 1)
            {
                System.out.println("[server] = \"" + subTokens[0] + "\"");
                System.out.println("[resource] = \"" + Arrays.stream(subTokens).skip(1).collect(Collectors.joining("/")) + "\"");
            }
            else
            {
                System.out.println("[server] = \"" + subTokens[0] + "\"");
                System.out.println("[resource] = \"\"");
            }
        }
    }
}
