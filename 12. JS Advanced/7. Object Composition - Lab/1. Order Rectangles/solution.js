function solve(arr) {
    class Rectangle {
        constructor(params) {
            this.width = params[0];
            this.height = params[1];
        }

        area() {
            return this.width * this.height;
        }

        compareTo(rect) {
            return this.area() < rect.area() ? -1 : this.area() == rect.area() ? 0 : 1;
        }
    }

    let rects = [];

    for (let i = 0; i < arr.length; i++) {
        rects.push(new Rectangle(arr[i]));
    }

    rects.sort((a, b) => {
        if (a.compareTo(b) == 0) {
            return b.width - a.width;
        }
        else {
            return -a.compareTo(b);
        }
    });

    console.log(JSON.stringify(rects));
}