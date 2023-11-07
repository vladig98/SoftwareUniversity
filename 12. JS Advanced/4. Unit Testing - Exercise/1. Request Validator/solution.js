function solve(request) {
    let method = request.method;
    let uri = request.uri;
    let version = request.version;
    let message = request.message;

    if (!/(GET|POST|DELETE|CONNECT)/g.test(method)) {
        throw new Error(`Invalid request header: Invalid Method`);
    }

    if (!uri || (!/^[a-zA-Z0-9.]+$/g.test(uri) && uri != "*")) {
        throw new Error(`Invalid request header: Invalid URI`);
    }

    if (!/HTTP\/(0\.9|1\.(0|1)|2\.0)/g.test(version)) {
        throw new Error(`Invalid request header: Invalid Version`);
    }

    if (!/^[^<>\\&'"]*$/g.test(message)) {
        throw new Error(`Invalid request header: Invalid Message`);
    }

    return request;
}