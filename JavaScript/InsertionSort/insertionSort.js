function insertionSort(array) {
  for (var i = 1; i < array.length; i++) {
    var targetElement = array[i];
    var j = 0;
    for (j = i - 1; j >= 0 && targetElement < array[j]; j--) {
      array[j + 1] = array[j];
    }
    array[j + 1] = targetElement;
  }
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
console.log("Before insertion sort: " + textualizeArray(numbers));
insertionSort(numbers);
console.log("After insertion sort: " + textualizeArray(numbers));
