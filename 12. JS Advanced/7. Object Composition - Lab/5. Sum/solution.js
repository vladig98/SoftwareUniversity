function solve() {
    class DomModifier {
        init(selector1, selector2, resultSelector) {
            this.selector1 = selector1
            this.selector2 = selector2
            this.resultSelector = resultSelector
            console.log("init");
        }

        add() {
            document.querySelector(this.resultSelector).value = Number(document.querySelector(this.selector1).value) + Number(document.querySelector(this.selector2).value);
            console.log("add");
        }

        subtract() {
            document.querySelector(this.resultSelector).value = Number(document.querySelector(this.selector1).value) - Number(document.querySelector(this.selector2).value);
            console.log("subtract");
        }
    }
    console.log("solve");
    return new DomModifier();
}