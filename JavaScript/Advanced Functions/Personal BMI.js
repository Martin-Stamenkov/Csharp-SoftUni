function solve(name, age, weight, height) {

    const totalInfo = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
    };

    let bmi = Math.round(weight / (height / 100) ** 2);
    let status = "";
    if (bmi < 18.5) {
        status = 'underweight'
    } else if (bmi < 25) {
        status = 'normal'
    } else if (bmi < 30) {
        status = 'overweight'
    } else {
        status = 'obese'
        totalInfo['recommendation'] = 'admission required';
    }
    totalInfo['BMI'] = bmi;
    totalInfo['status'] = status;

    return totalInfo;
}
console.log(solve('Peter', 29, 200, 182))