using System.Drawing;

namespace EngineSegundao
{
    class Bola : ObjetoDeJogo
    {
        private Image imagem;
        private int velocidadeX, velocidadeY;

        public Bola(Image novaImagem, 
                    int novaPosX, int novaPosY,
                    int novaLargura, int novaAltura,
                    int direcaoX, int direcaoY)
        {
            imagem = novaImagem;
            retangulo = new Rectangle(novaPosX, novaPosY, 
                                      novaLargura, novaAltura);

            if (direcaoX == 0) velocidadeX = -2;
            else velocidadeX = 2;

            if (direcaoY == 0) velocidadeY = -2;
            else velocidadeY = 2;
        }
        public override void Desenhar(Graphics pincel)
        {
            pincel.DrawImage(imagem, retangulo);
        }

        public void Atualizacao()
        {
            retangulo.X += velocidadeX;
            retangulo.Y += velocidadeY;
        }
    }
}
