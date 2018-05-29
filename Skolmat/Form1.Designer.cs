namespace Skolmat
{
    partial class Form1
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FoodList = new System.Windows.Forms.ListView();
            this.Dag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.URLBox = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.Label();
            this.Vecka = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 6);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Updatera";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FoodList
            // 
            this.FoodList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.FoodList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Dag,
            this.Vecka,
            this.mat});
            this.FoodList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodList.GridLines = true;
            this.FoodList.HoverSelection = true;
            this.FoodList.Location = new System.Drawing.Point(13, 42);
            this.FoodList.Name = "FoodList";
            this.FoodList.Size = new System.Drawing.Size(980, 421);
            this.FoodList.TabIndex = 1;
            this.FoodList.UseCompatibleStateImageBehavior = false;
            this.FoodList.View = System.Windows.Forms.View.Details;
            // 
            // Dag
            // 
            this.Dag.Text = "Dag";
            this.Dag.Width = 120;
            // 
            // mat
            // 
            this.mat.Text = "Mat";
            this.mat.Width = 2000;
            // 
            // URLBox
            // 
            this.URLBox.Location = new System.Drawing.Point(413, 8);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(580, 20);
            this.URLBox.TabIndex = 2;
            this.URLBox.TextChanged += new System.EventHandler(this.URLBox_TextChanged);
            // 
            // urlText
            // 
            this.urlText.AutoSize = true;
            this.urlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(333, 9);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(74, 16);
            this.urlText.TabIndex = 3;
            this.urlText.Text = "RSS Flöde";
            // 
            // Vecka
            // 
            this.Vecka.Text = "Vecka";
            this.Vecka.Width = 100;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1005, 475);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.FoodList);
            this.Controls.Add(this.UpdateButton);
            this.MaximumSize = new System.Drawing.Size(1021, 514);
            this.MinimumSize = new System.Drawing.Size(1021, 514);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ListView FoodList;
        private System.Windows.Forms.ColumnHeader Dag;
        private System.Windows.Forms.ColumnHeader mat;
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Label urlText;
        private System.Windows.Forms.ColumnHeader Vecka;
    }
}

