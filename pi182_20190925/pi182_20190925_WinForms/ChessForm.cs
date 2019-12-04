using System;
using pi182_20190925_classes.Chess;
using System.Drawing;
using System.Windows.Forms;

namespace pi182_20190925_WinForms
{
  public partial class ChessForm : Form
  {
    private ChessBoard _chessBoard;

    public ChessForm()
    {
      InitializeComponent();
      _chessBoard = new ChessBoard();
      h_Render();
    }

    private void h_Render()
    {
      const int ButtonWidth = 30;
      const int ButtonHeight = 30;
      const int ButtonPadding = 5;

      foreach (Field pF in _chessBoard.Fields) {
        Button pB = new Button();
        int iX = pF.Position.X * (ButtonWidth + ButtonPadding);
        int iY = (ChessBoard.Height - pF.Position.Y) * (ButtonHeight + ButtonPadding);
        pB.Width = ButtonWidth;
        pB.Height = ButtonHeight;
        pB.Location = new Point(iX, iY);
        pB.BackColor = pF.Color == EChessColor.Black ? Color.Chocolate : Color.Beige;
        string sText = "";
        if (pF.Figure is SimpleChessFigure) {
          sText = "s";
        }
        else if (pF.Figure is HorseChessFigure) {
          sText = "H";
        }
        pB.Text = sText;
        pB.Tag = pF;
        pB.Parent = panel1;
        pB.Click += h_onPBOnClick;
      }
    }

    private void h_onPBOnClick(object sender, EventArgs args)
    {
      Button btn = (sender as Button);
      var pO = btn.Tag;
      if (pO is Field)
      {
        var pF = pO as Field;
        MessageBox.Show(pF.Position.X + " - " + pF.Position.Y);
      }
    }
  }
}
