namespace ConsoleApp1;

public class Program

{
	public static void Main()
	{
		Console.WriteLine(":):):) Calculadora em C# :):):)");
		
		Console.WriteLine("Digite o primeiro numero: ");
		double number1 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o segundo numero: ");
		double number2 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o terceiro numero: ");
		double number3 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite oquarto numero: ");
		double number4 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o quinto numero: ");
		double number5 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o sexto numero: ");
		double number6 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o sétimo numero: ");
		double number7 = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Digite o oitavo numero: ");
		double number8 = Convert.ToDouble(Console.ReadLine());


		double sum = number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8;
		double division = sum / 8;
		
		Console.WriteLine("O valor da soma é: " + sum);
		Console.WriteLine("O valor da divisão é: " + division);
		
		if (division >= 7.0)
			Console.WriteLine("Aprovado");
		else 
			Console.WriteLine("Reprovado");

		Console.WriteLine("Pressione Enter para sair...");
		Console.ReadLine();
	}
}