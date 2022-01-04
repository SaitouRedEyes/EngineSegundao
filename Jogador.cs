using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineSegundao
{
    class Jogador : ObjetoDeJogo
    {
        private SolidBrush pincel;
        private bool moveEsquerda, moveDireita;
        private int velocidadeX;
        private Projetil projetil;

        public Jogador(int novoX, int novoY)
        {
            retangulo = new Rectangle(novoX, novoY, 80, 20);
            pincel = new SolidBrush(Color.Red);
            moveEsquerda = moveDireita = false;
            velocidadeX = 5;
        }

        public override void Desenhar(Graphics gfx)
        {
            gfx.FillRectangle(pincel, retangulo);

            if (projetil != null)
            {
                projetil.Desenhar(gfx);
            }
        }

        public void PreAtualizacao(KeyEventArgs e, bool pressionado)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(pressionado == true)
                {
                    moveEsquerda = true;
                }
                else
                {
                    moveEsquerda = false;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (pressionado == true)
                {
                    moveDireita = true;
                }
                else
                {
                    moveDireita = false;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                if (pressionado == false)
                {
                    projetil = new Projetil(retangulo.X + (retangulo.Width / 2), retangulo.Y);
                }                
            }
        }

        public void Atualizacao()
        {
            if (moveEsquerda == true)
            {
                retangulo.X -= velocidadeX;
            }

            if (moveDireita == true)
            {
                retangulo.X += velocidadeX;
            }

            if (projetil != null) projetil.Atualizacao();
        }
    }
}
