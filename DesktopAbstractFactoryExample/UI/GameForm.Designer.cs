using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAbstractFactoryExample
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLandColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButtonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLand = new System.Windows.Forms.Label();
            this.createCastleButton = new System.Windows.Forms.Button();
            this.createHouseButton = new System.Windows.Forms.Button();
            this.createBarracksButton = new System.Windows.Forms.Button();
            this.textBoxObjectProperties = new System.Windows.Forms.TextBox();
            this.labelObjectProperties = new System.Windows.Forms.Label();
            this.labelBreedSelected = new System.Windows.Forms.Label();
            this.landPictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitButtonMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1118, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartButtonMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartButtonMenuItem
            // 
            this.restartButtonMenuItem.Name = "restartButtonMenuItem";
            this.restartButtonMenuItem.Size = new System.Drawing.Size(138, 26);
            this.restartButtonMenuItem.Text = "Restart";
            this.restartButtonMenuItem.Click += new System.EventHandler(this.restartButtonMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLandColorToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // changeLandColorToolStripMenuItem
            // 
            this.changeLandColorToolStripMenuItem.Name = "changeLandColorToolStripMenuItem";
            this.changeLandColorToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.changeLandColorToolStripMenuItem.Text = "Change land color";
            this.changeLandColorToolStripMenuItem.Click += new System.EventHandler(this.changeLandColorToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitButtonMenuItem
            // 
            this.exitButtonMenuItem.Name = "exitButtonMenuItem";
            this.exitButtonMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitButtonMenuItem.Text = "Exit";
            this.exitButtonMenuItem.Click += new System.EventHandler(this.exitButtonMenuItem_Click);
            // 
            // labelLand
            // 
            this.labelLand.AutoSize = true;
            this.labelLand.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLand.Location = new System.Drawing.Point(962, 62);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(122, 28);
            this.labelLand.TabIndex = 2;
            this.labelLand.Text = "Mi Territorio";
            // 
            // createCastleButton
            // 
            this.createCastleButton.Location = new System.Drawing.Point(104, 174);
            this.createCastleButton.Name = "createCastleButton";
            this.createCastleButton.Size = new System.Drawing.Size(171, 46);
            this.createCastleButton.TabIndex = 3;
            this.createCastleButton.Text = "Generar Castillo";
            this.createCastleButton.UseVisualStyleBackColor = true;
            this.createCastleButton.Click += new System.EventHandler(this.createCastleButton_Click);
            // 
            // createHouseButton
            // 
            this.createHouseButton.Location = new System.Drawing.Point(104, 246);
            this.createHouseButton.Name = "createHouseButton";
            this.createHouseButton.Size = new System.Drawing.Size(171, 46);
            this.createHouseButton.TabIndex = 4;
            this.createHouseButton.Text = "Generar Casa";
            this.createHouseButton.UseVisualStyleBackColor = true;
            this.createHouseButton.Click += new System.EventHandler(this.createHouseButton_Click);
            // 
            // createBarracksButton
            // 
            this.createBarracksButton.Location = new System.Drawing.Point(104, 106);
            this.createBarracksButton.Name = "createBarracksButton";
            this.createBarracksButton.Size = new System.Drawing.Size(171, 46);
            this.createBarracksButton.TabIndex = 5;
            this.createBarracksButton.Text = "Generar Cuartel";
            this.createBarracksButton.UseVisualStyleBackColor = true;
            this.createBarracksButton.Click += new System.EventHandler(this.createBarracksButton_Click);
            // 
            // textBoxObjectProperties
            // 
            this.textBoxObjectProperties.Location = new System.Drawing.Point(35, 347);
            this.textBoxObjectProperties.Multiline = true;
            this.textBoxObjectProperties.Name = "textBoxObjectProperties";
            this.textBoxObjectProperties.Size = new System.Drawing.Size(322, 188);
            this.textBoxObjectProperties.TabIndex = 6;
            // 
            // labelObjectProperties
            // 
            this.labelObjectProperties.AutoSize = true;
            this.labelObjectProperties.Font = new System.Drawing.Font("Segoe UI Historic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelObjectProperties.Location = new System.Drawing.Point(35, 321);
            this.labelObjectProperties.Name = "labelObjectProperties";
            this.labelObjectProperties.Size = new System.Drawing.Size(113, 23);
            this.labelObjectProperties.TabIndex = 7;
            this.labelObjectProperties.Text = "Propiedades: ";
            // 
            // labelBreedSelected
            // 
            this.labelBreedSelected.AutoSize = true;
            this.labelBreedSelected.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBreedSelected.Location = new System.Drawing.Point(400, 62);
            this.labelBreedSelected.Name = "labelBreedSelected";
            this.labelBreedSelected.Size = new System.Drawing.Size(145, 28);
            this.labelBreedSelected.TabIndex = 8;
            this.labelBreedSelected.Text = "Raza: Humanos";
            // 
            // landPictureBox
            // 
            this.landPictureBox.Location = new System.Drawing.Point(400, 106);
            this.landPictureBox.Name = "landPictureBox";
            this.landPictureBox.Size = new System.Drawing.Size(684, 429);
            this.landPictureBox.TabIndex = 9;
            this.landPictureBox.TabStop = false;
            this.landPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.landPictureBox_MouseClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 566);
            this.Controls.Add(this.landPictureBox);
            this.Controls.Add(this.labelBreedSelected);
            this.Controls.Add(this.labelObjectProperties);
            this.Controls.Add(this.textBoxObjectProperties);
            this.Controls.Add(this.createBarracksButton);
            this.Controls.Add(this.createHouseButton);
            this.Controls.Add(this.createCastleButton);
            this.Controls.Add(this.labelLand);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "GameForm";
            this.Text = "Form1";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip mainMenu;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem restartButtonMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelLand;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem changeLandColorToolStripMenuItem;
        private ToolStripMenuItem exitButtonMenuItem;
        private Button createCastleButton;
        private Button createHouseButton;
        private Button createBarracksButton;
        private TextBox textBoxObjectProperties;
        private Label labelObjectProperties;
        private Label labelBreedSelected;
        private PictureBox landPictureBox;
    }
}