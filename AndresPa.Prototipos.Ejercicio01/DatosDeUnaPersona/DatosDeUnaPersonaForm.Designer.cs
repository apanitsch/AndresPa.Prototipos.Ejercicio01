namespace AndresPa.Prototipos.Ejercicio01.DatosDeUnaPersona;

partial class DatosDeUnaPersonaForm
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
        NombreText = new TextBox();
        NombreLabel = new Label();
        ApellidoLabel = new Label();
        ApellidoText = new TextBox();
        DniLabel = new Label();
        DNIText = new TextBox();
        FechaNacimientoLabel = new Label();
        FechaNacText = new TextBox();
        AceptarButton = new Button();
        FinalizarButton = new Button();
        SuspendLayout();
        // 
        // NombreText
        // 
        NombreText.Location = new Point(12, 39);
        NombreText.Name = "NombreText";
        NombreText.Size = new Size(228, 23);
        NombreText.TabIndex = 0;
        // 
        // NombreLabel
        // 
        NombreLabel.AutoSize = true;
        NombreLabel.Location = new Point(12, 21);
        NombreLabel.Name = "NombreLabel";
        NombreLabel.Size = new Size(51, 15);
        NombreLabel.TabIndex = 1;
        NombreLabel.Text = "Nombre";
        // 
        // ApellidoLabel
        // 
        ApellidoLabel.AutoSize = true;
        ApellidoLabel.Location = new Point(246, 21);
        ApellidoLabel.Name = "ApellidoLabel";
        ApellidoLabel.Size = new Size(51, 15);
        ApellidoLabel.TabIndex = 3;
        ApellidoLabel.Text = "Apellido";
        // 
        // ApellidoText
        // 
        ApellidoText.Location = new Point(246, 39);
        ApellidoText.Name = "ApellidoText";
        ApellidoText.Size = new Size(244, 23);
        ApellidoText.TabIndex = 2;
        // 
        // DniLabel
        // 
        DniLabel.AutoSize = true;
        DniLabel.Location = new Point(12, 71);
        DniLabel.Name = "DniLabel";
        DniLabel.Size = new Size(27, 15);
        DniLabel.TabIndex = 5;
        DniLabel.Text = "DNI";
        // 
        // DNIText
        // 
        DNIText.Location = new Point(12, 89);
        DNIText.Name = "DNIText";
        DNIText.Size = new Size(332, 23);
        DNIText.TabIndex = 4;
        // 
        // FechaNacimientoLabel
        // 
        FechaNacimientoLabel.AutoSize = true;
        FechaNacimientoLabel.Location = new Point(350, 71);
        FechaNacimientoLabel.Name = "FechaNacimientoLabel";
        FechaNacimientoLabel.Size = new Size(117, 15);
        FechaNacimientoLabel.TabIndex = 7;
        FechaNacimientoLabel.Text = "Fecha de nacimiento";
        // 
        // FechaNacText
        // 
        FechaNacText.Location = new Point(350, 89);
        FechaNacText.Name = "FechaNacText";
        FechaNacText.Size = new Size(140, 23);
        FechaNacText.TabIndex = 6;
        // 
        // AceptarButton
        // 
        AceptarButton.Location = new Point(334, 137);
        AceptarButton.Name = "AceptarButton";
        AceptarButton.Size = new Size(75, 23);
        AceptarButton.TabIndex = 8;
        AceptarButton.Text = "&Aceptar";
        AceptarButton.UseVisualStyleBackColor = true;
        AceptarButton.Click += AceptarButton_Click;
        // 
        // FinalizarButton
        // 
        FinalizarButton.Location = new Point(415, 137);
        FinalizarButton.Name = "FinalizarButton";
        FinalizarButton.Size = new Size(75, 23);
        FinalizarButton.TabIndex = 9;
        FinalizarButton.Text = "&Finalizar";
        FinalizarButton.UseVisualStyleBackColor = true;
        // 
        // DatosDeUnaPersonaForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(504, 188);
        Controls.Add(FinalizarButton);
        Controls.Add(AceptarButton);
        Controls.Add(FechaNacimientoLabel);
        Controls.Add(FechaNacText);
        Controls.Add(DniLabel);
        Controls.Add(DNIText);
        Controls.Add(ApellidoLabel);
        Controls.Add(ApellidoText);
        Controls.Add(NombreLabel);
        Controls.Add(NombreText);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "DatosDeUnaPersonaForm";
        Text = "Ejercicio 01";
        Load += DatosDeUnaPersonaForm_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox NombreText;
    private Label NombreLabel;
    private Label ApellidoLabel;
    private TextBox ApellidoText;
    private Label DniLabel;
    private TextBox DNIText;
    private Label FechaNacimientoLabel;
    private TextBox FechaNacText;
    private Button AceptarButton;
    private Button FinalizarButton;
}