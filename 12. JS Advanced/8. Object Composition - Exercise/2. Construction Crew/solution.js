function solve(obj) {
    obj.bloodAlcoholLevel += obj.handsShaking == true ? obj.weight * obj.experience * 0.1 : 0;
    obj.handsShaking = false;

    return obj;
}