using System.Windows.Forms;
using Eplan.EplApi.Scripting;

// Goal:
// Display a new window form

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public partial class frmTemplate : System.Windows.Forms.Form
{

    #region Vom Windows Form-Designer generierter Code

    // <summary>
    // Required designer variable.
    // </summary>
	
    private System.ComponentModel.IContainer components = null;

    // <summary>
    // Clean used resources.
	
    // </summary>
	// <param name = "disposing"> True, if managed resources
    // should be deleted; otherwise False. </ param>

	
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

	// <summary>
    // Required method for designer support.
    // The content of the method must not be used with the code editor
    // to be changed.
    // </ summary>
	
    private void InitializeComponent()
    {
        this.SuspendLayout();
        // 
        // frmTemplate
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Name = "frmTemplate";
        this.StartPosition =
            System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Template";
        this.ResumeLayout(false);

    }

    public frmTemplate()
    {
        InitializeComponent();
    }

    #endregion

    [Start]
    public void Function()
    {
        frmTemplate frm = new frmTemplate();
        frm.ShowDialog();

        return;
    }
}

