namespace LeetCodes;

public class PalindromeNumber9 {
    public bool IsPalindrome(int x) {
        string stringToCheck = x.ToString();
        int leftIndex = 0;
        var rightIndex = stringToCheck.Length -1;

        // Negative numbers will never be a palindrome
        if(x < 0){
            return false;
        }

        while(rightIndex > leftIndex){
            if (stringToCheck[leftIndex] != stringToCheck[rightIndex]){
                return false;
            }
            leftIndex++;
            rightIndex--;
        }
        return true;
    }
}