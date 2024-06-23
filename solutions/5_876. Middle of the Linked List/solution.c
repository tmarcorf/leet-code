#include <stdio.h>

struct ListNode {
     int val;
     struct ListNode *next;
 };

int getNumberOfNodes(struct ListNode* head);

struct ListNode* middleNode(struct ListNode* head) {
    int numberOfNodes = getNumberOfNodes(head);
    int middleIndex = numberOfNodes / 2;
    int counter = 0;
    struct ListNode* middleNode = NULL;

    while (head != NULL) {
        if (counter >= middleIndex)
        {
            return head;
        }

        head = head->next;
        counter++;
    }

    return middleNode;
}

int getNumberOfNodes(struct ListNode* head) {
    int numberOfNodes = 0;

    while (head != NULL) {
        numberOfNodes += 1;
        if (numberOfNodes == 100) break;

        head = head->next;
    }

    return numberOfNodes;
}
