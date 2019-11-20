using System.Drawing;
using System.Windows.Forms;
using pi182_20190925_classes.AirController;

namespace pi182_20190925_WinForms
{
  public partial class AirControllerForm : Form
  {
    private PictureBox pictureBox;
    private TestAirController _testController;
    public AirControllerForm()
    {
      InitializeComponent();
      _testController = new TestAirController();
      h_DrawController();
    }

    private void h_DrawController()
    {
      for (int ii = 0; ii < _testController.Sensors.Count; ii++)
      {
        AirSensor pSensor = _testController.Sensors[ii];
        h_DrawPictureBox(ii, pSensor);
      }
    }

    private void h_DrawPictureBox(int ii, AirSensor pSensor)
    {
      const int Width = 40;
      int iX = ii * Width + 20;
      int iY = 20;
      PictureBox pictureBox = new PictureBox();
      pictureBox.Location = new System.Drawing.Point(iX, iY);
      pictureBox.Size = new System.Drawing.Size(Width, Width);
      // TODO:
      Controls.Add(this.pictureBox);
    }
  }
}
