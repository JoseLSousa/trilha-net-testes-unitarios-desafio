using TestesUnitarios.Desafio;
using TestesUnitarios.Desafio.Console.Services;

ValidacoesString vstg = new ValidacoesString();

var resultado = vstg.TextoTerminaCom("Começo, meio e fim do texto procurado", "procurado");

if(resultado){
    Console.WriteLine("Contem");
}else
    Console.WriteLine("NContem");
