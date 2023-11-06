var solution = {
    
    add: function (vector1, vector2) {
        let result = [];

        for (let i = 0; i < vector1.length; i++) {
            result.push(vector1[i] + vector2[i]);
        }

        return result;
    },

    multiply: function (vector1, scaler) {
        let result = []

        for (let i = 0; i < vector1.length; i++) {
            result.push(vector1[i] * scaler);
        }

        return result;
    },
    
    length: function(vector1) {
        return Math.sqrt(vector1.reduce((a, b) => Math.pow(a, 2) + Math.pow(b, 2)));
    },

    dot: function(vector1, vector2) {
        return vector1.reduce((a, b) => a * b) + vector2.reduce((a, b) => a * b);
    },

    cross: function(vector1, vector2) {
        return vector1[0] * vector2[1] - vector1[1] * vector2[0];
    }
}