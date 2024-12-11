using System;

namespace ConversorTemperatura
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.Clear();
        Console.WriteLine("=== Conversor de Temperatura ===");
        Console.WriteLine("1. Celsius para Fahrenheit");
        Console.WriteLine("2. Celsius para Kelvin");
        Console.WriteLine("3. Fahrenheit para Celsius");
        Console.WriteLine("4. Fahrenheit para Kelvin");
        Console.WriteLine("5. Kelvin para Celsius");
        Console.WriteLine("6. Kelvin para Fahrenheit");
        Console.WriteLine("7. Sair");
        Console.Write("Escolha uma opção: ");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
          case "1":
            ConverterCelsiusParaFahrenheit();
            break;
          case "2":
            ConverterCelsiusParaKelvin();
            break;
          case "3":
            ConverterFahrenheitParaCelsius();
            break;
          case "4":
            ConverterFahrenheitParaKelvin();
            break;
          case "5":
            ConverterKelvinParaCelsius();
            break;
          case "6":
            ConverterKelvinParaFahrenheit();
            break;
          case "7":
            return;
          default:
            Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
            Console.ReadLine();
            break;
        }
      }
    }

    static void ConverterCelsiusParaFahrenheit()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Celsius: ");
      if (double.TryParse(Console.ReadLine(), out double celsius))
      {
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ConverterCelsiusParaKelvin()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Celsius: ");
      if (double.TryParse(Console.ReadLine(), out double celsius))
      {
        double kelvin = celsius + 273.15;
        Console.WriteLine($"{celsius} °C = {kelvin} K");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ConverterFahrenheitParaCelsius()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Fahrenheit: ");
      if (double.TryParse(Console.ReadLine(), out double fahrenheit))
      {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} °F = {celsius} °C");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ConverterFahrenheitParaKelvin()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Fahrenheit: ");
      if (double.TryParse(Console.ReadLine(), out double fahrenheit))
      {
        double kelvin = (fahrenheit - 32) * 5 / 9 + 273.15;
        Console.WriteLine($"{fahrenheit} °F = {kelvin} K");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ConverterKelvinParaCelsius()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Kelvin: ");
      if (double.TryParse(Console.ReadLine(), out double kelvin))
      {
        double celsius = kelvin - 273.15;
        Console.WriteLine($"{kelvin} K = {celsius} °C");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }

    static void ConverterKelvinParaFahrenheit()
    {
      Console.Clear();
      Console.Write("Digite a temperatura em Kelvin: ");
      if (double.TryParse(Console.ReadLine(), out double kelvin))
      {
        double fahrenheit = (kelvin - 273.15) * 9 / 5 + 32;
        Console.WriteLine($"{kelvin} K = {fahrenheit} °F");
      }
      else
      {
        Console.WriteLine("Entrada inválida.");
      }
      Console.WriteLine("Pressione Enter para continuar.");
      Console.ReadLine();
    }
  }
}
