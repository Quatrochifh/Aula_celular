namespace AulaPOOCelular
{
    public class celular
    {
        public string cor;

        public string celularzinho;
        public string modelo;
        public string tamanho;
        public bool ligado = false;

        public bool Ligar()
        {
            ligado = true;
            return ligado;
        }
        public bool Desligar()
        {
            ligado = false;
            return ligado;
        }
         
        //bool ligadodes = false;

         public string FazerLigacao()
        {
            return "Chamando...";
        }
        public string EnviarMensagem()
        {
            return "Mensagem enviada";
        }


    }
}