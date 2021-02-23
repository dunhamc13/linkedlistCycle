/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
    
    /** detecting the cyclbe of a linked list
        if there is a cyble, return the node that at
        index of the cycle... if not cycle return null
        
        inputs - array of integers
        integer - position
        
        output the node where the cyble begins.
        
        example - array {1,2} pos = 0
        return 1.
        
        data structure, array -> linked list
    **/
public:
    
    //traverse list, check if cycle, return node
    ListNode *detectCycle(ListNode *head) {
                
        //make slow and fast pointers...
        // it is a loop if they meet.
        // once they meet, put one pointer to head.
        // where they meet, is the start pointer.
        if (!head){return NULL;}
        ListNode *s = head;
        ListNode *f = head;
        
        while (1){
            if(s->next != NULL){s=s->next;}else{return NULL;}
            if(f->next != NULL && s->next != NULL){f=f->next->next;}else{return NULL;}
            if(s==f){// we found a loop,now find the start
                f = head;
                while(s!=f){
                    s=s->next;
                    f=f->next;
                }
                return s;
            }
        }  
        
    }
};
