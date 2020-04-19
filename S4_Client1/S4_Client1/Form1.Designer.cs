namespace S4_Client1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nom_tb = new System.Windows.Forms.TextBox();
            this.Altura_tb = new System.Windows.Forms.TextBox();
            this.Enviar_btn = new System.Windows.Forms.Button();
            this.Longitud_rb = new System.Windows.Forms.RadioButton();
            this.Bonic_rb = new System.Windows.Forms.RadioButton();
            this.Altura_rb = new System.Windows.Forms.RadioButton();
            this.Connectar_btn = new System.Windows.Forms.Button();
            this.Desconnectar_btn = new System.Windows.Forms.Button();
            this.Palindrom_rb = new System.Windows.Forms.RadioButton();
            this.MAjuscules_rb = new System.Windows.Forms.RadioButton();
            this.Consultes_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // Nom_tb
            // 
            this.Nom_tb.Location = new System.Drawing.Point(323, 149);
            this.Nom_tb.Name = "Nom_tb";
            this.Nom_tb.Size = new System.Drawing.Size(100, 22);
            this.Nom_tb.TabIndex = 1;
            // 
            // Altura_tb
            // 
            this.Altura_tb.Location = new System.Drawing.Point(409, 237);
            this.Altura_tb.Name = "Altura_tb";
            this.Altura_tb.Size = new System.Drawing.Size(100, 22);
            this.Altura_tb.TabIndex = 2;
            this.Altura_tb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Enviar_btn
            // 
            this.Enviar_btn.Location = new System.Drawing.Point(328, 319);
            this.Enviar_btn.Name = "Enviar_btn";
            this.Enviar_btn.Size = new System.Drawing.Size(75, 23);
            this.Enviar_btn.TabIndex = 3;
            this.Enviar_btn.Text = "Enviar";
            this.Enviar_btn.UseVisualStyleBackColor = true;
            this.Enviar_btn.Click += new System.EventHandler(this.Enviar_btn_Click);
            // 
            // Longitud_rb
            // 
            this.Longitud_rb.AutoSize = true;
            this.Longitud_rb.Location = new System.Drawing.Point(323, 177);
            this.Longitud_rb.Name = "Longitud_rb";
            this.Longitud_rb.Size = new System.Drawing.Size(138, 21);
            this.Longitud_rb.TabIndex = 4;
            this.Longitud_rb.TabStop = true;
            this.Longitud_rb.Text = "Longitud del nom";
            this.Longitud_rb.UseVisualStyleBackColor = true;
            // 
            // Bonic_rb
            // 
            this.Bonic_rb.AutoSize = true;
            this.Bonic_rb.Location = new System.Drawing.Point(323, 210);
            this.Bonic_rb.Name = "Bonic_rb";
            this.Bonic_rb.Size = new System.Drawing.Size(137, 21);
            this.Bonic_rb.TabIndex = 5;
            this.Bonic_rb.TabStop = true;
            this.Bonic_rb.Text = "El nom és bonic?";
            this.Bonic_rb.UseVisualStyleBackColor = true;
            // 
            // Altura_rb
            // 
            this.Altura_rb.AutoSize = true;
            this.Altura_rb.Location = new System.Drawing.Point(323, 237);
            this.Altura_rb.Name = "Altura_rb";
            this.Altura_rb.Size = new System.Drawing.Size(80, 21);
            this.Altura_rb.TabIndex = 6;
            this.Altura_rb.TabStop = true;
            this.Altura_rb.Text = "Sóc alt?";
            this.Altura_rb.UseVisualStyleBackColor = true;
            // 
            // Connectar_btn
            // 
            this.Connectar_btn.Location = new System.Drawing.Point(121, 102);
            this.Connectar_btn.Name = "Connectar_btn";
            this.Connectar_btn.Size = new System.Drawing.Size(126, 97);
            this.Connectar_btn.TabIndex = 7;
            this.Connectar_btn.Text = "Connectar";
            this.Connectar_btn.UseVisualStyleBackColor = true;
            this.Connectar_btn.Click += new System.EventHandler(this.Connectar_btn_Click);
            // 
            // Desconnectar_btn
            // 
            this.Desconnectar_btn.Location = new System.Drawing.Point(121, 210);
            this.Desconnectar_btn.Name = "Desconnectar_btn";
            this.Desconnectar_btn.Size = new System.Drawing.Size(126, 101);
            this.Desconnectar_btn.TabIndex = 8;
            this.Desconnectar_btn.Text = "Desconnectar";
            this.Desconnectar_btn.UseVisualStyleBackColor = true;
            this.Desconnectar_btn.Click += new System.EventHandler(this.Desconnectar_btn_Click);
            // 
            // Palindrom_rb
            // 
            this.Palindrom_rb.AutoSize = true;
            this.Palindrom_rb.Location = new System.Drawing.Point(323, 264);
            this.Palindrom_rb.Name = "Palindrom_rb";
            this.Palindrom_rb.Size = new System.Drawing.Size(165, 21);
            this.Palindrom_rb.TabIndex = 9;
            this.Palindrom_rb.TabStop = true;
            this.Palindrom_rb.Text = "El nom és palíndrom?";
            this.Palindrom_rb.UseVisualStyleBackColor = true;
            // 
            // MAjuscules_rb
            // 
            this.MAjuscules_rb.AutoSize = true;
            this.MAjuscules_rb.Location = new System.Drawing.Point(323, 290);
            this.MAjuscules_rb.Name = "MAjuscules_rb";
            this.MAjuscules_rb.Size = new System.Drawing.Size(231, 21);
            this.MAjuscules_rb.TabIndex = 10;
            this.MAjuscules_rb.TabStop = true;
            this.MAjuscules_rb.Text = "Retornem el nom en Majúscules";
            this.MAjuscules_rb.UseVisualStyleBackColor = true;
            // 
            // Consultes_lbl
            // 
            this.Consultes_lbl.AutoSize = true;
            this.Consultes_lbl.Location = new System.Drawing.Point(245, 382);
            this.Consultes_lbl.Name = "Consultes_lbl";
            this.Consultes_lbl.Size = new System.Drawing.Size(86, 17);
            this.Consultes_lbl.TabIndex = 11;
            this.Consultes_lbl.Text = "Consultes: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 493);
            this.Controls.Add(this.Consultes_lbl);
            this.Controls.Add(this.MAjuscules_rb);
            this.Controls.Add(this.Palindrom_rb);
            this.Controls.Add(this.Desconnectar_btn);
            this.Controls.Add(this.Connectar_btn);
            this.Controls.Add(this.Altura_rb);
            this.Controls.Add(this.Bonic_rb);
            this.Controls.Add(this.Longitud_rb);
            this.Controls.Add(this.Enviar_btn);
            this.Controls.Add(this.Altura_tb);
            this.Controls.Add(this.Nom_tb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom_tb;
        private System.Windows.Forms.TextBox Altura_tb;
        private System.Windows.Forms.Button Enviar_btn;
        private System.Windows.Forms.RadioButton Longitud_rb;
        private System.Windows.Forms.RadioButton Bonic_rb;
        private System.Windows.Forms.RadioButton Altura_rb;
        private System.Windows.Forms.Button Connectar_btn;
        private System.Windows.Forms.Button Desconnectar_btn;
        private System.Windows.Forms.RadioButton Palindrom_rb;
        private System.Windows.Forms.RadioButton MAjuscules_rb;
        private System.Windows.Forms.Label Consultes_lbl;
    }
}

