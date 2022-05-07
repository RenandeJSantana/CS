//Exemplo 01

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist = 270, tempo = 3, velocidade = 90;
            Console.Write("Olá Pessoal.\n");
            Console.WriteLine("Tudo bem com vcs!!!");

            Console.WriteLine("A velocidade é " + velocidade + " km/h");
            //Console.WriteLine($"A velocidade é {velocidade} km/h");
            //Console.WriteLine("A velocidade é {0} km/h",velocidade);

            Console.WriteLine("Para a distância de {0} e o tempo de {1} horas, a velocidade é {2} km/h",dist,tempo,velocidade);
            //Console.WriteLine($"Para a distância de {dist} e o tempo de {tempo} horas, a velocidade é {velocidade} km/h");

            Console.Read();
        }
    }
}

//Exemplo 02

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, lado;

            Console.Write("Digite o lado do quadrado: ");

            lado = Convert.ToDouble(Console.ReadLine());
            area = lado * lado;

            Console.WriteLine($"A área do quadrado é de {area} metros quadrados");

            Console.Read();
        }
    }
}

// Exercício 1: Calcular a área de um triângulo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double bas, altura, area;

            Console.Write("Digite o valor da base do triângulo: ");
            bas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = bas * altura / 2;

            Console.WriteLine($"A área do triângulo é {area} metros quadrados");

            Console.Read();
        }
    }
}

// Exercício 2: Calcular a área de um trapézio

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseMen, baseMai, altura, area;

            Console.Write("Digite o valor da base maior do trapézio: ");
            baseMai = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da base menor do trapézio: ");
            baseMen = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do trapézio: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = ((baseMai + baseMen) / 2) * altura;

            Console.WriteLine($"A área do trapézio é {area} metros quadrados");

            Console.Read();
        }
    }
}

// Exercício 3: Calcular a área de um cilindro

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.Write("Digite o valor do raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());

            volume = Math.PI * Math.Pow(raio,2) * altura;

            Console.WriteLine($"O volume do trapézio é {volume} metros cúbicos");

            Console.Read();
        }
    }
}
