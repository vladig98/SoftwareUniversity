package com.sumsByTown;

import java.util.*;

public class SumsByTown {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int readUntil = Integer.parseInt(scan.nextLine());

        TreeMap<String, Double> towns = new TreeMap<String, Double>();

        for (int i = 0; i < readUntil; i++)
        {
            String[] input = scan.nextLine().split("\\|");
            String townName = input[0].trim();
            Double income = Double.parseDouble(input[1].trim());

            if (towns.containsKey(townName))
            {
                towns.put(townName, towns.get(townName) + income);
            }
            else
            {
                towns.put(townName, income);
            }
        }

        for (Map.Entry<String, Double> entry : towns.entrySet())
        {
            String key = entry.getKey();
            Double value = entry.getValue();

            System.out.println(key + " -> " + value);
        }
    }
}
