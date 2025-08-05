using System;

class Program{
	static void Main(string[] args)
	{
		Console.WriteLine("How many numbers do you want to enter");
		int n = int.Parse(Console.ReadLine());
		
		int[] numbers = new int[n];
	// this makes a array named numbers which takes n numbers of input which is taken from user
		
		for(int i=0; i<n; i++){
		Console.Write("Enter number" + (i+1)+":");
			numbers[i] = int.Parse(Console.ReadLine());
		}
		
	int sum =0;
		foreach (int num in numbers)
		{
			sum += num;
			// this adds teh num to make total in sum
		}
		
		// now printing the sum
		Console.WriteLine("The Sum of the entered number is:" +sum);
	 }
}
