function solve(num1, num2) {
    if (!num2) {
        return num1;
    }

    return solve(num2, num1 % num2);
}