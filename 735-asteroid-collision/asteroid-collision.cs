public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> result = new Stack<int>();
        if(asteroids.Length == 1){
            return asteroids;
        }
        for ( int i = 0; i< asteroids.Length; i ++){
            if(asteroids[i] < 0){
                int a = 0;
                if(result.Count() > 0){
                    a = result.Pop();
                    if(a<0){
                        result.Push(a);
                        result.Push(asteroids[i]);
                        continue;
                    }
                    if(a == asteroids[i]*(-1)){
                        continue;
                    }
                    else if(a > (asteroids[i] * (-1))){
                        result.Push(a);
                    }
                    else{
                        i--;
                        continue;
                    }
                }
                else{
                    result.Push(asteroids[i]);
                }
            }
            else{
                result.Push(asteroids[i]);
            }
        }
        int[] res = new int[result.Count()];

        for(int i =0; i<res.Length; i++){
            res[i]=result.Pop();
        }
        Array.Reverse(res);
        return res;
    }
}