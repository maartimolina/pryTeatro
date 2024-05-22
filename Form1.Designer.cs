namespace pryTeatro
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuena = new System.Windows.Forms.Button();
            this.btnOnas = new System.Windows.Forms.Button();
            this.btnTobas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(172, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona tu Destino Teatral";
            // 
            // btnQuena
            // 
            this.btnQuena.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnQuena.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuena.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuena.Image = ((System.Drawing.Image)(resources.GetObject("btnQuena.Image")));
            this.btnQuena.Location = new System.Drawing.Point(340, 210);
            this.btnQuena.Name = "btnQuena";
            this.btnQuena.Size = new System.Drawing.Size(163, 46);
            this.btnQuena.TabIndex = 1;
            this.btnQuena.Text = "Quenaken";
            this.btnQuena.UseVisualStyleBackColor = false;
            this.btnQuena.Click += new System.EventHandler(this.btnQuena_Click);
            // 
            // btnOnas
            // 
            this.btnOnas.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnOnas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOnas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOnas.Image = ((System.Drawing.Image)(resources.GetObject("btnOnas.Image")));
            this.btnOnas.Location = new System.Drawing.Point(340, 278);
            this.btnOnas.Name = "btnOnas";
            this.btnOnas.Size = new System.Drawing.Size(163, 46);
            this.btnOnas.TabIndex = 2;
            this.btnOnas.Text = "Onas";
            this.btnOnas.UseVisualStyleBackColor = false;
            this.btnOnas.Click += new System.EventHandler(this.btnOnas_Click);
            // 
            // btnTobas
            // 
            this.btnTobas.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnTobas.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTobas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTobas.Image = ((System.Drawing.Image)(resources.GetObject("btnTobas.Image")));
            this.btnTobas.Location = new System.Drawing.Point(340, 346);
            this.btnTobas.Name = "btnTobas";
            this.btnTobas.Size = new System.Drawing.Size(163, 46);
            this.btnTobas.TabIndex = 3;
            this.btnTobas.Text = "Tobas";
            this.btnTobas.UseVisualStyleBackColor = false;
            this.btnTobas.Click += new System.EventHandler(this.btnTobas_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 502);
            this.Controls.Add(this.btnTobas);
            this.Controls.Add(this.btnOnas);
            this.Controls.Add(this.btnQuena);
            this.Controls.Add(this.label1);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnQuena;
        private Button btnOnas;
        private Button btnTobas;
    }
}