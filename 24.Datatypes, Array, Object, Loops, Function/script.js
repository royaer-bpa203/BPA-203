function removeDuplicatesAndCount(arr) {
    let count = {};
    let unique = [];

    arr.forEach(num => {
        count[num] = (count[num] || 0) + 1;
    });

    unique = [...new Set(arr)];

    return {
        uniqueArray: unique,
        duplicateCount: Object.fromEntries(
            Object.entries(count).filter(([k, v]) => v > 1)
        )
    };
}

// Test
console.log(removeDuplicatesAndCount([1,2,3,2,4,1,5,2]));







function isPalindrome(word) {
    let reversed = word.split("").reverse().join("");
    return word === reversed;
}

// Test
console.log(isPalindrome("level"));  // true
console.log(isPalindrome("test"));   // false







function countSmaller(arr, num) {
    return arr.filter(x => num > x).length;
}

// Test
console.log(countSmaller([3, 7, 1, 9, 4], 5));  // 3 (3,1,4)







function checkAbundantOrDeficient(n) {
    let sum = 0;

    for (let i = 1; i <= n / 2; i++) {
        if (n % i === 0) sum += i;
    }

    if (sum > n) return "Abundant";
    else return "Deficient";
}

// Test
console.log(checkAbundantOrDeficient(12));  // Abundant
console.log(checkAbundantOrDeficient(13));  // Deficient









function squareArray(arr) {
    return arr.map(x => x * x);
}

// Test
console.log(squareArray([1, 2, 3, 4]));  // [1, 4, 9, 16]
