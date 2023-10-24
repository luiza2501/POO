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
        int id = int.Parse(Console.ReadLine());
        string endereco  = string.Parse(Console.ReadLine());
        double preco = double.Parse(Console.ReadLine());
        double MetrosQuadrados = double.Parse(Console.ReadLine());
        Imovel casa = new Imovel(id, endereco, preco, MetrosQuadrados);

        Adicionar();
    }
    if(resposta == 2){

    }
    if(resposta == 3){

    }
    if(resposta == 4){

    }
    }

    }
}


