package com.bombNumbers;

import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class BombNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int[] tokens = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        ArrayList<Integer> indices = new ArrayList<>();

        ArrayList<Integer> copyNumbers = IntStream.of(numbers).boxed().collect(Collectors.toCollection(ArrayList::new));

        for (int i = 0; i < numbers.length; i++)
        {
            if (numbers[i] == tokens[0])
            {
                for (int j = i - tokens[1]; j < i; j++)
                {
                    if (j >= 0)
                    {
                        indices.add(j);
                    }
                }
                indices.add(i);
                for (int j = i + 1; j < i + tokens[1] + 1; j++)
                {
                    if (j < numbers.length)
                    {
                        indices.add(j);
                    }
                }

                i += tokens[1];
            }
        }

        int counter = 0;

        Set<Integer> set = new HashSet<>(indices);
        indices.clear();
        indices.addAll(set);

        for (int i = 0; i < indices.size(); i++)
        {
            copyNumbers.remove(indices.get(i) - counter);
            counter++;
        }

        System.out.println(copyNumbers.stream().mapToInt(a -> a).sum());
    }
}
