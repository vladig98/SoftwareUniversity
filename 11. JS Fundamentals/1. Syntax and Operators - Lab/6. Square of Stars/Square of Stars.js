function SquareOfStart(number) {
    let x = number === undefined ? 5 : Number(number);

    for (let i = 0; i < x; i++)
    {
        let result = '';
        for (let j = 0; j < x; j++)
        {
            result += "* ";
        }
        console.log(result);
    }
}