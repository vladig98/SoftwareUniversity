(function solve() {
    String.prototype.ensureStart = function (str) {
        if (!this.startsWith(str)) {
            return str + this;
        }

        return this.toString();
    }

    String.prototype.ensureEnd = function (str) {
        if (!this.endsWith(str)) {
            return this + str;
        }

        return this.toString();
    }

    String.prototype.isEmpty = function () {
        return this == "";
    }

    String.prototype.truncate = function (n) {
        if (this.length <= n) {
            return this.toString();
        }

        if (this.length > n) {
            let tokens = this.split(" ");

            if (tokens.length == 1) {
                tokens = this.split("");
                let result = "";
                if (n <= 3) {
                    return ".".repeat(n);
                } else {
                    for (let i = 0; i < n - 3; i++) {
                        result += tokens[i];
                    }
                }

                return result + "...";
            } else {
                for (let i = tokens.length - 1; i >= 0; i--) {
                    let result = "";
                    for (let j = 0; j < i; j++) {
                        result += tokens[j] + " ";
                    }
                    result = result.trim();

                    if (result.length <= n - 3) {
                        return result + "...";
                    }
                }
            }
        }
    }

    String.format = function () {
        let str = arguments[0];

        for (let i = 1; i < arguments.length; i++) {
            str = str.replace(`{${i - 1}}`, arguments[i]);
        }

        return str;
    }
}())