 int a = Convert.ToInt32(Console.ReadLine());    
    int [] ad = new int [a];
    
    for(int i=0; i<a; i++)
    {
        ad[i]=Convert.ToInt32(Console.ReadLine());
    }
    
    int []newad= new int [2];
    
    for(int i=0; i < a-1; i++)
    {
        if(ad[i]>0 && ad[i+1]>0 || ad[i]<0 && ad[i+1]<0)
        {
            newad[0] = ad[i];
            newad[1] = ad[i+1];
        }
    }
    for(int i=0; i < 2; i++)
    {
        Console.Write(newad[i]+" ");
    }
    


