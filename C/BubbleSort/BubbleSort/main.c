//
//  main.c
//  BubbleSort
//
//  Created by Andrew D on 11/01/2016.
//  Copyright (c) 2016 retroburst. All rights reserved.
//

#include <stdio.h>
#include <stdbool.h>

// function prototypes
void PrintArray(int target[], int length);
void BubbleSort(int target[], int length);

// main - entry point
int main(int argc, const char * argv[]) {
    int numbers[10] = { 12, 445, 55, 67, 2, 7, 909, 45, 4454, 1 };
    printf("Before Bubble Sort: ");
    PrintArray(numbers, 10);
    BubbleSort(numbers, 10);
    printf("After Bubble Sort: ");
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

// bubble sorts an array
void BubbleSort(int target[], int length)
{
    bool swapping = false;
    // while still swapping
    do{
        swapping = false;
        // for each pair of elements (neighbours)
        for(int i=0; i < length-1; i++)
        {
            // if first and bigger than second - swap them
            if(target[i] > target[i+1])
            {
                int temp = target[i];
                target[i] = target[i+1];
                target[i+1] = temp;
                // mark as still swapping
                swapping = true;
            }
        }
    } while(swapping);
}