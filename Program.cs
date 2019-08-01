using System;
using System.IO;
using System.Linq;

namespace learning_C_
{
    class Program
    {
        static void Main(string[] args)
        {
    //Lê o arquivo
    StreamReader rd = new StreamReader(@"csv/teste.csv");
    // Grava o arquivo
     StreamWriter valor = new StreamWriter("csv/resulTeste.csv");

    //Declaro uma string que será utilizada para receber a linha completa do arquivo
    string linha = null;

    //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado
    string[] linhaseparada = null;
    string res;
    string tipo = "TESTE";
    string final = "_EX";
    string [] juntar;
    //realizo o while para ler o conteudo da linha

       while ((linha = rd.ReadLine()) != null)
      {

          //com o split adiciono a string 'quebrada' dentro do array
          linhaseparada = linha.Split(';');

            for (int i = 0; i < linhaseparada.Length; i++)
            {
                
                res = linhaseparada[i];
                res = res.ToUpper();
                juntar = res.Split(' ');
            for (int j = 0; j < juntar.Length; j++)
            {
               
                juntar[j] = juntar[j].Substring(0,3);
                
            }
            res = String.Join("_", juntar);

              valor.WriteLine(tipo + res + final) ;
                Console.WriteLine(tipo + res + final) ;

            }
          
      }
      rd.Close();
      valor.Close();

        }
    }
}
