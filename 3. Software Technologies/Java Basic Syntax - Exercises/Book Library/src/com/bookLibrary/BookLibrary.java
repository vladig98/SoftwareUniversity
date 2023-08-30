package com.bookLibrary;

import java.util.*;
import java.util.stream.Collectors;

public class BookLibrary {
    public static void main(String[] args) {
        Library library = new Library("Library");
        Scanner scanner = new Scanner(System.in);

        int until = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < until; i++)
        {
            String[] inputTokens = scanner.nextLine().split(" ");
            Book book = new Book(inputTokens[0], inputTokens[1], inputTokens[2], inputTokens[3], inputTokens[4], Double.parseDouble(inputTokens[5]));
            library.Books.add(book);
        }

        HashMap<String, Double> sortedBooks = new HashMap<String, Double>();

        for (int i = 0; i < library.Books.size(); i++)
        {
            if (sortedBooks.containsKey(library.Books.get(i).Author))
            {
                sortedBooks.put(library.Books.get(i).Author, sortedBooks.get(library.Books.get(i).Author) + library.Books.get(i).Price);
            }
            else
            {
                sortedBooks.put(library.Books.get(i).Author, library.Books.get(i).Price);
            }
        }

        List<Map.Entry<String, Double>> list = new ArrayList<Map.Entry<String, Double>>(sortedBooks.entrySet());
        Collections.sort(list, new ValueThenKeyComparator<String, Double>());

        list.forEach((n) -> System.out.println(n.getKey() + " -> " + String.format("%.2f", n.getValue())));
    }
}

class ValueThenKeyComparator<K extends Comparable<? super K>, V extends Comparable<? super V>> implements Comparator<Map.Entry<K, V>>
{
    public int compare(Map.Entry<K, V> a, Map.Entry<K, V> b)
    {
        int cmp1 = b.getValue().compareTo(a.getValue());
        if (cmp1 != 0)
        {
            return cmp1;
        }
        else
        {
            return a.getKey().compareTo(b.getKey());
        }
    }
}

class Book
{
    Book(String title, String author, String publisher, String releaseDate, String ISBNNumber, Double price)
    {
        this.Title = title;
        this.Author = author;
        this.Publisher = publisher;
        this.ReleaseDate = releaseDate;
        this.ISBNNumber = ISBNNumber;
        this.Price = price;
    }

    String Title;
    String Author;
    String Publisher;
    String ReleaseDate;
    String ISBNNumber;
    Double Price;
}

class Library
{
    Library (String name)
    {
        this.Name = name;
        this.Books = new ArrayList<Book>();
    }

    String Name;
    List<Book> Books;
}
