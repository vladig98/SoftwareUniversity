function DayOfWeek(day) {
    let days = ['monday', "tuesday", "wednesday", 'thursday', 'friday', 'saturday', 'sunday'];
    day = day.toString().toLowerCase();

    if (days.includes(day)) {
        console.log(days.indexOf(day) + 1);
    }
    else {
        console.log("error");
    }
}