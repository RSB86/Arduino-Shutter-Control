namespace Arduino_Shutter_Control
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
            this.listViewSerialPorts = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonM1Left = new System.Windows.Forms.Button();
            this.buttonM1Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewSerialPorts
            // 
            this.listViewSerialPorts.FullRowSelect = true;
            this.listViewSerialPorts.Location = new System.Drawing.Point(95, 74);
            this.listViewSerialPorts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewSerialPorts.Name = "listViewSerialPorts";
            this.listViewSerialPorts.Size = new System.Drawing.Size(357, 137);
            this.listViewSerialPorts.TabIndex = 1;
            this.listViewSerialPorts.UseCompatibleStateImageBehavior = false;
            this.listViewSerialPorts.SelectedIndexChanged += new System.EventHandler(this.ListViewSerialPorts_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 249);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(98, 225);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(56, 19);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(395, 225);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(56, 19);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonM1Left
            // 
            this.buttonM1Left.Location = new System.Drawing.Point(528, 199);
            this.buttonM1Left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonM1Left.Name = "buttonM1Left";
            this.buttonM1Left.Size = new System.Drawing.Size(56, 19);
            this.buttonM1Left.TabIndex = 5;
            this.buttonM1Left.Text = "M1 Left";
            this.buttonM1Left.UseVisualStyleBackColor = true;
            this.buttonM1Left.Click += new System.EventHandler(this.buttonM1Left_Click);
            // 
            // buttonM1Right
            // 
            this.buttonM1Right.Location = new System.Drawing.Point(609, 199);
            this.buttonM1Right.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonM1Right.Name = "buttonM1Right";
            this.buttonM1Right.Size = new System.Drawing.Size(56, 19);
            this.buttonM1Right.TabIndex = 6;
            this.buttonM1Right.Text = "M1 Right";
            this.buttonM1Right.UseVisualStyleBackColor = true;
            this.buttonM1Right.Click += new System.EventHandler(this.buttonM1Right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 422);
            this.Controls.Add(this.buttonM1Right);
            this.Controls.Add(this.buttonM1Left);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listViewSerialPorts);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewSerialPorts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonM1Left;
        private System.Windows.Forms.Button buttonM1Right;
    }
}

