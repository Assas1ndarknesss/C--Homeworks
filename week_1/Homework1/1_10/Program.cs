Console.WriteLine();    
string n = Console.ReadLine();
int num = Convert.ToInt32(n);
string inter;
int tot;
if (num < 100)
{
    inter = "5%";
    tot =(int)(num *1.05);
}
else if (num >= 100 && num <= 200){
     inter = "7%";
    tot =(int)(num *1.07);
}
else{
    inter="10%";
    tot=(int)(num*1.10);
}
Console.WriteLine ($"{inter}");
Console.WriteLine ($"{tot}");