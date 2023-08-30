package com.vowelOrDigit;

import java.util.Scanner;

public class VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String character = scan.nextLine();

        switch (character)
        {
            case "a":
            case "e":
            case "o":
            case "u":
            case "i":
            case "A":
            case "E":
            case "O":
            case "U":
            case "I":
                System.out.println("vowel");
                break;
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                System.out.println("digit");
                break;
            default:
                System.out.println("other");
                break;
        }
    }
}
