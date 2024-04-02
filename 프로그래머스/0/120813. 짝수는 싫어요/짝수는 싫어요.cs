using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public int[] solution(int n) {
        int count = (n + 1) / 2;  // n 이하의 홀수의 개수 계산
        int[] answer = new int[count];  // 계산된 개수만큼의 크기로 배열 초기화
        
        for (int i = 0; i < count; i++) {
            answer[i] = 2 * i + 1;  // 홀수 생성 및 할당
        }
        return answer;
    }
}
