using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, System.EventArgs e)
        {
            TreeNode root = new TreeNode();
            root.Text = "根目录";
            //root.ImageIndex = 1;
            //root.SelectedImageIndex = 5;

            TreeNode r1 = new TreeNode();
            r1.Text = "子目录1";
            TreeNode r2 = new TreeNode();
            r2.Text = "子目录2";
            TreeNode r3 = new TreeNode();
            r3.Text = "子目录3";

            root.Nodes.Add(r1);
            root.Nodes.Add(r2);
            root.Nodes.Add(r3);

            TreeNode csNode = new TreeNode();
            csNode.Text = "一级分类";
            //csNode.ImageIndex = 2;
            //csNode.SelectedImageIndex = 6;
            TreeNode cs1 = new TreeNode();
            cs1.Text = "一级分类子类1";
            TreeNode cs2 = new TreeNode();
            cs2.Text = "一级分类子类2";

            csNode.Nodes.Add(cs1);
            csNode.Nodes.Add(cs2);


            treeViewEx1.BeginUpdate();
            this.treeViewEx1.Nodes.Add(root);
            this.treeViewEx1.Nodes.Add(csNode);
            treeViewEx1.EndUpdate();
        }
    }
}
