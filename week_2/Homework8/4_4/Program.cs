BankAccount sdf= new BankAccount(1002,2000,"John");
System.Console.Write("Deposit:");
decimal num=Convert.ToInt32(Console.ReadLine());
System.Console.Write("With draw:");
 decimal num1=Convert.ToInt32(Console.ReadLine());
sdf.FreezeAccount();
sdf.Deposit(num);
sdf.Withdraw(num1);

class BankAccount
{
  private int accountId;
  private decimal balance;
  public string OwnerName;
  private bool isFrozen;

public BankAccount(int accountId,decimal balance,string OwnerName){
this.accountId=accountId;
this.balance=balance;
this.OwnerName=OwnerName;
}
public void Deposit(decimal amount){ 
     if(isFrozen){
        System.Console.WriteLine("Amount is frozen");
     } 
     else if(amount<0){
        System.Console.WriteLine("Choose number more than zero");
     }
     else {
       System.Console.WriteLine($"Added:{balance+=amount}");
        
        }
}
public void Withdraw(decimal amount){ 
     if(isFrozen){
        System.Console.WriteLine("Amount is frozen");
     } 
     else if(amount<0){
        System.Console.WriteLine("Choose number more than zero");
     }
     else {
       System.Console.WriteLine($"Minused:{balance-=amount}");
}}
public void FreezeAccount(){
    isFrozen=true;
    System.Console.WriteLine(isFrozen);
}

public void UnfreezeAccount(){
    isFrozen=false;
    System.Console.WriteLine(isFrozen);
}
}