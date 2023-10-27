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
           if(imoveis[i].id == id){
            imoveis.RemoveAt(i);
           }
        }
    } 
//Declarei o método VerificarCatalogo
     public static void VerificarCatalogo()
    {
        for (int i = 0; i < imoveis.Count; i++){
            imoveis[i].VerificarImovel();
        }
    }   

}