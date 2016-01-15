function bubbleSort(array) {
  var swapping = false;
  do {
    swapping = false;
    for (var i = 0; i < array.length - 1; i++) {
      if (array[i] > array[i + 1]) {
        var temp = array[i];
        array[i] = array[i + 1];
        array[i + 1] = temp;
        swapping = true;
      }
    }
  } while (swapping);
}

function textualizeArray(target) {
  var result = "[";
  for (var i = 0; i < target.length; i++) {
    result += target[i];
    if (i != (target.length - 1)) {
      result += ", ";
    }
  }
  result += "]";
  return (result);
}

var numbers = [22, 3, 443, 2, 23, 11, 43, 64, 88, 21, 1, 0, 55, 999];
console.log("Before bubble sort: " + textualizeArray(numbers));
bubbleSort(numbers);
console.log("After bubble sort: " + textualizeArray(numbers));

