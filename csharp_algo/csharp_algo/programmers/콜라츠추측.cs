namespace csharp_algo.programmers
{
    class 가운데글자가져오기
    {
          public int solution(int num) {
        
            if(num == 1) return 0;
            
            int answer = 0;
            
            long number = num;
            while(number != 1){
                long temp = number%2;
                
                if(temp == 0) number /= 2;
                else number = number*3 + 1;
                
                answer++;
                
                if(answer == 500) return -1;
            }
            
            return answer;
        }
    }
}
