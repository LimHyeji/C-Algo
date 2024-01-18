namespace csharp_algo.programmers
{
    class 하샤드수
    {
        public bool solution(int x)
        {
            bool answer = true;

            string number = x.ToString();

            int sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += number[i] - '0';
            }

            return x % sum == 0 ? true : false;
        }
    }
}
