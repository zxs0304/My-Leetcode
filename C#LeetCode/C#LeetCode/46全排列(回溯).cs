using System.Collections;
using System.Collections.Generic;
public class TEST
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> allNumbers = new List<IList<int>>();
        DiGui(nums,0,allNumbers);

        foreach (var item in allNumbers)
        {

            string str = "";
            foreach (var i in item)
            {
                str += i + " ";

            }
            Console.WriteLine(str);
        }

        return allNumbers;

    }

    public void DiGui(int[] nums,int index, IList<IList<int>> allNumbers)
    {
        if(index == nums.Length)
        {
            allNumbers.Add(new List<int>(nums));
            return;
        }
        for(int i = index; i < nums.Length; i++)
        {
            
            swap(nums,index,i);
            DiGui(nums,index+1,allNumbers);
            swap(nums,index,i);
        }

    }

    public void swap(int[] nums, int i ,int j )
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    public void Start()
    {
        Permute(new int[] {1,2,3 });

    }

}
