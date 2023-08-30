package com.compareCharArrays;

import java.util.Arrays;
import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] firstArray = scan.nextLine().split(" ");
        String[] secondArray = scan.nextLine().split(" ");

        int length = Math.min(firstArray.length, secondArray.length);
        Boolean isFirstArrayWinning = false;
        Boolean areIdentical = false;

        if (firstArray.length < secondArray.length)
        {
            System.out.println(String.join("", firstArray));
            System.out.println(String.join("", secondArray));
            return;
        }
        else if (firstArray.length > secondArray.length)
        {
            System.out.println(String.join("", secondArray));
            System.out.println(String.join("", firstArray));
            return;
        }

        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                if (i == length - 1)
                {
                    areIdentical = true;
                }
                continue;
            }
            else if (firstArray[i].charAt(0) > secondArray[i].charAt(0))
            {
                isFirstArrayWinning = false;
                break;
            }
            else if (firstArray[i].charAt(0) < secondArray[i].charAt(0))
            {
                isFirstArrayWinning = true;
                break;
            }
        }

        if (areIdentical == true)
        {
            if (firstArray.length < secondArray.length)
            {
                System.out.println(String.join("", firstArray));
                System.out.println(String.join("", secondArray));
                return;
            }
            else if (firstArray.length > secondArray.length)
            {
                System.out.println(String.join("", secondArray));
                System.out.println(String.join("", firstArray));
                return;
            }
        }

        if (isFirstArrayWinning == true)
        {
            System.out.println(String.join("", firstArray));
            System.out.println(String.join("", secondArray));
        }
        else
        {
            System.out.println(String.join("", secondArray));
            System.out.println(String.join("", firstArray));
        }
    }
}
