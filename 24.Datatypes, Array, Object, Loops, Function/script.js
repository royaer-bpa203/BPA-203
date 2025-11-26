// 1. Duplicate Silmək
function task1() {
    const arr = document.getElementById("arr1").value.split(",").map(Number);

    const counts = {};
    const unique = [];

    arr.forEach(n => {
        counts[n] = (counts[n] || 0) + 1;
        if (counts[n] === 1) unique.push(n);
    });

    document.getElementById("res1").innerHTML =
        "Təkrarsız: " + JSON.stringify(unique) +
        "<br>Təkrar sayı: " + JSON.stringify(counts);
}

// 2. Palindrom
function task2() {
    const word = document.getElementById("word").value;
    const reversed = word.split("").reverse().join("");

    document.getElementById("res2").innerHTML =
        word === reversed ? "Palindromdur ✔" : "Palindrom deyil ✖";
}

// 3. Kiçik element sayı
function task3() {
    const arr = document.getElementById("arr3").value.split(",").map(Number);
    const n = Number(document.getElementById("num3").value);

    const count = arr.filter(x => x < n).length;
    document.getElementById("res3").innerHTML =
        `Nəticə: ${count} element ${n}-dən kiçikdir.`;
}

// 4. Abundant / Deficient
function task4() {
    const n = Number(document.getElementById("num4").value);
    let sum = 0;

    for (let i = 1; i < n; i++) {
        if (n % i === 0) sum += i;
    }

    const result = sum > n ? "Abundant ✔" : "Deficient ✖";
    document.getElementById("res4").innerHTML = result;
}

// 5. Kvadrata yüksəltmək
function task5() {
    const arr = document.getElementById("arr5").value.split(",").map(Number);
    const squared = arr.map(x => x * x);

    document.getElementById("res5").innerHTML =
        "Nəticə: " + JSON.stringify(squared);
}
