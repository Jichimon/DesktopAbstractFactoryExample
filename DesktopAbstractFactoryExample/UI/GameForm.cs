using DesktopAbstractFactoryExample.Core;
using DesktopAbstractFactoryExample.UI;
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesktopAbstractFactoryExample
{

    public partial class GameForm : Form
    {


        private BreedFactory? _breedFactory;

        // game objects //////////////////////

        private House? _house;
        private Barracks? _barracks;
        private TownHall? _townhall;

        //////////////////////////////////////

        public GameForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Init();
        }


        private void Init()
        {
            this.textBoxObjectProperties.Clear();
            HidePanel();
            HideButtons();

            ShowPickBreedDialog();
        }

        public void CreateLand(BreedFactory breedFactory)
        {
            _breedFactory = breedFactory;
            ShowPanel();
            ShowButtons();
            this.labelBreedSelected.Text = "Raza: " + _breedFactory.Name;
            this.textBoxObjectProperties.Clear();
        }

        #region Show / Hide Methods
        private void ShowPickBreedDialog()
        {
            var pickBreedDialog = new PickABreedDialogBox(this);
            pickBreedDialog.Show();
        }

        private void HidePanel()
        {
            labelLand.Visible = false;
            landPictureBox.Visible = false;
        }

        private void ShowPanel()
        {
            labelLand.Visible = true;

            landPictureBox.BackColor = GetLandPanelRandomColor();
            landPictureBox.Visible = true;
        }

        private void HideButtons()
        {
            createTownHallButton.Visible = false;
            createBarracksButton.Visible = false;
            createHouseButton.Visible = false;
        }

        private void ShowButtons()
        {
            createTownHallButton.Visible = true;
            createBarracksButton.Visible = true;
            createHouseButton.Visible = true;
            createTownHallButton.Enabled = true;
            createHouseButton.Enabled = true;
            createBarracksButton.Enabled = true;
        }

        #endregion

        #region Menu Actions
        private void restartButtonMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Se reiniciará la partida, ¿decides continuar?", "Restart Game", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK) return;

            Init();
        }

        private void exitButtonMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeLandColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            landPictureBox.BackColor = GetLandPanelRandomColor();
        }

        #endregion

        #region Action Methods
        private void createTownHallButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_breedFactory is null) throw new NullReferenceException("No hay ninguna raza seleccionada!");
                _townhall = _breedFactory.CreateTownHall();
                
                Graphics graphics = landPictureBox.CreateGraphics();
                graphics.DrawImage(_townhall.Image, _townhall.Rectangle);
                graphics.Dispose();
                
                this.createTownHallButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Se cerrará el programa.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void createHouseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_breedFactory is null) throw new NullReferenceException("No hay ninguna raza seleccionada!");
                _house = _breedFactory.CreateHouse();
                
                Graphics graphics = landPictureBox.CreateGraphics();
                graphics.DrawImage(_house.Image, _house.Rectangle);
                graphics.Dispose();
                
                this.createHouseButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Se cerrará el programa.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void createBarracksButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_breedFactory is null) throw new NullReferenceException("No hay ninguna raza seleccionada!");
                _barracks = _breedFactory.CreateBarracks();
                
                Graphics graphics = landPictureBox.CreateGraphics();
                graphics.DrawImage(_barracks.Image, _barracks.Rectangle);
                graphics.Dispose();
                
                this.createBarracksButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Se cerrará el programa.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void landPictureBox_MouseClick(object sender, MouseEventArgs e)
        {

            if (_house is not null && _house.Rectangle.Contains(e.Location))
            {
                this.textBoxObjectProperties.Text = _house.ToString();
            }


            if (_townhall is not null && _townhall.Rectangle.Contains(e.Location))
            {
                this.textBoxObjectProperties.Text = _townhall.ToString();
            }


            if (_barracks is not null && _barracks.Rectangle.Contains(e.Location))
            {
                this.textBoxObjectProperties.Text = _barracks.ToString();
            }
        }

        #endregion

        private static Color GetLandPanelRandomColor()
        {
            Color[] colors =
            {
                Color.FromArgb(117, 102, 61),
                Color.FromArgb(111, 99, 67),
                Color.FromArgb(206,189, 141)
            };
            var rndGenerator = new Random();
            var colorIndex = rndGenerator.Next(0, colors.Length - 1);
            return colors[colorIndex];
        }
    }
}