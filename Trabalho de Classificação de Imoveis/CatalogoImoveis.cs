// criei a classe catalogoimoveis 
public class CatalogoImoveis
{
    public List<Imovel> imoveis;


    public CatalogoImoveis(){
        this.imoveis = new List<Imovel>(); 
    }

    // criei o metodo para adicionar um imóvel
    public void Adicionar(Imovel novoImovel)
    {
        imoveis.Add(novoImovel);
    }

    // Método para remover um imóvel
    public void Remover(Imovel imovel)
    {
        imoveis.Remove(imovel);
    }

     public void VerificarCatalogo()
    {
        foreach (var imovel in imoveis)
        {
            Console.WriteLine($"ID: {imovel.Id}, Endereço: {imovel.Endereco}, Preço: {imovel.Preco}, Metros Quadrados: {imovel.MetrosQuadrados}.");
         
        }
    }

}