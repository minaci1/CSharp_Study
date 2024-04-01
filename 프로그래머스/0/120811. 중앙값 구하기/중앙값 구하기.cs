using System;

public class Solution {
    public int solution(int[] array) {
        
        Array.Sort(array);
        
        int a = array.Length;
        
        a /= 2;
        
         
        return array[a];
    }
}