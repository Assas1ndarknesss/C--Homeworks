 int a=Convert.ToInt32(Console.ReadLine())
  int cnt=0;
  int rev=0;
    for (int i=1;i<=a;i++){
        for(int j=i;j>0;j/=10) {
            rev=rev*10+j%10;
        }if (i==rev){
            Console.WriteLine("")
        }
    }
    