namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        private string Modelo { get; set; }

        private string MEI { get; set; }

        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string mei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            MEI = mei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirSmartphone()
        {
            Console.WriteLine($"O modelo é {Modelo} com {Memoria}GB de memória.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}