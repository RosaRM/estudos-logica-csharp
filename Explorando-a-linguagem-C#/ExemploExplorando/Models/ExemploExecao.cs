using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExecao
    {
        public void Metodo1(){
            try 
            {
                Metodo2();
            }catch(Exception ec)
            {
                Console.WriteLine("Exceção tratada" + ec.Message);
            }
            
        }
        public void Metodo2(){
            Metodo3();
        }
        public void Metodo3(){
            Metodo4();
        }
        public void Metodo4(){
            throw new Exception("Ocorreu uma exeção");
        }
    }
}