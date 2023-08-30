package com.bookLibraryModification;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.*;
import java.util.stream.Collectors;

public class BookLibraryModification {
    public static void main(String[] args) {
        Library library = new Library("Library");
        Scanner scanner = new Scanner(System.in);

        int until = Integer.parseInt(scanner.nextLine());

        for (int i = 0; i < until; i++)
        {
            String[] inputTokens = scanner.nextLine().split(" ");
            Book book = new Book(inputTokens[0], inputTokens[1], inputTokens[2], LocalDate.parse(inputTokens[3], DateTimeFormatter.ofPattern("dd.MM.yyyy")),
                    inputTokens[4], Double.parseDouble(inputTokens[5]));
            library.Books.add(book);
        }

        LocalDate date = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("dd.MM.yyyy"));

        HashMap<String, LocalDate> sortedBooks = new HashMap<String, LocalDate>();

        for (int i = 0; i < library.Books.size(); i++)
        {
            if (library.Books.get(i).ReleaseDate.isAfter(date))
            {
                sortedBooks.put(library.Books.get(i).Title, library.Books.get(i).ReleaseDate);
            }
        }

        List<Map.Entry<String, LocalDate>> list = new ArrayList<Map.Entry<String, LocalDate>>(sortedBooks.entrySet());
        Collections.sort(list, new ValueThenKeyComparator<String, LocalDate>());

        list.forEach((n) -> System.out.println(n.getKey() + " -> " + n.getValue().format(DateTimeFormatter.ofPattern("dd.MM.yyyy"))));
    }
}

class ValueThenKeyComparator<K extends Comparable<? super K>, V extends Comparable<? super V>> implements Comparator<Map.Entry<K, V>>
{
    public int compare(Map.Entry<K, V> a, Map.Entry<K, V> b)
    {
        int cmp1 = a.getValue().compareTo(b.getValue());
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
    Book(String title, String author, String publisher, LocalDate releaseDate, String ISBNNumber, Double price)
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
    LocalDate ReleaseDate;
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
