using DesktopAbstractFactoryExample.Core;
using DesktopAbstractFactoryExample.Core.Humans;
using DesktopAbstractFactoryExample.Core.Orcs;
using DesktopAbstractFactoryExample.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample.UI
{
    internal class PickABreedDialogBox : Form
    {
        private Button? acceptButton;
        private Button? cancelButton;
        private ComboBox? comboBoxBreed;
        private Label? labelMessage;
        private Label? label1;


        private readonly GameForm _gameForm;
        private readonly List<string> _breeds;


        public PickABreedDialogBox(GameForm gameForm): base() {
            InitializeComponent();
            _gameForm = gameForm;
            _breeds = InitAvailableBreeds();
            comboBoxBreed.Items.AddRange(_breeds.ToArray());
        }


        private static List<string> InitAvailableBreeds()
        {
            var breeds = new List<string>
            {
                Breeds.HUMAN_BREED,
                Breeds.ORC_BREED
            };
            return breeds;
        }

        private void InitializeComponent()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.acceptButton = new Button();
            this.cancelButton = new Button();
            this.comboBoxBreed = new ComboBox();
            this.labelMessage = new Label();
            this.label1 = new Label();
            this.SuspendLayout();
            // 
            // acceptButton
            // 
            this.acceptButton.BackColor = Color.LightGreen;
            this.acceptButton.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.acceptButton.Location = new Point(227, 192);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new Size(133, 39);
            this.acceptButton.TabIndex = 0;
            this.acceptButton.Text = "Seleccionar";
            this.acceptButton.UseVisualStyleBackColor = false;
            this.acceptButton.Click += new EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = SystemColors.ButtonFace;
            this.cancelButton.Font = new Font("Segoe UI Historic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            this.cancelButton.Location = new Point(69, 192);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new Size(108, 39);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new EventHandler(cancelButton_Click);
            // 
            // comboBoxBreed
            // 
            this.comboBoxBreed.FormattingEnabled = true;
            this.comboBoxBreed.Location = new Point(69, 95);
            this.comboBoxBreed.Name = "comboBoxBreed";
            this.comboBoxBreed.Size = new Size(291, 28);
            this.comboBoxBreed.TabIndex = 2;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new Font("Segoe UI Historic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.labelMessage.Location = new Point(69, 135);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new Size(291, 20);
            this.labelMessage.TabIndex = 4;
            this.labelMessage.Text = "Selecciona la raza con la que deseas jugar.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.label1.Location = new Point(155, 29);
            this.label1.Name = "label1";
            this.label1.Size = new Size(98, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Razas";
            // 
            // PickABreedDialogBox
            // 
            this.ClientSize = new Size(438, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.comboBoxBreed);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Name = "PickABreedDialogBox";
            this.Text = "PickABreed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var breed = GetBreedFactorySelected();
            if (breed is null) { this.Close(); return; }
            _gameForm.CreateLand(breed);
            this.Close();
        }


        private BreedFactory? GetBreedFactorySelected()
        {
            try
            {
                if (comboBoxBreed is null) throw new NullReferenceException("No existe el elemento comboBox!");
                string selectedItem = (string)this.comboBoxBreed.SelectedItem;
                switch (selectedItem)
                {
                    case Breeds.HUMAN_BREED: return new HumanBreedFactory();
                    case Breeds.ORC_BREED: return new OrcBreedFactory();                 
                    default:
                        throw new NullReferenceException("No se puede implementar el elemento seleccionado " + selectedItem + " en el comboBox!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Se cerrará el programa.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                throw;
            }

        }

    }
}
