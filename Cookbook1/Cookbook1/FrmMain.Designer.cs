using System;

namespace Cookbook1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(26, 27);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(67, 20);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.ItemHeight = 20;
            this.lstRecipes.Location = new System.Drawing.Point(30, 50);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(120, 84);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 20;
            this.lstIngredients.Location = new System.Drawing.Point(182, 50);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(120, 84);
            this.lstIngredients.TabIndex = 3;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(178, 27);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(143, 20);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Recipe Ingredients";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 448);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "FrmMain";
            this.Text = "Cookbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblIngredients;
    }
}

