using Practica3._2.Entities;
namespace Practica3._2
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
            buttonAgregarA = new Button();
            buttonCalificar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxCalificacion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // buttonAgregarA
            // 
            buttonAgregarA.Location = new Point(296, 102);
            buttonAgregarA.Name = "buttonAgregarA";
            buttonAgregarA.Size = new Size(330, 57);
            buttonAgregarA.TabIndex = 0;
            buttonAgregarA.Text = "Agregar Alumno";
            buttonAgregarA.UseVisualStyleBackColor = true;
            buttonAgregarA.Click += buttonAgregarA_Click;
            // 
            // buttonCalificar
            // 
            buttonCalificar.Location = new Point(296, 333);
            buttonCalificar.Name = "buttonCalificar";
            buttonCalificar.Size = new Size(330, 52);
            buttonCalificar.TabIndex = 2;
            buttonCalificar.Text = "Calificar";
            buttonCalificar.UseVisualStyleBackColor = true;
            buttonCalificar.Click += buttonCalificar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(267, 69);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(399, 69);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(125, 27);
            textBoxApellido.TabIndex = 4;
            // 
            // textBoxCalificacion
            // 
            textBoxCalificacion.Location = new Point(529, 69);
            textBoxCalificacion.Name = "textBoxCalificacion";
            textBoxCalificacion.Size = new Size(125, 27);
            textBoxCalificacion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 47);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(399, 47);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 47);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 8;
            label3.Text = "Calificación";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(102, 165);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(692, 144);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(43, 392);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(399, 204);
            listBox2.TabIndex = 10;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(479, 392);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(399, 204);
            listBox3.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 368);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 12;
            label4.Text = "Alumnos Aprobados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(727, 365);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 13;
            label5.Text = "Alumnos Reprobados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 675);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCalificacion);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCalificar);
            Controls.Add(buttonAgregarA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregarA;
        private Button buttonCalificar;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxCalificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label4;
        private Label label5;
    }
}