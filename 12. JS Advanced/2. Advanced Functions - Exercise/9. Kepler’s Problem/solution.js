function solve(meanAnomaly, eccentricity) {
    const epsilon = 1e-9;

    function keplerEquation(E) {
        return E - eccentricity * Math.sin(E) - meanAnomaly;
    }

    function keplerEquationDerivative(E) {
        return 1 - eccentricity * Math.cos(E);
    }

    function newtonRaphsonMethod(E) {
        const delta = keplerEquation(E) / keplerEquationDerivative(E);
        if (Math.abs(delta) < epsilon) {
            return E;
        }
        return newtonRaphsonMethod(E - delta);
    }

    const initialGuess = meanAnomaly;
    const eccentricAnomaly = newtonRaphsonMethod(initialGuess);
    console.log(eccentricAnomaly.toFixed(9));
}