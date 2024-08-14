using ModuloCalculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine("Digite o número para calcular a tabuada:");
int numero = int.Parse(Console.ReadLine());

Tabuada tabuada = new Tabuada(numero);
string resultado = tabuada.Calcular(numero);

Console.WriteLine(resultado);
