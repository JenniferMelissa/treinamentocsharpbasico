using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.AulaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //contador
            int cont = 1;
            //condição
            string c = "git init";
            while (cont <= 20)
            { 
                if(cont > 10)
                {
                    c = "git status";
                }
            
                Console.WriteLine($"<{cont}> - {c}");
                //incremento
                cont++; //ou cont=cont+1;
            }
            Console.ReadKey();
        }
    }
}
