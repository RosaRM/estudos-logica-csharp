using ExemploPOO.Models;


ContaCorrente conta = new ContaCorrente(123456 , 1000.5M);



conta.MostrarSaldo();
conta.Sacar(1500);
conta.MostrarSaldo();

// Pessoa p1 = new Pessoa("Kelvin" , 9);

// p1.Apresentar();