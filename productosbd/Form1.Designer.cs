namespace productosbd
{
    partial class Form1
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
            lbldescripcion = new Label();
            lblprecio = new Label();
            txtdescripcion = new TextBox();
            txtprecio = new TextBox();
            btnagregar = new Button();
            SuspendLayout();
            // 
            // lbldescripcion
            // 
            lbldescripcion.AutoSize = true;
            lbldescripcion.Location = new Point(186, 161);
            lbldescripcion.Name = "lbldescripcion";
            lbldescripcion.Size = new Size(195, 25);
            lbldescripcion.TabIndex = 0;
            lbldescripcion.Text = "Descripción de Articulo";
            // 
            // lblprecio
            // 
            lblprecio.AutoSize = true;
            lblprecio.Location = new Point(197, 235);
            lblprecio.Name = "lblprecio";
            lblprecio.Size = new Size(60, 25);
            lblprecio.TabIndex = 1;
            lblprecio.Text = "Precio";
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(439, 161);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(150, 31);
            txtdescripcion.TabIndex = 2;
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(439, 229);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(150, 31);
            txtprecio.TabIndex = 3;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(357, 338);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(112, 34);
            btnagregar.TabIndex = 4;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnagregar);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(lblprecio);
            Controls.Add(lbldescripcion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldescripcion;
        private Label lblprecio;
        private TextBox txtdescripcion;
        private TextBox txtprecio;
        private Button btnagregar;
    }
}
