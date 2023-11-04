function solve() {
    let str = document.getElementById('str');
    let result = document.getElementById('result');

    let namePattern = " (([A-Z]{1,}[a-zA-Z]{0,}-[A-Z]{1,}[a-zA-Z]{0,})|([A-Z]{1,}[a-zA-Z]{0,}-[A-Z]{1,}[a-zA-Z]{0,}\\.-[A-Z]{1,}[a-zA-Z]{0,})) ";
    let airportPattern = " [A-Z]{3,3}\\/[A-Z]{3,3} ";
    let flightNumberPattern = " [A-Z]{1,3}\\d{1,5} ";
    let companyPattern = "- [A-Z]{1,1}[a-zA-Z]{0,}\\*[A-Z]{1,1}[a-zA-Z]{0,} ";

    let data = str.value.split(",")[0];
    let print = str.value.split(",")[1];

    let name = data.match(new RegExp(namePattern, "g"))[0];
    let flight = data.match(new RegExp(flightNumberPattern, "g"))[0];
    let airport = data.match(new RegExp(airportPattern, "g"))[0];
    let company = data.match(new RegExp(companyPattern, "g"))[0];

    switch (print.toLowerCase().trim()) {
        case "name":
            name.trim();
            name = name.replaceAll("-", " ");
            result.innerHTML = `Mr/Ms, ${name.trim()}, have a nice flight!`;
            break;
        case "flight":
            flight.trim();
            airport.trim();
            result.innerHTML = `Your flight number ${flight} is from ${airport.split("/")[0].trim()} to ${airport.split("/")[1].trim()}.`;
            break;
        case "company":
            company.trim();
            company = company.substring(1, company.length - 1);
            company.trim();
            company = company.replaceAll("*", " ");
            result.innerHTML = `Have a nice flight with ${company}.`;
            break;
        case "all":
            name.trim();
            name = name.replaceAll("-", " ");
            flight.trim();
            airport.trim();
            company.trim();
            company = company.substring(1, company.length - 1);
            company.trim();
            company = company.replaceAll("*", " ");
            result.innerHTML = `Mr/Ms, ${name.trim()}, your flight number ${flight} is from ${airport.split("/")[0].trim()} to ${airport.split("/")[1].trim()}. Have a nice flight with ${company}.`;
            break;
        default:
            break;
    }
}