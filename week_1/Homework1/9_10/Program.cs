int a =Convert.ToInt32(Console.ReadLine());
int []add = new int [a];
for (int i=0;i<a;i++)
{
 add[i]=Convert.ToInt32(Console.ReadLine());
}
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
for(int j=b; j<c;j++){
    if(add[j]%2!=0){
        Console.Write(add[j] +" ");
    }
}