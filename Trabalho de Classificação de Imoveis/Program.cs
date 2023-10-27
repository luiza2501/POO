public class Program
{
    static void Main(string[] args)
    {
        int resposta = 0;

        while(resposta != 5){
            //criei o meno de interação
            Console.WriteLine("1-Adicionar casa ao catálogo:");
            Console.WriteLine("2-Adicionar apartamento ao catálogo:");
            Console.WriteLine("3-Remover imóvel do catálogo:");
            Console.WriteLine("4-Verificar catálogo geral:");
            Console.WriteLine("5-Sair:");
            //CatalogoImoveis catalogoImoveis = new CatalogoImoveis();
            Console.WriteLine("Digite opção");
            resposta = int.Parse(Console.ReadLine());

            if(resposta == 1){
                Console.WriteLine("Digite o id da casa");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o endereço da casa");
                string endereco  = Console.ReadLine();
                Console.WriteLine("Digite o preço da casa");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos Metros quadrados tem a casa");
                double MetrosQuadrados = double.Parse(Console.ReadLine());
                Casa casa = new Casa(id, endereco, preco, MetrosQuadrados);

                CatalogoImoveis.Adicionar(casa);
            }

            else if(resposta == 2){
                Console.WriteLine("Digite o id do apartamento");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o endereço do apartamento");
                string endereco = Console.ReadLine();
                Console.WriteLine("Digite o preço do apartamento");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite quantos metros quadrados tem no apartamento");
                double MetrosQuadrados = double.Parse(Console.ReadLine());
                Apartamento apartamento = new Apartamento(id, endereco, preco, MetrosQuadrados);

                CatalogoImoveis.Adicionar(apartamento); 

            }

            else if(resposta == 3){
                Console.WriteLine("Digite o id do apartamento que deseja excluir");
                int id = int.Parse(Console.ReadLine());

                CatalogoImoveis.Remover(id);
            }

            else if(resposta == 4){
                CatalogoImoveis.VerificarCatalogo();
            }
        }
    }
}
