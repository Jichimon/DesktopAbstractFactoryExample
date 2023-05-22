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
        private readonly List<GameObject> _objects;
        
        public GameForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this._objects = new List<GameObject>();
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
            _objects.Clear();
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
            createCastleButton.Visible = false;
            createBarracksButton.Visible = false;
            createHouseButton.Visible = false;
        }

        private void ShowButtons()
        {
            createCastleButton.Visible = true;
            createBarracksButton.Visible = true;
            createHouseButton.Visible = true;
            createCastleButton.Enabled = true;
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
        private void createCastleButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_breedFactory is null) throw new NullReferenceException("No hay ninguna raza seleccionada!");
                AddObjectToLand(_breedFactory.CreateTownHall());
                this.createCastleButton.Enabled = false;
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
                AddObjectToLand(_breedFactory.CreateHouse());
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
                AddObjectToLand(_breedFactory.CreateBarracks());
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
            foreach (var gameObject in _objects)
            {
                if (gameObject.Rectangle.Contains(e.Location))
                {
                    this.textBoxObjectProperties.Text= gameObject.ToString();
                }
            }
        }

        #endregion

        private void AddObjectToLand(GameObject gameObject)
        {

            _objects.Add(gameObject);
            Graphics graphics = landPictureBox.CreateGraphics();
            graphics.DrawImage(gameObject.Image, gameObject.Rectangle);
            graphics.Dispose();
        }


        private static Color GetLandPanelRandomColor()
        {
            Color[] colors =
            {
                Color.FromArgb(117, 102, 61),
                Color.FromArgb(111, 99, 67),
                Color.DarkKhaki,
                Color.FromArgb(206,189, 141)
            };
            var rndGenerator = new Random();
            var colorIndex = rndGenerator.Next(0, colors.Length - 1);
            return colors[colorIndex];
        }
    }
}