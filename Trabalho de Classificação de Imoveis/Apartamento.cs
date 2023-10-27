//criei a clase Apartamento que é publica e que é filha/herda a imovel
public class Apartamento : Imovel
{
    public Apartamento(int id, string endereco, double preco, double metrosQuadrados) 
        : base(id, endereco, preco, metrosQuadrados) { }

    public override void AtualizarPreco(double preco)
    {
        this.preco = preco;
    }

    public override void VerificarImovel()
    {
        Console.WriteLine("ID do Apartamento:");
        Console.WriteLine(this.id);
        Console.WriteLine("Endereço do Apartamento:");
        Console.WriteLine(this.endereco);
        Console.WriteLine("Preço do Apartamento:");
        Console.WriteLine(this.preco);
        Console.WriteLine("Metros Quadraros do Apartamento:");
        Console.WriteLine(this.metrosQuadrados);
    }
}