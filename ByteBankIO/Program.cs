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
        //int offset; É o índice  que vai deliminar o array do nosso método.
        // int count; informa quantas posições queremos preencher em nosso array do método Read.

        //criamos nosso array de byte de 1Kb.
        var buffer = new byte[1024]; //quantidade de 1Kb.

        fluxoDoArquivo.Read(buffer,0,1024);
        Console.WriteLine();

    }
}