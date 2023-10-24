// criei a classe catalogoimoveis 
public class CatalogoImoveis
{
//declarei uma variavel publica, uma lista
    public List<Imovel> imoveis;

//criei um construtor pra classe
    public CatalogoImoveis(){
        //inicializando a lista imovel
        this.imoveis = new List<Imovel>(); 
    }
    // criei o metodo para adicionar um imóvel
    public void Adicionar(Imovel novoImovel)
    {
        imoveis.Add(novoImovel);
    }

    // Método para remover um imóvel
    public void Remover(int id)
    {
        for (int i = 0; i < imoveis.Count; i++){
            
        }
        imoveis.Remove(imovel);
    }
//Declarei o método VerificarCatalogo
     public void VerificarCatalogo()
    {
        //Usei o metodo de repetição foreach iniciar a linha de codigo abaixo que vai ser repetido a cada Imovel na lista
        foreach (var imovel in imoveis)
        {
            Console.WriteLine($"ID: {imovel.Id}, Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Metros Quadrados: {imovel.MetrosQuadrados}.");
         
        }
    }

}