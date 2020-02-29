using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Closures
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    
    private void btnSubmit_Click(object sender, EventArgs e)
    {
      // I used numeric up down controlls because the only thing this app uses is numbers, and numeric up downs only permit numeric input.
      // I'm honestly not sure what other validation I can add. I haven't figured out a way to break it.

      if(numTemp.Value < -25 || NumWind.Value < -35 || numSnow.Value > 6)
      {
        lblResults.Text = "School is Likely:\nCancelled";
      }
      else
      {
        lblResults.Text = "School is Likely:\nIn Session";
      }
    }
  }
}
