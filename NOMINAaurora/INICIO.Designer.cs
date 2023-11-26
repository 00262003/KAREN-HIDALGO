namespace NOMINAaurora
{
    partial class INICIO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuusario = new FontAwesome.Sharp.IconMenuItem();
            this.menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.menuventas = new FontAwesome.Sharp.IconMenuItem();
            this.menucompra = new FontAwesome.Sharp.IconMenuItem();
            this.menucliente = new FontAwesome.Sharp.IconMenuItem();
            this.menuprovedor = new FontAwesome.Sharp.IconMenuItem();
            this.menureporte = new FontAwesome.Sharp.IconMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.Contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuusario,
            this.menumantenedor,
            this.menuventas,
            this.menucompra,
            this.menucliente,
            this.menuprovedor,
            this.menureporte,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(1663, 81);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuusario
            // 
            this.menuusario.AutoSize = false;
            this.menuusario.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuusario.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.menuusario.IconColor = System.Drawing.Color.Black;
            this.menuusario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuusario.IconSize = 50;
            this.menuusario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuusario.Name = "menuusario";
            this.menuusario.Size = new System.Drawing.Size(80, 77);
            this.menuusario.Text = "Usarios";
            this.menuusario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menumantenedor
            // 
            this.menumantenedor.AutoSize = false;
            this.menumantenedor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menumantenedor.IconColor = System.Drawing.Color.Black;
            this.menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menumantenedor.IconSize = 50;
            this.menumantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menumantenedor.Name = "menumantenedor";
            this.menumantenedor.Size = new System.Drawing.Size(152, 77);
            this.menumantenedor.Text = "Mantenimiento";
            this.menumantenedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuventas
            // 
            this.menuventas.AutoSize = false;
            this.menuventas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuventas.IconColor = System.Drawing.Color.Black;
            this.menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuventas.IconSize = 50;
            this.menuventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuventas.Name = "menuventas";
            this.menuventas.Size = new System.Drawing.Size(80, 77);
            this.menuventas.Text = "Ventas";
            this.menuventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menucompra
            // 
            this.menucompra.AutoSize = false;
            this.menucompra.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucompra.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menucompra.IconColor = System.Drawing.Color.Black;
            this.menucompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucompra.IconSize = 50;
            this.menucompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucompra.Name = "menucompra";
            this.menucompra.Size = new System.Drawing.Size(80, 77);
            this.menucompra.Text = "Compras";
            this.menucompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucompra.Click += new System.EventHandler(this.menucompra_Click);
            // 
            // menucliente
            // 
            this.menucliente.AutoSize = false;
            this.menucliente.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menucliente.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menucliente.IconColor = System.Drawing.Color.Black;
            this.menucliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucliente.IconSize = 50;
            this.menucliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucliente.Name = "menucliente";
            this.menucliente.Size = new System.Drawing.Size(80, 77);
            this.menucliente.Text = "Clientes";
            this.menucliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuprovedor
            // 
            this.menuprovedor.AutoSize = false;
            this.menuprovedor.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprovedor.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuprovedor.IconColor = System.Drawing.Color.Black;
            this.menuprovedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuprovedor.IconSize = 50;
            this.menuprovedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuprovedor.Name = "menuprovedor";
            this.menuprovedor.Size = new System.Drawing.Size(80, 77);
            this.menuprovedor.Text = "Provedor";
            this.menuprovedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureporte
            // 
            this.menureporte.AutoSize = false;
            this.menureporte.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menureporte.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menureporte.IconColor = System.Drawing.Color.Black;
            this.menureporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureporte.IconSize = 50;
            this.menureporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureporte.Name = "menureporte";
            this.menureporte.Size = new System.Drawing.Size(80, 77);
            this.menureporte.Text = "Reportes";
            this.menureporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(80, 77);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.RosyBrown;
            this.menuTitulo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1663, 82);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(159, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMINA AURORA";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Gainsboro;
            this.Contenedor.Controls.Add(this.label1);
            this.Contenedor.Location = new System.Drawing.Point(0, 207);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1714, 450);
            this.Contenedor.TabIndex = 3;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 220);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(468, -78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 160);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 654);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.menu;
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.INICIO_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuusario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompra;
        private FontAwesome.Sharp.IconMenuItem menucliente;
        private FontAwesome.Sharp.IconMenuItem menuprovedor;
        private FontAwesome.Sharp.IconMenuItem menureporte;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

