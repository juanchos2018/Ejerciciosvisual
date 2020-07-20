namespace ejercicioLp2_u2
{
    partial class Mensaje
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
            this.rbd1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.rbd2 = new System.Windows.Forms.RadioButton();
            this.rbd3 = new System.Windows.Forms.RadioButton();
            this.rbd4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbd0 = new System.Windows.Forms.RadioButton();
            this.rbd5 = new System.Windows.Forms.RadioButton();
            this.txtarchivo = new System.Windows.Forms.TextBox();
            this.txttodo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnuevo = new System.Windows.Forms.TextBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbd1
            // 
            this.rbd1.AutoSize = true;
            this.rbd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd1.Location = new System.Drawing.Point(36, 49);
            this.rbd1.Name = "rbd1";
            this.rbd1.Size = new System.Drawing.Size(230, 22);
            this.rbd1.TabIndex = 0;
            this.rbd1.TabStop = true;
            this.rbd1.Text = "Eliminar un directorio o archivo";
            this.rbd1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(342, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ejecutar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(581, 121);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(134, 20);
            this.txtnombre.TabIndex = 2;
            // 
            // rbd2
            // 
            this.rbd2.AutoSize = true;
            this.rbd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd2.Location = new System.Drawing.Point(36, 81);
            this.rbd2.Name = "rbd2";
            this.rbd2.Size = new System.Drawing.Size(252, 22);
            this.rbd2.TabIndex = 3;
            this.rbd2.TabStop = true;
            this.rbd2.Text = "Renombrar un directorio o archivo";
            this.rbd2.UseVisualStyleBackColor = true;
            this.rbd2.CheckedChanged += new System.EventHandler(this.rbd2_CheckedChanged);
            // 
            // rbd3
            // 
            this.rbd3.AutoSize = true;
            this.rbd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd3.Location = new System.Drawing.Point(36, 117);
            this.rbd3.Name = "rbd3";
            this.rbd3.Size = new System.Drawing.Size(219, 22);
            this.rbd3.TabIndex = 4;
            this.rbd3.TabStop = true;
            this.rbd3.Text = "Mover un directorio o archivo";
            this.rbd3.UseVisualStyleBackColor = true;
            this.rbd3.CheckedChanged += new System.EventHandler(this.rbd3_CheckedChanged);
            // 
            // rbd4
            // 
            this.rbd4.AutoSize = true;
            this.rbd4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd4.Location = new System.Drawing.Point(36, 158);
            this.rbd4.Name = "rbd4";
            this.rbd4.Size = new System.Drawing.Size(190, 22);
            this.rbd4.TabIndex = 5;
            this.rbd4.TabStop = true;
            this.rbd4.Text = "Escribir sobre un archivo";
            this.rbd4.UseVisualStyleBackColor = true;
            this.rbd4.CheckedChanged += new System.EventHandler(this.rbd4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbd0);
            this.groupBox1.Controls.Add(this.rbd5);
            this.groupBox1.Controls.Add(this.rbd4);
            this.groupBox1.Controls.Add(this.rbd1);
            this.groupBox1.Controls.Add(this.rbd2);
            this.groupBox1.Controls.Add(this.rbd3);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 251);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // rbd0
            // 
            this.rbd0.AutoSize = true;
            this.rbd0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd0.Location = new System.Drawing.Point(36, 19);
            this.rbd0.Name = "rbd0";
            this.rbd0.Size = new System.Drawing.Size(214, 22);
            this.rbd0.TabIndex = 8;
            this.rbd0.TabStop = true;
            this.rbd0.Text = "Crear un directorio o archivo";
            this.rbd0.UseVisualStyleBackColor = true;
            this.rbd0.CheckedChanged += new System.EventHandler(this.rbd0_CheckedChanged);
            // 
            // rbd5
            // 
            this.rbd5.AutoSize = true;
            this.rbd5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbd5.Location = new System.Drawing.Point(36, 197);
            this.rbd5.Name = "rbd5";
            this.rbd5.Size = new System.Drawing.Size(204, 22);
            this.rbd5.TabIndex = 7;
            this.rbd5.TabStop = true;
            this.rbd5.Text = "Ver el contenido un archivo";
            this.rbd5.UseVisualStyleBackColor = true;
            // 
            // txtarchivo
            // 
            this.txtarchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarchivo.Location = new System.Drawing.Point(342, 42);
            this.txtarchivo.Name = "txtarchivo";
            this.txtarchivo.Size = new System.Drawing.Size(173, 26);
            this.txtarchivo.TabIndex = 8;
            // 
            // txttodo
            // 
            this.txttodo.Location = new System.Drawing.Point(581, 160);
            this.txttodo.Name = "txttodo";
            this.txttodo.Size = new System.Drawing.Size(134, 20);
            this.txttodo.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnuevo
            // 
            this.txtnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnuevo.Location = new System.Drawing.Point(342, 79);
            this.txtnuevo.Name = "txtnuevo";
            this.txtnuevo.Size = new System.Drawing.Size(173, 26);
            this.txtnuevo.TabIndex = 11;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(342, 126);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(134, 23);
            this.btnopen.TabIndex = 12;
            this.btnopen.Text = "open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 37);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 263);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.txtnuevo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txttodo);
            this.Controls.Add(this.txtarchivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.button1);
            this.Name = "Mensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensaje";
            this.Load += new System.EventHandler(this.Mensaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbd1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.RadioButton rbd2;
        private System.Windows.Forms.RadioButton rbd3;
        private System.Windows.Forms.RadioButton rbd4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtarchivo;
        private System.Windows.Forms.TextBox txttodo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnuevo;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RadioButton rbd5;
        private System.Windows.Forms.RadioButton rbd0;
        private System.Windows.Forms.Button button3;
    }
}