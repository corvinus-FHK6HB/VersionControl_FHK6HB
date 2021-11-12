
namespace Fejlesztési_minták
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.CreateTimer = new System.Windows.Forms.Timer(this.components);
            this.ConveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnCar = new System.Windows.Forms.Button();
            this.btnBall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnred = new System.Windows.Forms.Button();
            this.btnpresent = new System.Windows.Forms.Button();
            this.btnbox = new System.Windows.Forms.Button();
            this.btnribbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(0, 140);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(788, 312);
            this.mainPanel.TabIndex = 0;
            // 
            // CreateTimer
            // 
            this.CreateTimer.Enabled = true;
            this.CreateTimer.Interval = 3000;
            this.CreateTimer.Tick += new System.EventHandler(this.CreateTimer_Tick);
            // 
            // ConveyorTimer
            // 
            this.ConveyorTimer.Enabled = true;
            this.ConveyorTimer.Interval = 10;
            this.ConveyorTimer.Tick += new System.EventHandler(this.ConveyorTimer_Tick);
            // 
            // btnCar
            // 
            this.btnCar.Location = new System.Drawing.Point(12, 12);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(89, 62);
            this.btnCar.TabIndex = 1;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = true;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // btnBall
            // 
            this.btnBall.Location = new System.Drawing.Point(107, 12);
            this.btnBall.Name = "btnBall";
            this.btnBall.Size = new System.Drawing.Size(89, 62);
            this.btnBall.TabIndex = 2;
            this.btnBall.Text = "Ball";
            this.btnBall.UseVisualStyleBackColor = true;
            this.btnBall.Click += new System.EventHandler(this.btnBall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next:";
            // 
            // btnred
            // 
            this.btnred.BackColor = System.Drawing.Color.Blue;
            this.btnred.Location = new System.Drawing.Point(107, 80);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(89, 23);
            this.btnred.TabIndex = 0;
            this.btnred.UseVisualStyleBackColor = false;
            this.btnred.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpresent
            // 
            this.btnpresent.Location = new System.Drawing.Point(205, 12);
            this.btnpresent.Name = "btnpresent";
            this.btnpresent.Size = new System.Drawing.Size(89, 62);
            this.btnpresent.TabIndex = 4;
            this.btnpresent.Text = "Present";
            this.btnpresent.UseVisualStyleBackColor = true;
            this.btnpresent.Click += new System.EventHandler(this.btnpresent_Click);
            // 
            // btnbox
            // 
            this.btnbox.BackColor = System.Drawing.Color.Red;
            this.btnbox.Location = new System.Drawing.Point(205, 80);
            this.btnbox.Name = "btnbox";
            this.btnbox.Size = new System.Drawing.Size(89, 23);
            this.btnbox.TabIndex = 5;
            this.btnbox.UseVisualStyleBackColor = false;
            this.btnbox.Click += new System.EventHandler(this.btnbox_Click);
            // 
            // btnribbon
            // 
            this.btnribbon.BackColor = System.Drawing.Color.Yellow;
            this.btnribbon.Location = new System.Drawing.Point(205, 109);
            this.btnribbon.Name = "btnribbon";
            this.btnribbon.Size = new System.Drawing.Size(89, 23);
            this.btnribbon.TabIndex = 6;
            this.btnribbon.UseVisualStyleBackColor = false;
            this.btnribbon.Click += new System.EventHandler(this.btnribbon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnribbon);
            this.Controls.Add(this.btnbox);
            this.Controls.Add(this.btnpresent);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBall);
            this.Controls.Add(this.btnCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer CreateTimer;
        private System.Windows.Forms.Timer ConveyorTimer;
        private System.Windows.Forms.Button btnCar;
        private System.Windows.Forms.Button btnBall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btnpresent;
        private System.Windows.Forms.Button btnbox;
        private System.Windows.Forms.Button btnribbon;
    }
}

