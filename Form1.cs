using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineSegundao
{
    public partial class Form1 : Form
    {
        private Bola b1;
        private HUD pontos;
        private Random aleatorio;
        private Item item;
        private Jogador j1;
        private Inimigo i1;        

        public Form1()
        {
            InitializeComponent();

            aleatorio = new Random();

            b1 = new Bola(Properties.Resources.bola, 200, 200, 30, 30, aleatorio.Next(2), aleatorio.Next(2));            

            pontos = new HUD("Pontos: 0", 5, 10, 100, 30, new Font(FontFamily.GenericSansSerif, 12), Brushes.Black);

            item = new Item(aleatorio.Next(2), aleatorio.Next(750), aleatorio.Next(350), 30, 30);

            j1 = new Jogador(360, 410);
            i1 = new Inimigo(Properties.Resources.boss, 360, 50, this);


            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            Timer timer = new Timer();
            timer.Interval = 1000 / 120;
            timer.Start();
            timer.Tick += UpdateGame;

            Paint += new PaintEventHandler(DrawGame);
        }

        private void UpdateGame(object sender, EventArgs e)
        {
            b1.Atualizacao();
            j1.Atualizacao();
            i1.Atualizacao();

            Invalidate();
        }        

        private void DrawGame(object sender, PaintEventArgs e)
        {
            b1.Desenhar(e.Graphics);            
            pontos.Desenhar(e.Graphics);
            item.Desenhar(e.Graphics);
            j1.Desenhar(e.Graphics);
            i1.Desenhar(e.Graphics);
        }

        private void TeclaPressionada(object sender, KeyEventArgs e)
        {
            j1.PreAtualizacao(e, true);
        }

        private void TeclaSolta(object sender, KeyEventArgs e)
        {
            j1.PreAtualizacao(e, false);
        }
    }
}
