function gcd(num1, num2) {
    var calc = function(a, b) {
        if (!b) {
          return a;
        }
      
        return calc(b, a % b);
      }

    console.log(calc(num1, num2));
}