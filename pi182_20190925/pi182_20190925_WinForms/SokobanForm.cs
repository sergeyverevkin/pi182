using pi182_20190925_classes.Storage;
using System.Drawing;
using System.Windows.Forms;

namespace pi182_20190925_WinForms
{
  public partial class SokobanForm : Form
  {
    private CGame _game;

    public SokobanForm()
    {
      InitializeComponent();
      _game = new CGame();
      _game.FillStage(1);
      h_Render();
    }



    private void h_Render()
    {
      const int ButtonWidth = 30;
      const int ButtonHeight = 30;
      const int ButtonPadding = 5;

      int iMaxX = _game.GetMaxX();
      int iMaxY = _game.GetMaxY();

      foreach (CStaticObject pSo in _game.StaticObjects) {
        Button pB = new Button();
        int iX = pSo.Location.X * (ButtonWidth + ButtonPadding);
        int iY = pSo.Location.Y * (ButtonHeight + ButtonPadding);
        pB.Width = ButtonWidth;
        pB.Height = ButtonHeight;
        pB.Location = new Point(iX, iY);

        if (pSo is CExitStaticObject) {
          pB.BackColor = Color.Chocolate;
        }
        else
        if (pSo is CWallStaticObject) {
          pB.BackColor = Color.Black;
        }
        pB.Tag = pSo;
        pB.Parent = panel1;
        // pB.Click += h_onPBOnClick;
      }


      foreach (CDynamicObject pSo in _game.DynamicObjects) {
        Button pB = new Button();
        int iX = pSo.Location.X * (ButtonWidth + ButtonPadding);
        int iY = pSo.Location.Y * (ButtonHeight + ButtonPadding);
        pB.Width = ButtonWidth;
        pB.Height = ButtonHeight;
        pB.Location = new Point(iX, iY);

        if (pSo is CPlayerDynamicObject) {
          pB.BackColor = Color.Red;
        }
        else
        if (pSo is CBoxDynamicObject) {
          pB.BackColor = Color.Blue;
        }
        pB.Tag = pSo;
        pB.Parent = panel1;
        // pB.Click += h_onPBOnClick;
      }

    }


  }
}
