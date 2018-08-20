namespace JIPP_MS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelGround = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSky = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSky = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelSky.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSky)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelGround, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelSky, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1323, 513);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelGround
            // 
            this.tableLayoutPanelGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tableLayoutPanelGround.ColumnCount = 1;
            this.tableLayoutPanelGround.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGround.Location = new System.Drawing.Point(3, 490);
            this.tableLayoutPanelGround.Name = "tableLayoutPanelGround";
            this.tableLayoutPanelGround.RowCount = 1;
            this.tableLayoutPanelGround.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGround.Size = new System.Drawing.Size(1317, 20);
            this.tableLayoutPanelGround.TabIndex = 0;
            // 
            // tableLayoutPanelSky
            // 
            this.tableLayoutPanelSky.ColumnCount = 1;
            this.tableLayoutPanelSky.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSky.Controls.Add(this.pictureBoxSky, 0, 0);
            this.tableLayoutPanelSky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSky.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSky.Name = "tableLayoutPanelSky";
            this.tableLayoutPanelSky.RowCount = 1;
            this.tableLayoutPanelSky.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSky.Size = new System.Drawing.Size(1317, 481);
            this.tableLayoutPanelSky.TabIndex = 1;
            // 
            // pictureBoxSky
            // 
            this.pictureBoxSky.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSky.BackgroundImage")));
            this.pictureBoxSky.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSky.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSky.Name = "pictureBoxSky";
            this.pictureBoxSky.Size = new System.Drawing.Size(1311, 475);
            this.pictureBoxSky.TabIndex = 0;
            this.pictureBoxSky.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 513);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Save the plane";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelSky.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSky)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGround;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSky;
        private System.Windows.Forms.PictureBox pictureBoxSky;
    }
}

