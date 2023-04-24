namespace LeetCodes;

public class LastStoneWeight1046 {
    public int LastStoneWeight(IEnumerable<int> stones) {     
        var stoneList = stones.ToList();
    
        while(stoneList.Count() > 1){

            var heavy = stoneList.Max();
            stoneList.Remove(heavy);
            var heavy2 = stoneList.Max();
            stoneList.Remove(heavy2);

            if(heavy == heavy2){
                continue;
            }

            stoneList.Add(heavy - heavy2);

        }
        if(stoneList.Count() ==1 ){
            return stoneList[0];
        } 

        return 0; 
    }
}