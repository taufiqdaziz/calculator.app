class Calculator
{
	static void main (string[]args)
	{
		int a = 10;
		int b = 6;
		
		console.writeline("hasil penambahan : {0} + {1} = {2}", a, b, penambahn(a, b));
		console.writeline("hasil pengurangan : {0} - {1} = {2}", a, b, penambahn(a, b));
		console.writeline("hasil perkalian : {0} x {1} = {2}", a, b, perkalian(a, b));
		console.writeline("hasil pembagian : {0} : {1} = {2}", a, b, pembagian(a, b));
		
		console.writeline("\ntekan enter untuk keluar");
		console.readkey();
	}
	static int penambahan(int a, int b);
	{
		return a+b;
	}
	static int pengurang(int a, int b);
	{
		return a-b;
	}
	static int perkalian(int a, int b);
	{
		retrun a*b;
	}
	static int pembagian(int a, int b);
	{
		retrun a/b;
	}
}
