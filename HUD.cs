using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineSegundao
{
    class HUD : ObjetoDeJogo
    {
        private string textoHUD;
        private Font fonte;
        private Brush pincel;

        public HUD(string novoTextoHUD, 
            int novoX, int novoY, 
            int novaLargura, int novaAltura, 
            Font novaFonte, Brush novoPincel)
        {
            textoHUD = novoTextoHUD;
            retangulo = new Rectangle(novoX, novoY, novaLargura, novaAltura);
            fonte = novaFonte;
            pincel = novoPincel;
        }

        public override void Desenhar(Graphics gfx)
        {
            gfx.DrawString(textoHUD, fonte, pincel, retangulo);
        }      
    }
}
