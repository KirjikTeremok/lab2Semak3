﻿using System;

namespace WindowsFormsApp1
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
            this.inputButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.RemotePortTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LocalPortTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(41, 85);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(131, 37);
            this.inputButton.TabIndex = 0;
            this.inputButton.Text = "вход";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(595, 81);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(150, 41);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "выход";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(41, 159);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(704, 215);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // RemotePortTextbox
            // 
            this.RemotePortTextbox.Location = new System.Drawing.Point(41, 38);
            this.RemotePortTextbox.Name = "RemotePortTextbox";
            this.RemotePortTextbox.Size = new System.Drawing.Size(110, 22);
            this.RemotePortTextbox.TabIndex = 3;
            this.RemotePortTextbox.TextChanged += new System.EventHandler(this.RemotePortTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "удаленный порт";
            // 
            // LocalPortTextBox
            // 
            this.LocalPortTextBox.Location = new System.Drawing.Point(593, 34);
            this.LocalPortTextBox.Name = "LocalPortTextBox";
            this.LocalPortTextBox.Size = new System.Drawing.Size(134, 22);
            this.LocalPortTextBox.TabIndex = 5;
            this.LocalPortTextBox.TextChanged += new System.EventHandler(this.LocalPortTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(593, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "свой порт";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(250, 30);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(290, 22);
            this.MessageTextBox.TabIndex = 7;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(250, 85);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(289, 36);
            this.SendButton.TabIndex = 8;
            this.SendButton.Text = "отправить сообщение";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(252, 397);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(287, 22);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // labelN
            // 
            this.labelN.Location = new System.Drawing.Point(128, 397);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(103, 19);
            this.labelN.TabIndex = 10;
            this.labelN.Text = "введите имя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LocalPortTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemotePortTextbox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.inputButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox NameTextBox;

        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button SendButton;

        private System.Windows.Forms.TextBox RemotePortTextbox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocalPortTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RichTextBox richTextBox1;

        private System.Windows.Forms.Button inputButton;

        #endregion
    }
}