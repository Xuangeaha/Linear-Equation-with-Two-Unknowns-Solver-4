using System;

namespace Solver
{
    public class SolverIO
    {
        static void Main(string[] args)
        {
        Console.WriteLine("一元二次方程计算器 Linear Equation with Two Unknowns Solver 2023.4.1");
        Console.WriteLine("作者/开发者：轩哥啊哈OvO   C#");
        Console.WriteLine("Copyright (c) 2023 轩哥啊哈OvO");
        Console.WriteLine("----------------------------------------------------------------------");

        double a = 0;
        double b = 0;
        double c = 0;

        Console.Write("  请设置a的值：");
        try
        {
            a = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            raise_solution("a的值输入有误，请重新输入。");
        }

        Console.Write("  请设置b的值：");
        try
        {
            b = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            raise_solution("b的值输入有误，请重新输入。");
        }

        Console.Write("  请设置c的值：");
        try
        {
            c = Convert.ToDouble(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            raise_solution("c的值输入有误，请重新输入。");
        }

        if (a == 0) {
            if (b == 0) {
                if (c == 0) {
                    equation_to_solve("0=0");
                    raise_solution("原方程的解为任意实数");
                } else {
                    equation_to_solve(c+"=0");
                    raise_solution("原方程无解");
                }
            } else {
                equation_to_solve(b+"x+"+c+"=0");
                double answer = (-1 * c) / b;
                raise_solution("解得：x="+answer);
            }
        } else {
            equation_to_solve(a+"x2+"+b+"x+"+c+"=0");
            double delta = b * b - 4 * a * c;
            double delta_sqrt = Math.Sqrt(delta);
            if (Double.IsNaN(delta_sqrt)) {
                raise_solution("原方程无实数根");
            } else {
                double x1 = (-1 * b + delta) / 2 * a;
                double x2 = (-1 * b - delta) / 2 * a;
                raise_solution("解得：x1="+x1+", x2="+x2);
            }
        }

        static void equation_to_solve(String equation) {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("  解方程：" + equation);
        }

        static void raise_solution(String solution) {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("  " + solution);
            Console.WriteLine("----------------------------------------------------------------------");
        }
      }
   }
}
