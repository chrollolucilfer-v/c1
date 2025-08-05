using System;
class Program{
static void Main(){
	
	Console.WriteLine("Enter your number");
	int num = int.Parse(Console.ReadLine());
	
	
	if(num ==0)
	{
	Console.WriteLine("reversed : 0");	
	}
	else{
		do{
		int digit = num % 10;
		Console.Write(digit);
		num = num/10;
		 }while(num!= 0);
	}
	
	}



}

do{
int digit = num % 10;
	Console.Write(digit);
	num = num/10;

}while(num!=0);

