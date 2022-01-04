using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSegundao
{
    class Inimigo : ObjetoDeJogo
    {
        private Image imagem;
        private int velocidadeX;
        private float limiteDireita, limiteEsquerda;

        public Inimigo(Image novaImagem,
                    int novaPosX, int novaPosY, Form1 form)
        {
            imagem = novaImagem;
            retangulo = new Rectangle(novaPosX, novaPosY, 
                novaImagem.Width, novaImagem.Height);

            velocidadeX = 2;
            limiteDireita = form.Width * 0.6f;
            limiteEsquerda = form.Width * 0.2f;
        }

        public override void Desenhar(Graphics pincel)
        {
            pincel.DrawImage(imagem, retangulo);
        }

        public void Atualizacao()
        {
            retangulo.X += velocidadeX;

            if (retangulo.X > limiteDireita || 
                retangulo.X < limiteEsquerda) 
                velocidadeX *= -1;           
        }
    }
}
