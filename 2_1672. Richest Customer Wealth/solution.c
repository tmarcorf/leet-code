#include <stdio.h>

int maximumWealth(int** accounts, int accountsSize, int* accountsColSize);

int main() {
    printf("Teste\n");

    return 0;
}

int maximumWealth(int** accounts, int accountsSize, int* accountsColSize) {
    int greaterAmount = 0;
    int amount = 0;

    for (int i = 0; i < accountsSize; i++) {
        int amount = 0;

        for (int j = 0; j < accountsColSize[i]; j++) {
            amount += accounts[i][j];
            greaterAmount = (amount > greaterAmount) ? amount : greaterAmount;
        }
    }

    return greaterAmount;
}