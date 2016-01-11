//
//  main.c
//  InsertionSort
//
//  Created by Andrew D on 11/01/2016.
//  Copyright (c) 2016 retroburst. All rights reserved.
//

#include <stdio.h>
#include <stdbool.h>

// function prototypes
void PrintArray(int target[], int length);
void InsertionSort(int target[], int length);

// main - entry point
int main(int argc, const char * argv[]) {
    int numbers[10] = { 12, 445, 55, 67, 2, 7, 909, 45, 4454, 1 };
    printf("Before Insertion Sort: ");
    PrintArray(numbers, 10);
    InsertionSort(numbers, 10);
    printf("After Insertion Sort: ");
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

// Insertion sorts an array
void InsertionSort(int target[], int length)
{
    // for each element of array
    for(int i=1; i < length; i++)
    {
        int targetElement = target[i];
        int j = 0;
        for(j=i-1; j >= 0 && targetElement < target[j]; j--)
        {
            target[j+1] = target[j];
        }
        target[j+1] = targetElement;
    }
}