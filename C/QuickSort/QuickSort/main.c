//
//  main.c
//  QuickSort
//
//  Created by Andrew D on 11/01/2016.
//  Copyright (c) 2016 retroburst. All rights reserved.
//

#include <stdio.h>
#include <stdbool.h>

// function prototypes
void PrintArray(int target[], int length);
void QuickSort(int target[], int length, int low, int high);

// main - entry point
int main(int argc, const char * argv[]) {
    int numbers[10] = { 12, 445, 55, 67, 2, 7, 909, 45, 4454, 1 };
    printf("Before Quick Sort: ");
    PrintArray(numbers, 10);
    QuickSort(numbers, 10, 0, 9);
    printf("After Quick Sort: ");
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

// Quick sorts an array
void QuickSort(int target[], int length, int low, int high)
{
    int pivot = (int)(low + (high - low) / 2);
    int pivotElement = target[pivot];
    int i = low;
    int j = high;
    
    while(i <= j)
    {
        while(target[i] < pivotElement) { i++; };
        while(target[j] > pivotElement) { j--; };
        
        if(i <= j)
        {
            if(i != j)
            {
                int temp = target[i];
                target[i] = target[j];
                target[j] = temp;
            }
            i++;
            j--;
        }
    }
    
    if(j > low) QuickSort(target, length, low, j);
    if(i < high) QuickSort(target, length, i, high);
}