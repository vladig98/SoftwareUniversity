function dailyCalorieIntake(data, numberOfWorkouts) {
    let sex = data[0];
    let weight = Number(data[1]);
    let height = Number(data[2]);
    let age = Number(data[3]);

    let calories = 0;

    switch (sex.toLowerCase()) {
        case "f":
            calories = 655 + 9.7 * weight + 1.85 * height - 4.7 * age;
            break;
        case "m":
            calories = 66 + 13.8 * weight + 5 * height - 6.8 * age;
            break;
        default:
            break;
    }

    let af = 0;

    if (numberOfWorkouts == 0) {
        af = 1.2;
    }
    else if (numberOfWorkouts >= 1 && numberOfWorkouts <= 2) {
        af = 1.375;
    }
    else if (numberOfWorkouts >= 3 && numberOfWorkouts <= 5) {
        af = 1.55;
    }
    else if (numberOfWorkouts >= 6 && numberOfWorkouts <= 7) {
        af = 1.725;
    }
    else {
        af = 1.90;
    }

    console.log(`My calorie intake is ${Math.round(calories * af)}`);
}