using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSegundao
{
    class Projetil : ObjetoDeJogo
    {
        private SolidBrush pincel;
        private int velocidadeY;

        public Projetil(int novoX, int novoY)
        {
            retangulo = new Rectangle(novoX, novoY, 5, 10);
            pincel = new SolidBrush(Color.Red);            
            velocidadeY = -5;
        }

        public override void Desenhar(Graphics gfx)
        {
            gfx.FillRectangle(pincel, retangulo);
        }

        public void Atualizacao()
        {
            retangulo.Y += velocidadeY;          
        }
    }
}
