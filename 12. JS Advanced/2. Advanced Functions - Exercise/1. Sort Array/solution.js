function solve(arr, order) {
    switch (order.toLowerCase()) {
        case "asc":
            console.log(arr.sort((a, b) => a - b));
            break;
        case "desc":
            console.log(arr.sort((a, b) => b - a));
            break;
        default:
            break;
    }
}