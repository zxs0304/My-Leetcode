using System.Collections;
using System.Collections.Generic;
using System.Numerics;


public class TEST17
{
    public IList<string> LetterCombinations(string digits)
    {
        string[] map = new string[]{
            " ",  //0
            "",     //1
            "abc",  //2
            "def",  //3
            "ghi",  //4
            "jkl",  //5
            "mno",  //6
            "pqrs", //7
            "tuv",  //8
            "wxyz" };

        IList<string> allNumbers = new List<string>();
        string curStr ="";
        DiGui(digits,allNumbers,0,map,curStr);

        return allNumbers;
    }

    public void DiGui(string digits, IList<string> allNumbers,int index, string[] map,string curStr)
    {
        //print("index " +index);
        //print(curStr.Length == digits.Length);

        if (curStr.Length == digits.Length)
        {
            allNumbers.Add(curStr);
            return;
        }

        int number = digits[index] - '0';
        string mapStr = map[number];
        for(int i = 0; i < mapStr.Length; i++)
        {
            curStr += mapStr[i];
            DiGui(digits,allNumbers,index+1,map,curStr);
            curStr = curStr.Remove(curStr.Length - 1,1);

        }

    }

    private void Start()
    {
        LetterCombinations("23");
    }
}
