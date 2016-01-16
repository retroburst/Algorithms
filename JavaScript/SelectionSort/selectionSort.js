function selectionSort(array) {
  for (var i = 0; i < array.length; i++) {
    var indexOfMin = i;
    for (var j = i + 1; j < array.length; j++) {
      if (array[j] < array[indexOfMin]) {
        indexOfMin = j;
      }
    }
    if (indexOfMin != i) {
      var temp = array[i];
      array[i] = array[indexOfMin];
      array[indexOfMin] = temp;
    }
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
console.log("Before selection sort: " + textualizeArray(numbers));
selectionSort(numbers);
console.log("After selection sort: " + textualizeArray(numbers));
