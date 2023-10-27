//criei uma clase que é publica e que é filha/herda a imovel
public class Casa : Imovel
{
    public Casa(int id, string endereco, double preco, double metrosQuadrados) 
        : base(id, endereco, preco, metrosQuadrados) { }

    public override void AtualizarPreco(double preco)
    {
        this.preco = preco;
    }

    public override void VerificarImovel()
    {
        Console.WriteLine("ID da Casa:");
        Console.WriteLine(this.id);
        Console.WriteLine("Endereço da Casa:");
        Console.WriteLine(this.endereco);
        Console.WriteLine("Preço da Casa:");
        Console.WriteLine(this.preco);
        Console.WriteLine("Metros Quadraros da Casa:");
        Console.WriteLine(this.metrosQuadrados);
    }
}