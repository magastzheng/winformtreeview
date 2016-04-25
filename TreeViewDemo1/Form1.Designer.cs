namespace TreeViewDemo1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeViewEx1 = new TreeViewDemo1.TreeViewEx();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "right.png");
            this.imageList1.Images.SetKeyName(1, "down.png");
            this.imageList1.Images.SetKeyName(2, "weiyan.jpg");
            this.imageList1.Images.SetKeyName(3, "曹植.jpg");
            this.imageList1.Images.SetKeyName(4, "法正.jpg");
            this.imageList1.Images.SetKeyName(5, "简雍.png");
            this.imageList1.Images.SetKeyName(6, "陆逊.jpg");
            this.imageList1.Images.SetKeyName(7, "卧龙.jpg");
            this.imageList1.Images.SetKeyName(8, "荀攸.jpg");
            this.imageList1.Images.SetKeyName(9, "诸葛瑾.jpg");
            // 
            // treeViewEx1
            // 
            this.treeViewEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            //this.treeViewEx1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.treeViewEx1.ImageIndex = 0;
            this.treeViewEx1.ImageList = this.imageList1;
            this.treeViewEx1.Indent = 20;
            this.treeViewEx1.ItemHeight = 30;
            this.treeViewEx1.Location = new System.Drawing.Point(0, 0);
            this.treeViewEx1.Name = "treeViewEx1";
            this.treeViewEx1.NodeCollapseImage = imageList1.Images[0];
            this.treeViewEx1.NodeExpandedImage = imageList1.Images[1];
            this.treeViewEx1.NodeFont = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.treeViewEx1.NodeImageSize = new System.Drawing.Size(18, 18);
            this.treeViewEx1.NodeOffset = 5;
            //this.treeViewEx1.SelectedImageIndex = 0;
            //this.treeViewEx1.ShowLines = false;
            //this.treeViewEx1.ShowPlusMinus = false;
            this.treeViewEx1.Size = new System.Drawing.Size(544, 329);
            this.treeViewEx1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 329);
            this.Controls.Add(this.treeViewEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeViewEx treeViewEx1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

