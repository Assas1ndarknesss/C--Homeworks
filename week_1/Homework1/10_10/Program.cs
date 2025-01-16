int a = Convert.ToInt32(Console.ReadLine());
int []add=new int [a];
for(int i=0;i<a;i++){
    add[i]=Convert.ToInt32(Console.ReadLine());
}
for(int i=0;i<a;i++){
    if (add[i]%2!=0){
        Console.Write(Math.Pow(add[i],2) + " ");
    }
}
