using pi182_20190925_classes.Clock;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace pi182_20190925_WinForms
{
  public partial class Form1 : Form
  {
    private Clock _clock;

    public Form1()
    {
      InitializeComponent();
      _clock = new Clock();
    }

    private void btnSet_Click(object sender, EventArgs e)
    {
      _clock.SetTime("19:12:59");
      for (int ii = 0; ii < 60; ii++) {
        _clock.Tick();
        labClock1.Text = _clock.GetTime();
        labClock2.Text = _clock.GetTime();
        // h_SetPicture(pbClock, _clock);
        Thread.Sleep(1000);
        Application.DoEvents();
      }
    }

    private void h_SetPicture(PictureBox pbClock, Clock pC)
    {
      var pG = pbClock.CreateGraphics();
      //pG.
      // 
    }

    private void pbClock_Paint(object sender, PaintEventArgs e)
    {
      int iCenterX = (int)pbClock.Width / 2;
      int iCenterY = (int)pbClock.Height / 2;

      double a = _clock.ArrowH.Angle;
      int l = _clock.ArrowH.Length * 10;
      // sin = iTriHeight / Length;
      // cos = iTriWidth / Length;
      // iTriHeight = sin * Length;
      // iTriWidth = cos * Length;
      double iRadPerDegree =
        (2 * Math.PI) / 360;
      int iTriHeight = 
        (int) Math.Sin(iRadPerDegree * a) * l;
      int iTriWidth =
        (int)Math.Cos(iRadPerDegree * a) * l;
      e.Graphics.DrawLine(Pens.Red,
        new Point(iCenterX, iCenterY),
        new Point(
          iCenterX + iTriWidth,
          iCenterY - iTriHeight)
      );
    }
  }
}
