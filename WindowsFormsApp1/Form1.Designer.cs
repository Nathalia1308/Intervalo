using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNao = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNao
            // 
            this.btnNao.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.btnNao.AllowDrop = true;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnNao.Font = new System.Drawing.Font("Sitka Small", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.Location = new System.Drawing.Point(302, 198);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(100, 58);
            this.btnNao.TabIndex = 0;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.UseWaitCursor = true;
            this.btnNao.MouseHover += new System.EventHandler(this.btnNao_MouseHover);
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Sitka Small", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(196, 198);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(100, 58);
            this.btnSim.TabIndex = 1;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // txtPergunta
            // 
            this.txtPergunta.Font = new System.Drawing.Font("Sitka Small", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPergunta.Location = new System.Drawing.Point(196, 121);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(206, 44);
            this.txtPergunta.TabIndex = 2;
            this.txtPergunta.Text = "Intervalo?";
            this.txtPergunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPergunta.TextChanged += new System.EventHandler(this.txtPergunta_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 414);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.btnNao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.TextBox txtPergunta;
    }
}

