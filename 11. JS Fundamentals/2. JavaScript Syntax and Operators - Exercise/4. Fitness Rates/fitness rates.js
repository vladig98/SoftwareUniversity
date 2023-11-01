function fitnessRates(day, service, hour) {
    day = day.toString().toLowerCase();
    service = service.toString().toLowerCase();
    

    switch (service) {
        case "fitness":
            if (hour >= 8.00 && hour <= 15.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(5);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(8);
                        break;
                    default:
                        break;
                }
            }
            if (hour > 15.00 && hour <= 22.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(7.5);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(8);
                        break;
                    default:
                        break;
                }
            }
            break;
        case "sauna":
            if (hour >= 8.00 && hour <= 15.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(4);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(7);
                        break;
                    default:
                        break;
                }
            }
            if (hour > 15.00 && hour <= 22.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(6.5);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(7);
                        break;
                    default:
                        break;
                }
            }
            break;
        case "instructor":
            if (hour >= 8.00 && hour <= 15.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(10);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(15);
                        break;
                    default:
                        break;
                }
            }
            if (hour > 15.00 && hour <= 22.00) {
                switch (day)
                {
                    case "monday":
                    case "tuesday":
                    case "wednesday":
                    case "thursday":
                    case "friday":
                        console.log(12.5);
                        break;
                    case "saturday":
                    case "sunday":
                        console.log(15);
                        break;
                    default:
                        break;
                }
            }
            break;
        default:
            break;
    }
}

fitnessRates('Sunday', 'Fitness', 22.00);