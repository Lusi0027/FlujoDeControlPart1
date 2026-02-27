namespace Flujo_De_Control1
{
    
  
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Cálculo del ISR (Impuesto sobre la renta)");
                Console.WriteLine();

                Console.WriteLine("Ingrese su salario mensual: ");
                double salario_mensual = Convert.ToDouble(Console.ReadLine());

                double salario_anual = salario_mensual * 12;
                double ISR_mensual = CalcularISR(salario_anual) / 12;

                Console.WriteLine("\n====RESULTADO:=====");
                Console.WriteLine("Su salario anual es de: RD$ " + salario_anual);

                if (ISR_mensual == 0)
                {
                    Console.WriteLine("ISR a pagar: N/A (No aplica)");
                }
                else
                {
                    Console.WriteLine("ISR mensual a pagar: RD$ " + ISR_mensual);
                }
            }
            static double CalcularISR(double salario_anual)
            {
                if (salario_anual <= 416220)
                {
                    return 0;
                }
                else if (salario_anual <= 624329)
                {
                    return (salario_anual - 416220.01) * 0.15;
                }
                else if (salario_anual <= 867123.00)
                {
                    return 31216.00 + (salario_anual - 624329.01) * 0.20;
                }
                else
                {
                    return 79776.00 + (salario_anual - 867123.01) * 0.25;
                }
            }
        }
}