// Checks if array has a pair that sums up to the given match number
const hasSumAsPair = (listOfNumbers, match) => {
  for (let i = 0; i < listOfNumbers.length - 1; i++) {
    for (let j = i + 1; j < listOfNumbers.length; j++) {
      if (listOfNumbers[i] + listOfNumbers[j] === match) return true;
    }
  }
  return false;
};

const testArray = [10, 15, 3, 7];
const testArray2 = [10, 2, 7, 4];
const testArray3 = [10, 31];
const testArray4 = [5];

console.log(hasSumAsPair(testArray, 17)); // Should be true
console.log(hasSumAsPair(testArray2, 9)); // Should be true
console.log(hasSumAsPair(testArray3, 10)); // Should be false
console.log(hasSumAsPair(testArray4, 5)); // Should be false
