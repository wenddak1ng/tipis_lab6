using System;
using MassConverter;

namespace tipis_lab6 {
  class MainClass {
    public static void Main(string[] args) {
      Console.Title = "Mass Converter";
      Console.WriteLine("Введите массу (в килограммах): ");
      double mass = double.Parse(Console.ReadLine());
      var result = Output.Add_Multiply(Converter.ConvertFromKgToOunce(mass), Converter.ConvertFromOunceToGr(Converter.ConvertFromKgToOunce(mass)));
      Console.WriteLine(
          "{0}кг = {1} фунтов\n", mass, Math.Round(Converter.ConvertFromKgToPound(mass) * 1000) / 1000);
      Console.WriteLine(
          "{0}кг = {1} унций аптекарских = {2}гр\n", mass, result.ounce, result.gramm);
      Console.WriteLine(
          "{0}кг = {1} слаг", mass, Math.Round(Converter.ConvertFromKgToSlug(mass) * 1000) / 1000);
      Console.ReadKey();
    }
  }
}
