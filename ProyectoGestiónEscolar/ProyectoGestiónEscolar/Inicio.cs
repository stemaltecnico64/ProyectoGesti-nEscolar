using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGestiónEscolar
{
    public partial class Inicio : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Inicio()
        {
            InitializeComponent();
            menu_inicio1.BringToFront();
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }



        private void btn_alumnos_Click(object sender, EventArgs e)
        {
            menu_alumnos1.BringToFront();
            lblTitle.Text = "ALUMNOS";
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            menu_inicio1.BringToFront();
            lblTitle.Text = "INICIO";
        }
    }
}
