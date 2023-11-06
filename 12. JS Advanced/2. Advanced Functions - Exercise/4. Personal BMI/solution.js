function solve(name, age, weight, height) {
    let obj = {};

    let bmi = (weight / Math.pow(height / 100, 2));

    obj["name"] = name;
    obj["personalInfo"] = {"age": Math.round(age), "weight": Math.round(weight), "height": Math.round(height)};
    obj["BMI"] = Math.round(bmi);
    obj["status"] = bmi < 18.5 ? "underweight" : bmi < 25 ? "normal" : bmi < 30 ? "overweight" : "obese";

    if (bmi >= 30) {
        obj["recommendation"] = "admission required";
    }

    console.log(obj);
}