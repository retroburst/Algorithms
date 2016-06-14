var items : [Int] = [2,44,6,9,1,2,3,44,54,233,43,546,7677,8788,9,1,2,3,0]


func bubbleSort(items : [Int]) -> [Int]{
    var result = items;
    for _ in 1...result.count-1 {
        var swapping = false
        for j in 1...result.count-1 {
            if result[j] < result[j-1] {
                swapping = true
                let temp = result[j-1]
                result[j-1] = result[j]
                result[j] = temp;
            }
        }
        if !swapping {
            break
        }
    }
    return result
}

print(bubbleSort(items))
