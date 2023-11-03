function solve() {
    let numberInput = document.getElementsByTagName('input')[0];
    let chopB = document.getElementsByTagName('button')[0];
    let diceB = document.getElementsByTagName('button')[1];
    let spiceB = document.getElementsByTagName('button')[2];
    let bakeB = document.getElementsByTagName('button')[3];
    let filletB = document.getElementsByTagName('button')[4];
    let output = document.getElementById('output');

    let number = 0;

    function chop(number) {
        return number / 2;
    }
    
    function dice(number) {
        return Math.sqrt(number);
    }
    
    function spice(number) {
        return number + 1;
    }
    
    function bake(number) {
        return number * 3;
    }
    
    function fillet(number) {
        return number - number / 5;
    }

    chopB.addEventListener("click", function() {
        number = Number(numberInput.value);
        number = chop(number);
        output.innerHTML = number;
        diceB.addEventListener("click", function() {
            number = dice(number);
            output.innerHTML = number;
            spiceB.addEventListener("click", function() {
                number = spice(number);
                output.innerHTML = number;
                bakeB.addEventListener("click", function() {
                    number = bake(number);
                    output.innerHTML = number;
                    filletB.addEventListener("click", function() {
                        number = fillet(number);
                        output.innerHTML = number;
                    }, {once: true});
                }, {once: true});
            }, {once: true});
        }, {once: true});
    }, {once: true});
}