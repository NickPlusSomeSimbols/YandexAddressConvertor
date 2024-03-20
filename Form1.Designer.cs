namespace YandexConfertor_5;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        button1 = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        textBox3 = new TextBox();
        richTextBox1 = new RichTextBox();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        button1.ImageAlign = ContentAlignment.BottomCenter;
        button1.Location = new Point(342, 493);
        button1.Name = "button1";
        button1.Size = new Size(143, 41);
        button1.TabIndex = 0;
        button1.Text = "Execute";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(565, 90);
        label1.TabIndex = 2;
        label1.Text = resources.GetString("label1.Text");
        label1.TextAlign = ContentAlignment.BottomLeft;
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label2.AutoSize = true;
        label2.Location = new Point(12, 131);
        label2.Name = "label2";
        label2.Size = new Size(158, 15);
        label2.TabIndex = 3;
        label2.Text = "Input path of .xlsx or .xls file:";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label3.AutoSize = true;
        label3.Location = new Point(12, 199);
        label3.Name = "label3";
        label3.Size = new Size(168, 15);
        label3.TabIndex = 4;
        label3.Text = "Output path of .xlsx or .xls file:";
        label3.Click += label3_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        label4.AutoSize = true;
        label4.Location = new Point(12, 265);
        label4.Name = "label4";
        label4.Size = new Size(87, 15);
        label4.TabIndex = 5;
        label4.Text = "Yandex API key";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(12, 149);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(579, 23);
        textBox1.TabIndex = 6;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(12, 217);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(579, 23);
        textBox2.TabIndex = 7;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(12, 283);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(579, 23);
        textBox3.TabIndex = 8;
        // 
        // richTextBox1
        // 
        richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        richTextBox1.Location = new Point(12, 358);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(800, 129);
        richTextBox1.TabIndex = 9;
        richTextBox1.Text = "";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(824, 546);
        Controls.Add(richTextBox1);
        Controls.Add(textBox3);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(button1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button button1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox textBox1;
    private TextBox textBox2;
    private TextBox textBox3;
    private RichTextBox richTextBox1;
    
    public event EventHandler ButtonClick;

}
