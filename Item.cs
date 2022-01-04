using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSegundao
{
    class Item : ObjetoDeJogo
    {
        private Bitmap imagem;
        private int modificador;

        public Item(int novoModificador, 
            int novoX, int novoY, 
            int novaLargura, int novaAltura)
        {
            modificador = novoModificador;
            retangulo = new Rectangle(novoX, novoY, novaLargura, novaAltura);

            if (modificador == 1)
            {
                imagem = Properties.Resources.powerUp;
            }
            else
            {
                imagem = Properties.Resources.powerDown;
            }

        }

        public override void Desenhar(Graphics pincel)
        {
            pincel.DrawImage(imagem, retangulo);
        }

        public int GetModificador()
        {
            return modificador;
        }
    }
}
