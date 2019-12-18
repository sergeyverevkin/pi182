using pi182_20190925_classes.Clock;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace pi182_20190925_WinForms
{
  public partial class Form1 : Form
  {
    private Clock _clock1;
    private Clock _clock2;
    private List<Clock> _list;
    private List<PictureBox> _pictureBoxList;

    public Form1()
    {
      InitializeComponent();
      _clock1 = new Clock();
      _clock2 = new Clock();
      _list = new List<Clock>();
      _pictureBoxList = new List<PictureBox>();
      const int iCount = 10;
      const int iWidth = 30;
      const int iHeight = 30;
      for(int ii = 0; ii< iCount; ii++) {
        Clock pC = new Clock();
        _list.Add(pC);

        PictureBox pb = new PictureBox();
        pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        pb.Location = new System.Drawing.Point(40 + ii * (iWidth + 10), 40);
        pb.Size = new System.Drawing.Size(iWidth, iHeight);
        pb.Parent = this;
        // TODO (2019-11-13): привязать элемент управления к объекту

        _pictureBoxList.Add(pb);
      }
    }

    private void btnSet_Click(object sender, EventArgs e)
    {
      _clock1.SetTime("19:12:59");
      _clock2.SetTime(DateTime.Now.ToString("HH:mm:ss"));

      Random pR = new Random();
      foreach(Clock pC in _list) {
        pC.SetTime($"{pR.Next(0, 24)}:{ pR.Next(0, 60)}");
      }




      for (int ii = 0; ii < 60; ii++) {
        _clock1.Tick();
        _clock2.Tick();

        labClock1.Text = _clock1.GetTime();
        labClock2.Text = _clock2.GetTime();

        h_SetPicture(pbClock, _clock1);
        h_SetPicture(pictureBox1, _clock2);

        for (int jj = 0; jj < _list.Count; jj++) {
          PictureBox pb = _pictureBoxList[jj];
          Clock pc = _list[jj];
          pc.Tick();
          h_SetPicture(pb, pc);
        }

        Thread.Sleep(1000);
        Application.DoEvents();
      }
    }

    private void h_SetPicture(PictureBox pictureBoxClock, Clock pC)
    {
      using (Graphics pG = pictureBoxClock.CreateGraphics()) {
        pG.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        pG.Clear(Color.White);
        pG.DrawEllipse(Pens.Black, new Rectangle(10, 10, pictureBoxClock.Width - 20, pictureBoxClock.Height - 20));

        Tuple<Point, Point> pH = h_GetArrowPoint(pictureBoxClock, pC.ArrowH);
        pG.DrawLine(Pens.Black, pH.Item1, pH.Item2);
        Tuple<Point, Point> pM = h_GetArrowPoint(pictureBoxClock, pC.ArrowM);
        pG.DrawLine(Pens.Red, pM.Item1, pM.Item2);
        Tuple<Point, Point> pS = h_GetArrowPoint(pictureBoxClock, pC.ArrowS);
        pG.DrawLine(Pens.Green, pS.Item1, pS.Item2);

      }
    }

    private Tuple<Point, Point> h_GetArrowPoint(PictureBox pictureBoxClock, Arrow pArrow)
    {
      int iCenterX = (int)(pictureBoxClock.Width / 2);
      int iCenterY = (int)(pictureBoxClock.Height / 2);

      double a = pArrow.Angle - 90;
      int iArrowLength = pArrow.Length * 10;
      // sin = iTriHeight / Length;
      // cos = iTriWidth / Length;
      // iTriHeight = sin * Length;
      // iTriWidth = cos * Length;
      double iRadPerDegree =
        (2 * Math.PI) / 360;
      int iTriHeight =
        (int)(Math.Sin(iRadPerDegree * a) * iArrowLength);
      int iTriWidth =
        (int)(Math.Cos(iRadPerDegree * a) * iArrowLength);

      return
        new Tuple<Point, Point>(
          new Point(iCenterX, iCenterY),
          new Point(
            iCenterX + iTriWidth,
            iCenterY + iTriHeight)
        );

    }

    private void pbClock_Paint(object sender, PaintEventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
      using (AirControllerForm pForm = new AirControllerForm())
      {
        // модальный режим
        pForm.ShowDialog(this);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      using (CorrectForm pForm = new CorrectForm()) {
        // модальный режим
        pForm.ShowDialog(this);
      }

    }

    private void button3_Click(object sender, EventArgs e)
    {
      using (ChessForm pForm = new ChessForm()) {
        // модальный режим
        pForm.ShowDialog(this);
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      using (SokobanForm pForm = new SokobanForm()) {
        // модальный режим
        pForm.ShowDialog(this);
      }
    }
  }
}
