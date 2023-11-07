class Point {
    constructor(x, y) {
        this.x = x;
        this.y = y;
    }

    static distance(point1, point2) {
        let xDiff = Math.abs(point1.x - point2.x);
        let yDiff = Math.abs(point1.y - point2.y);

        return Math.sqrt(Math.pow(xDiff, 2) + Math.pow(yDiff, 2));
    }
}