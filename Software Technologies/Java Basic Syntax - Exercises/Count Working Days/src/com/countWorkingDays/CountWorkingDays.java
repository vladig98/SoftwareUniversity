package com.countWorkingDays;

import java.time.DayOfWeek;;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.*;

import static java.time.temporal.ChronoUnit.DAYS;

public class CountWorkingDays {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LocalDate dateFrom = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("dd-MM-yyyy"));
        LocalDate dateTo = LocalDate.parse(scanner.nextLine(), DateTimeFormatter.ofPattern("dd-MM-yyyy"));

        LocalDate tempDate = dateFrom;
        int days = 0;
        boolean isSpecialWeekend = false;

        while (!tempDate.isAfter(dateTo))
        {
            days++;
            isSpecialWeekend = false;

            if (tempDate.getMonthValue() == 1)
            {
                if (tempDate.getDayOfMonth() == 1)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (tempDate.getMonthValue() == 3)
            {
                if (tempDate.getDayOfMonth() == 3)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (tempDate.getMonthValue() == 5)
            {
                if (tempDate.getDayOfMonth() == 1 || tempDate.getDayOfMonth() == 6 || tempDate.getDayOfMonth() == 24)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (tempDate.getMonthValue() == 9)
            {
                if (tempDate.getDayOfMonth() == 6 || tempDate.getDayOfMonth() == 22)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (tempDate.getMonthValue() == 11)
            {
                if (tempDate.getDayOfMonth() == 1)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (tempDate.getMonthValue() == 12)
            {
                if (tempDate.getDayOfMonth() == 24 || tempDate.getDayOfMonth() == 25 || tempDate.getDayOfMonth() == 26)
                {
                    days--;
                    isSpecialWeekend = true;
                }
                else if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                    isSpecialWeekend = true;
                }
            }

            if (!isSpecialWeekend)
            {
                if (tempDate.getDayOfWeek() == DayOfWeek.SUNDAY || tempDate.getDayOfWeek() == DayOfWeek.SATURDAY)
                {
                    days--;
                }
            }

            tempDate = tempDate.plusDays(1);
        }

        System.out.println(days);
    }
}
