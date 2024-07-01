using ByteBankIO;


class Program
{
    static void Main(string[] args)
    {

        var endereçoDoArquivo = "contas.txt";
        

        var enderecoDoArquivo = "contas.txt";
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);

        //Agora queremos recuperar os bytes que estão nesse arquivo para utilizá-los.

        //Para isso usaremos o:
        //public override int Read(byte[] array, int offset, int count);
        //Paramter:
        //array; armazenar os bytes que ja foram lidos.
        //int offset; É o índice  que vai delimitar o array do nosso método.
        // int count; informa quantas posições queremos preencher em nosso array do método Read.

        //criamos nosso array de byte de 1Kb.
        var buffer = new byte[1024]; //quantidade de 1Kb.

        fluxoDoArquivo.Read(buffer,0,1024);
        Console.WriteLine("GG ###");


        //aqui criamos um método para escrever o nosso Buffer para assim entendermos melhor seu funcionamento
        static void EscreverBuffer(byte[] buffer)
        {
               foreach (var meuByte in buffer)
                  {
                     Console.Write(meuByte);
                     Console.Write(" ");
                  }
        }

        EscreverBuffer(buffer);

        Console.WriteLine("\n");
        Console.WriteLine("digite A e depois ''Enter'' para finalizar");
        

    }
}