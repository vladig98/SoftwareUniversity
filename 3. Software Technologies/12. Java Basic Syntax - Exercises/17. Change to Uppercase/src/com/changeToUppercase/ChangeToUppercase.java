package com.changeToUppercase;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ChangeToUppercase {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        List<String> allMatches = new ArrayList<String>();
        Matcher m = Pattern.compile("<upcase>(.*?)<\\/upcase>").matcher(input);

        while (m.find())
        {
            allMatches.add(m.group(1));
        }

        String[] tokens = input.split("<upcase>(.*?)<\\/upcase>");

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < tokens.length; i++)
        {
            result.append(tokens[i]);
            if (i < allMatches.size())
            {
                result.append(allMatches.get(i).toUpperCase());
            }
        }

        if (tokens.length == 0)
        {
            result.append(allMatches.get(0).toUpperCase());
        }

        System.out.println(result);
    }
}
