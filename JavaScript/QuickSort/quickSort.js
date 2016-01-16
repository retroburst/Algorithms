function quickSort(array, low, high) {
  var i = low;
  var j = high;
  var pivotIndex = Math.floor(low + (high - low) / 2);
  var pivot = array[pivotIndex];

  while (i <= j) {
    while (array[i] < pivot) {
      i++;
    }
    while (array[j] > pivot) {
      j--;
    }
    if (i <= j) {
      if (i != j) {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
      }
      i++;
      j--;
    }
  }
  if (j > low) {
    quickSort(array, low, j);
  }
  if (i < high) {
    quickSort(array, i, high);
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
console.log("Before quick sort: " + textualizeArray(numbers));
quickSort(numbers, 0, numbers.length - 1);
console.log("After quick sort: " + textualizeArray(numbers));
