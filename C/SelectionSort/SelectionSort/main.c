//
//  main.c
//  SelectionSort
//
//  Created by Andrew D on 11/01/2016.
//  Copyright (c) 2016 retroburst. All rights reserved.
//

#include <stdio.h>
#include <stdbool.h>

// function prototypes
void PrintArray(int target[], int length);
void SelectionSort(int target[], int length);

// main - entry point
int main(int argc, const char * argv[]) {
    int numbers[10] = { 12, 445, 55, 67, 2, 7, 909, 45, 4454, 1 };
    printf("Before selection sort: ");
    PrintArray(numbers, 10);
    SelectionSort(numbers, 10);
    printf("After selection sort: ");
    PrintArray(numbers, 10);
    return 0;
}

// prints an array to console
void PrintArray(int target[], int length)
{
    printf("[");
    for(int i=0; i < length; i++)
    {
        printf("%d", target[i]);
        if(i < length-1) printf(", ");
    }
    printf("]\n");
}

// selection sorts an array
void SelectionSort(int target[], int length)
{
    // for each element of array
    for(int i=0; i < length; i++)
    {
        // make sure it is the min of rest of array
        int indexOfMin = i;
        for(int j=i+1; j < length; j++)
        {
            // if not min of rest of array, record new min
            if(target[j] < target[indexOfMin]) { indexOfMin = j; }
        }
        // if the min of rest of array was different - swap elements
        if(indexOfMin != i)
        {
            int temp = target[i];
            target[i] = target[indexOfMin];
            target[indexOfMin] = temp;
        }
    }
}