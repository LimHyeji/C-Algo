using System;
using System.Collections;
using System.Collections.Generic;

namespace csharp_algo.programmers
{
    static int n,max;
    static int[] num;
    static bool[] sel;
    
    static int[,] map;
    static List<int> scoreA,scoreB;
    
    static int[] answer;
    
    public int[] solution(int[,] dice) {
        
        init(dice);
        com(0,0);
        
        return answer;
    }
    
    public void init(int[,] dice){
        n=dice.Length/6;
        max=0;
        answer = new int[n/2];
        
        num=new int[n/2];
        sel=new bool[n];
        map=dice;
    } 
    
     public void com(int start,int cnt){
            if(cnt==n/2){
                int[] temp=new int[n/2];
                int idx=0;

                for(int i=0;i<n;i++){
                    if(!sel[i]) temp[idx++]=i; 
                }

                calculate(num,temp);
                return;
            }

            for(int i=start;i<n;i++){
                sel[i]=true;
                num[cnt]=i;
                com(i+1,cnt+1);
                sel[i]=false;
            }
        }
    
        public void calculate(int[] a,int[] b){
        
        int count=0;
        
        scoreA=new List<int>();
        scoreB=new List<int>();
        getScore(a,scoreA,0,0);
        getScore(b,scoreB,0,0);
        
        scoreA.Sort();
        scoreB.Sort();
        
        foreach(int score in scoreA){
            int left=0;
            int right=scoreB.Count-1;
            
            while(left<=right){
                int mid=(left+right)/2;
                
                if(score>scoreB[mid]){
                    left=mid+1;
                } 
                else{
                    right=mid-1;
                }
            }
            count+=left;
        }
        
        if(count>max){
            max=count;
            int idx=0;
            for(int i=0;i<a.Length;i++){
                answer[idx++]=a[i]+1;
            }
        }
        
    }
    
    public void getScore(int[] arr,List<int> score,int sum,int cnt){
        if(cnt==n/2){
            score.Add(sum);
            return;
        }
        
        for(int i=0;i<6;i++){
            getScore(arr,score,sum+map[arr[cnt],i],cnt+1);
        }
    }
}
