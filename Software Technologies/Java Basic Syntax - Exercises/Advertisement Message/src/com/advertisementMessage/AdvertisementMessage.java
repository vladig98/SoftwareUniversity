package com.advertisementMessage;

import java.util.Scanner;
import java.util.concurrent.ThreadLocalRandom;

public class AdvertisementMessage {
    public static void main(String[] args) {
        String[] phrases = new String[] {"Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."};

        String[] events = new String[] {"Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

        String[] authors = new String[] {"Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"};

        String[] cities = new String[] {"Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"};

        Scanner scanner = new Scanner(System.in);

        int until = scanner.nextInt();

        for (int i = 0; i < until; i++)
        {
            int randomPhraseIndex = ThreadLocalRandom.current().nextInt(0, phrases.length);
            int randomEventIndex = ThreadLocalRandom.current().nextInt(0, events.length);
            int randomAuthorIndex = ThreadLocalRandom.current().nextInt(0, authors.length);
            int randomCityIndex = ThreadLocalRandom.current().nextInt(0, cities.length);

            System.out.println(phrases[randomPhraseIndex] + " " + events[randomEventIndex] + " " + authors[randomAuthorIndex] + " - " + cities[randomCityIndex]);
        }
    }
}
