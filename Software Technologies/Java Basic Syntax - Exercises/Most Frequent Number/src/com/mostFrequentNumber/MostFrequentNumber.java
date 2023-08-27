package com.mostFrequentNumber;

import java.util.*;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        LinkedHashMap<Integer, Integer> occurrences = new LinkedHashMap<>();

        for (int i = 0; i < numbers.length; i++)
        {
            if (occurrences.containsKey(numbers[i]))
            {
                occurrences.put(numbers[i], occurrences.get(numbers[i]) + 1);
            }
            else
            {
                occurrences.put(numbers[i], 1);
            }
        }

        int number = 0;
        int count = 0;

        for (Map.Entry<Integer, Integer> entry : occurrences.entrySet())
        {
            int key = entry.getKey();
            int value = entry.getValue();

            if (count < value)
            {
                number = key;
                count = value;
            }
        }

        System.out.println(number);
    }
}
