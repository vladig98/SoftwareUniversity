package com.censorEmailAddress;

import java.util.Scanner;

public class CensorEmailAddress {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String emailAddress = scan.nextLine();
        String message = scan.nextLine();

        String[] emailParts = emailAddress.split("\\@");

        String masked = new String(new char[emailParts[0].length()]).replace("\0", "*");
        String maskedEmail = masked + "@" + emailParts[1];

        message = message.replaceAll(emailAddress, maskedEmail);

        System.out.println(message);
    }
}
