//criei a clase Apartamento que é publica e que é filha/herda a imovel
public class Apartamento : Imovel
{
    public Apartamento(int id, string endereco, double preco, double metrosQuadrados) 
        : base(id, endereco, preco, metrosQuadrados) { }

    public override void AtualizarPreco(double preco)
    {
        this.preco = preco;
    }

    public override void Verificarimovel()
    {
        Console.WriteLine($"Apartamento: {id}, Endereço  {this.Endereco}, Preço: {this.Preco}, Metros Quadrados: {MetrosQuadrados}");
    }
}