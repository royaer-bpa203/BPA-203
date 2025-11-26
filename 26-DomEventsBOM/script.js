function calc(operation) {
    let n1 = document.getElementById("num1").value.trim();
    let n2 = document.getElementById("num2").value.trim();
    let resultBox = document.getElementById("result");

    
    if (n1 === "" || n2 === "") {
        resultBox.textContent = "Nəticə: Xəta — boş dəyər!";
        return;
    }

    
    if (isNaN(n1) || isNaN(n2)) {
        resultBox.textContent = "Nəticə: Xəta — yalnız ədəd yazın!";
        return;
    }

    let a = Number(n1);
    let b = Number(n2);
    let result;

    switch (operation) {
        case "plus":
            result = a + b;
            break;

        case "minus":
            result = a - b;
            break;

        case "mult":
            result = a * b;
            break;

        case "divide":
            if (b === 0) {
                resultBox.textContent = "Nəticə: Sıfıra bölmək olmaz!";
                return;
            }
            result = a / b;
            break;

        default:
            result = "Naməlum əməliyyat!";
    }

    resultBox.textContent = "Nəticə: " + result;
}
