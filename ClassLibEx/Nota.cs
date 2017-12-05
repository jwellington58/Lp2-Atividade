namespace ClassLibEx{
    public class Nota
    {
        private int id;
        private string título;
        private string conteúdo;
        public Nota(int id, string título, string conteúdo)
        {
            this.id = id;
            this.título = título;
            this.conteúdo = conteúdo;
        }
    }
}