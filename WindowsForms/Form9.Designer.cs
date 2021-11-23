
namespace WindowsForms
{
    partial class Form9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Temel C#");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Windows Forms");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Web Forms");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("C# Eğitimi", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Sql Eğitimi");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("T SQL Eğitimi");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Veritabanı Programlama", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("HTML");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("CSS");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("JavaScript");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("JQuery");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Web Tasarım", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(255, 101);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Temel C#";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Windows Forms";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Web Forms";
            treeNode4.Name = "Node0";
            treeNode4.Text = "C# Eğitimi";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Sql Eğitimi";
            treeNode6.Name = "Node6";
            treeNode6.Text = "T SQL Eğitimi";
            treeNode7.Name = "Node4";
            treeNode7.Text = "Veritabanı Programlama";
            treeNode8.Name = "Node9";
            treeNode8.Text = "HTML";
            treeNode9.Name = "Node10";
            treeNode9.Text = "CSS";
            treeNode10.Name = "Node11";
            treeNode10.Text = "JavaScript";
            treeNode11.Name = "Node12";
            treeNode11.Text = "JQuery";
            treeNode12.Name = "Node7";
            treeNode12.Text = "Web Tasarım";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(263, 218);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form9";
            this.Text = "Form9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
    }
}