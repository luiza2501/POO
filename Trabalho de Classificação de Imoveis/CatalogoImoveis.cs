// criei a classe catalogoimoveis 
public class CatalogoImoveis
{
//declarei uma variavel publica, uma lista
    public static List<Imovel> imoveis = new List<Imovel>();

//criei um construtor pra classe
    // criei o metodo para adicionar um imóvel
    public static void Adicionar(Imovel imovel)
    {
        imoveis.Add(imovel);
    }

    // Método para remover um imóvel
    public static void Remover(int id)
    {
        for (int i = 0; i < imoveis.Count; i++){
            
        }
    } 
//Declarei o método VerificarCatalogo
     public void VerificarCatalogo()
    {
        //Usei o metodo de repetição foreach iniciar a linha de codigo abaixo que vai ser repetido a cada Imovel na lista
        foreach (var imovel in imoveis)
        {
            Console.WriteLine($"ID: {imovel.id}, Endereço: {imovel.endereco}, Preço: {imovel.preco}, Metros Quadrados: {imovel.metrosQuadrados}.");
         
        }
    }

}