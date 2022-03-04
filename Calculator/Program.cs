using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	/// <summary>
	/// Main Class Calculator
	/// </summary>
	public class Calculator
	{
		/// <summary>
		/// Operasi Pertambahan
		/// </summary>
		/// <param name = "a" > angka pertama  dalam operasi pertambahan </ param >
		/// <param name = "b" > angka pertama  dalam operasi pertambahan </ param >
		/// <returns> hasil dari pertambahan angaka pertama dan kedua</returns>
		public double Tambah(double a, double b)
		{
			return a + b;
		}
		/// <summary>
		/// Operasi Perkalian
		/// </summary>
		/// <param name = "a" > angka pertama  dalam operasi pertambahan </ param >
		/// <param name = "b" > angka pertama  dalam operasi pertambahan </ param >
		/// <returns> hasil dari perkalian angaka pertama dan kedua</returns>
		public double Kali(double a, double b)
		{
			return a * b;
		}
		/// <summary>
		/// Operasi Perkalian
		/// </summary>
		/// <param name = "a" > angka pertama  dalam operasi pertambahan </ param >
		/// <param name = "b" > angka pertama  dalam operasi pertambahan </ param >
		/// <returns> hasil dari bagi angaka pertama dan kedua</returns>
		public double Bagi(double a, double b)
		{
			return a / b;
		}
	}
	/// <summary>
	/// Class Pemangil
	/// </summary>
	class Program
	{

		static void Main(string[] args)
		{

			double a = Double.Parse(args[0]);
			double b = Double.Parse(args[1]);

			Calculator cc = new Calculator();

			double tb = cc.Tambah(a, b);
			double kl = cc.Kali(a, b);
			double bg = cc.Bagi(a, b);

			Console.WriteLine("Penjumlahan = {0}", tb);
			Console.WriteLine("Perkalian = {0}", kl);
			Console.WriteLine("Pembagian = {0}", bg);
		}
	}
}