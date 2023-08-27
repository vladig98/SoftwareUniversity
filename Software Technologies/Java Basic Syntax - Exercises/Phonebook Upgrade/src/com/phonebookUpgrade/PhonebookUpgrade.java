package com.phonebookUpgrade;

import java.util.Map;
import java.util.Objects;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade {
    public static void main(String[] args) {
        TreeMap<String, String> phonebook = new TreeMap<String, String>();

        Scanner scanner = new Scanner(System.in);

        String input = scanner.nextLine();

        while (!Objects.equals(input, "END"))
        {
            String[] tokens = input.split(" ");
            if (Objects.equals(tokens[0], "A"))
            {
                if (phonebook.containsKey(tokens[1]))
                {
                    phonebook.put(tokens[1], tokens[2]);
                }
                else
                {
                    phonebook.put(tokens[1], tokens[2]);
                }
            }
            if (Objects.equals(tokens[0], "S"))
            {
                if (phonebook.containsKey(tokens[1]))
                {
                    System.out.println(tokens[1] + " -> " + phonebook.get(tokens[1]));
                }
                else
                {
                    System.out.println("Contact " + tokens[1] + " does not exist.");
                }
            }
            if (Objects.equals(tokens[0], "ListAll"))
            {
                for (Map.Entry<String, String> entry : phonebook.entrySet())
                {
                    System.out.println(entry.getKey() + " -> " + entry.getValue());
                }
            }
            input = scanner.nextLine();
        }
    }
}
