namespace Aula_23_windows_form
{
    partial class FrmTree
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nó0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nó4");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nó5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nó9");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nó1", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nó6");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Nó2", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Nó7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Nó3", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btnChecados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nó0";
            treeNode1.Text = "Nó0";
            treeNode2.Name = "Nó4";
            treeNode2.Text = "Nó4";
            treeNode3.Name = "Nó5";
            treeNode3.Text = "Nó5";
            treeNode4.Name = "Nó9";
            treeNode4.Text = "Nó9";
            treeNode5.Name = "Nó1";
            treeNode5.Text = "Nó1";
            treeNode6.Name = "Nó6";
            treeNode6.Text = "Nó6";
            treeNode7.Name = "Nó2";
            treeNode7.Text = "Nó2";
            treeNode8.Name = "Nó7";
            treeNode8.Text = "Nó7";
            treeNode9.Name = "Nó3";
            treeNode9.Text = "Nó3";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode7,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(880, 471);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(54, 31);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(8, 8);
            this.treeView2.TabIndex = 1;
            // 
            // btnChecados
            // 
            this.btnChecados.Location = new System.Drawing.Point(12, 512);
            this.btnChecados.Name = "btnChecados";
            this.btnChecados.Size = new System.Drawing.Size(75, 23);
            this.btnChecados.TabIndex = 2;
            this.btnChecados.Text = "Checados";
            this.btnChecados.UseVisualStyleBackColor = true;
            this.btnChecados.Click += new System.EventHandler(this.btnChecados_Click);
            // 
            // FrmTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 564);
            this.Controls.Add(this.btnChecados);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "FrmTree";
            this.Text = "FrmTree";
            this.Load += new System.EventHandler(this.FrmTree_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btnChecados;
    }
}