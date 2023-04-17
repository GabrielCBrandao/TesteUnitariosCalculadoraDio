using Calculadora.Services;

CalculadoraImp c= new CalculadoraImp();

int numero1 = 0;
int numero2 = 10;

System.Console.WriteLine($"A soma de {numero1} e {numero2} é igual a :{c.Somar(numero1,numero2)}");