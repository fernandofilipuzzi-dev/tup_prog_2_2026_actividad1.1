namespace Ejercicio1;

partial class FormPrincipal
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
        btnCalcularCosto = new Button();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        listBox1 = new ListBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnCalcularCosto
        // 
        btnCalcularCosto.Location = new Point(13, 31);
        btnCalcularCosto.Margin = new Padding(4, 5, 4, 5);
        btnCalcularCosto.Name = "btnCalcularCosto";
        btnCalcularCosto.Size = new Size(132, 52);
        btnCalcularCosto.TabIndex = 0;
        btnCalcularCosto.Text = "Paso1: Iniciar Cocina";
        btnCalcularCosto.UseVisualStyleBackColor = true;
        btnCalcularCosto.Click += btnClienteCrearCocina_Click;
        // 
        // button1
        // 
        button1.Location = new Point(13, 93);
        button1.Margin = new Padding(4, 5, 4, 5);
        button1.Name = "button1";
        button1.Size = new Size(132, 52);
        button1.TabIndex = 1;
        button1.Text = "Paso 2: Reponer Ingredientes";
        button1.UseVisualStyleBackColor = true;
        button1.Click += btnClienteReponer_Click;
        // 
        // button2
        // 
        button2.Location = new Point(13, 155);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(132, 52);
        button2.TabIndex = 2;
        button2.Text = "Paso 3: Cocinar";
        button2.UseVisualStyleBackColor = true;
        button2.Click += btnClienteCocina_Click;
        // 
        // button3
        // 
        button3.Location = new Point(13, 217);
        button3.Margin = new Padding(4, 5, 4, 5);
        button3.Name = "button3";
        button3.Size = new Size(132, 52);
        button3.TabIndex = 3;
        button3.Text = "Cerrar";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new Point(170, 40);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(292, 244);
        listBox1.TabIndex = 4;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(166, 14);
        label1.Name = "label1";
        label1.Size = new Size(308, 20);
        label1.TabIndex = 5;
        label1.Text = "Conversación de Ana con el ser misterioso";
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(481, 297);
        Controls.Add(label1);
        Controls.Add(listBox1);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(btnCalcularCosto);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormPrincipal";
        Text = "rec";
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalcularCosto;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Label label1;
}

