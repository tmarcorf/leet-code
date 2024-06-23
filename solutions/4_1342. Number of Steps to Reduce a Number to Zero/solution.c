#include <stdio.h>

int numberOfSteps(int num);

int main() {
    return 0;
}

int numberOfSteps(int num) {
    if (num == 0) return 0;

    if (num % 2 == 0) {
        num /= 2;
    }
    else {
        num--;
    }
    
    return 1 + numberOfSteps(num);
}