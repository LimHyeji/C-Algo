namespace csharp_algo.programmers
{
    class 가운데글자가져오기
    {
          public string solution(string s) {
          int len = s.Length;
          
          if(len % 2 == 0){
              int mid = len/2;   
              return s.Substring(mid-1,2);
          }
          else{
              int mid = len/2;
              return s.Substring(mid,1);
          }
      }
    }
}
