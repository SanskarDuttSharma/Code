using System.Collections.Generic;

public class Solution {

    private void IsOpen(char ch, Stack<char> stack ){
        if((ch == '{') || (ch == '[') || (ch == '(')){
            stack.Push(ch);
        }
    }

    private bool IsClose(char ch, Stack<char> stack){
        if(stack.Count == 0){
            return false;
        }
        char lastPushed = stack.Pop();
        if((ch == ')' && lastPushed == '(') || (ch == ']' && lastPushed == '[') || (ch == '}' && lastPushed == '{')){
            return true;
        }
        return false;
    }
    
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        if(s.Length == 1){
            return false;
        }

        for( int i = 0; i < s.Length; i++){
            IsOpen(s[i], stack);
            if((s[i] == '}') || (s[i] == ')') || (s[i] == ']')){
                if(!IsClose(s[i], stack)){
                    return false;
                }
            }
        }
        if(stack.Count == 0){
            return true;
        }
        return false;
    }
}