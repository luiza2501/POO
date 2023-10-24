public class Program
{
    static void Main(string[] args)
    {
        //criei o meno de interação
        Console.WriteLine("1-Adicionar casa ao catálogo:");
        Console.WriteLine("2-Adicionar apartamento ao catálogo:");
        Console.WriteLine("3-Remover imóvel do catálogo:");
        Console.WriteLine("4-Verificar catálogo geral:");
        Console.WriteLine("5-Sair:");
        CatalogoImoveis = new CatalogoImoveis();
        int resposta = int.Parce(Console.ReadLine());

while(resposta != 5){
    resposta = Menu();
    if(resposta == 1){
     console.WriteLine("Qual o ID do produto?");
     int codigo = int.Parse(Console.ReadLine());
    }
    if(resposta == 2){
       console.WriteLine("Qual o endereço do Imovel?");
        int codigo = int.Parse(Console.ReadLine());
    }
    if(resposta == 3){
    console.WriteLine("Qual o preço do Imovel?");
     int codigo = int.Parse(Console.ReadLine());
    }
    if(resposta == 4){
      console.WriteLine("Quantos metros quadrados tem o Imovel?") ;
       int codigo = int.Parse(Console.ReadLine()); 
    }
    }

    }
}


