#include <stdio.h>

void printLetters(int count) {
    switch (count) {
    case 7: printf("ABCDEFG\n"); break;
    case 6: printf("ABCDEF\n"); break;
    case 5: printf("ABCDE\n"); break;
    case 4: printf("ABCD\n"); break;
    case 3: printf("ABC\n"); break;
    case 2: printf("AB\n"); break;
    case 1: printf("A\n"); break;
    default: break;
    }
}

int main() {
    int i;

    // Print decreasing pattern
    for (i = 7; i >= 1; i--) {
        printLetters(i);
    }

    // Print increasing pattern
    for (i = 2; i <= 7; i++) {
        printLetters(i);
    }

    return 0;
}