namespace App12;

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
        buttonText = new Button();
        buttonTransactionFail = new Button();
        buttonTransactionEF = new Button();
        buttonTransactionScope = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // buttonText
        // 
        buttonText.Location = new Point(12, 12);
        buttonText.Name = "buttonText";
        buttonText.Size = new Size(75, 23);
        buttonText.TabIndex = 0;
        buttonText.Text = "Test";
        buttonText.UseVisualStyleBackColor = true;
        buttonText.Click += buttonText_Click;
        // 
        // buttonTransactionFail
        // 
        buttonTransactionFail.Location = new Point(210, 69);
        buttonTransactionFail.Name = "buttonTransactionFail";
        buttonTransactionFail.Size = new Size(161, 23);
        buttonTransactionFail.TabIndex = 1;
        buttonTransactionFail.Text = "Transaction Fail";
        buttonTransactionFail.UseVisualStyleBackColor = true;
        buttonTransactionFail.Click += buttonTransactionFail_Click;
        // 
        // buttonTransactionEF
        // 
        buttonTransactionEF.Location = new Point(210, 98);
        buttonTransactionEF.Name = "buttonTransactionEF";
        buttonTransactionEF.Size = new Size(161, 23);
        buttonTransactionEF.TabIndex = 2;
        buttonTransactionEF.Text = "Transaction EF";
        buttonTransactionEF.UseVisualStyleBackColor = true;
        buttonTransactionEF.Click += buttonTransactionEF_Click;
        // 
        // buttonTransactionScope
        // 
        buttonTransactionScope.Location = new Point(210, 127);
        buttonTransactionScope.Name = "buttonTransactionScope";
        buttonTransactionScope.Size = new Size(161, 23);
        buttonTransactionScope.TabIndex = 3;
        buttonTransactionScope.Text = "Transaction Scope";
        buttonTransactionScope.UseVisualStyleBackColor = true;
        buttonTransactionScope.Click += buttonTransactionScope_Click;
        // 
        // button1
        // 
        button1.Location = new Point(210, 156);
        button1.Name = "button1";
        button1.Size = new Size(161, 23);
        button1.TabIndex = 4;
        button1.Text = "Transaction Repository";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(buttonTransactionScope);
        Controls.Add(buttonTransactionEF);
        Controls.Add(buttonTransactionFail);
        Controls.Add(buttonText);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button buttonText;
    private Button buttonTransactionFail;
    private Button buttonTransactionEF;
    private Button buttonTransactionScope;
    private Button button1;
}
