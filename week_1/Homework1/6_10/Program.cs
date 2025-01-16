
using System.Xml;

int a = Convert.ToInt32(Console.ReadLine());
    int cnt=0;
   int [] add = new int [a]; 
    for(int i=0;i<a;i++)
    {
         add[i]=Convert.ToInt32( Console.ReadLine());}
    for(int i=1;i<a;i++){
     if(add[i-1]<add[i] && add[i]>add[i+1]){cnt++;}
    }
        Console.WriteLine(cnt);