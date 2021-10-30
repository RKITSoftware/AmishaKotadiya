using System;
using System.Collections;

namespace CollectionsNongeneric_ArrayList
{
    class Nongeneric_ArrayList
    {
        static void Main(string[] args)
        {
            ArrayList objarrayList = new ArrayList()
            {
                'A',9.17f,null
            };
            int[] array = {21,22,23,24,25};
            int[] newarray = {26,27,28};
            objarrayList.AddRange(array);
            objarrayList.Add("Amisha");
            objarrayList.Add("Kotadiya");
            objarrayList.Remove(25);
            objarrayList.Remove(null);
            foreach (object obj in objarrayList)
            {
                Console.Write(obj+",");
            }
            //output - A,9.17,21,22,23,24,Amisha,Kotadiya,

            Console.WriteLine();
            Console.WriteLine("Does arraylist contains Amisha:"+arrayList.Contains("Amisha"));
            //Does arraylist contains Amisha:True

            arrayList.InsertRange(6, newarray);
            foreach (object obj in objarrayList)
            {
                Console.Write(obj + ",");
            }
            //A,9.17,21,22,23,24,26,27,28,Amisha,Kotadiya,
        }
    }
}