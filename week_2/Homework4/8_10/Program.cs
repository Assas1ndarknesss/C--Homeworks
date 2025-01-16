// void addtext(ref string a){
// string s="Welcome";
//   System.Console.Write(s + " " + a);
// }
// string a=Console.ReadLine();
// addtext(ref a);
///////////adding text to value/////////////
// void fillarr(ref int []arr)
// {
//   for (int i = 0; i < arr.Length ; i++)
//   {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
//   }
// }
// void showarrelements(ref int []arr){
//   for (int i = 0; i < arr.Length ; i++)
//   {
// System.Console.Write(arr[i] + " ");
//   }

// }
// int a=Convert.ToInt32(Console.ReadLine());
// int []arr = new int [a];
// fillarr(ref arr);
// showarrelements(ref arr);
///////////////////////////show and adding array////////////////////////////////////////////
// void FindMinMax(ref int min, ref int max)
// {   
// int a = Convert.ToInt32(Console.ReadLine());
//  min = a;
//  max = a;
//     int num;
//     for (; ; )
//     {
//         num = Convert.ToInt32(Console.ReadLine());
//         if (num == 0)
//         {
//             break;
//         }
//         if (num > max)
//         {
//             max = num;
//         }
//         if (num < min)
//         {
//             min = num;
//         }

//     }
// }
// int min=int.MinValue,max=int.MaxValue;
// FindMinMax(ref min, ref max);
// System.Console.WriteLine($"Minimum: {min} ");
// System.Console.WriteLine($"Maximum: {max} ");
///////////////////min max//////////////////////////////
int rec_func(int a,int z=0){
    if (a==0){
        System.Console.WriteLine(z);
        return 0;
    }
    z+=a;
    return rec_func(a-1,z);
}
int a=Convert.ToInt32(Console.ReadLine());
rec_func(a);
//////////////////rec///////////////