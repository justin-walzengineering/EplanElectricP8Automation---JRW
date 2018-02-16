using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Display a new window form and certain functions of the project information

// Run script in Eplan using [Utilities]>[Scripts]>[Run]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public partial class frmButton : System.Windows.Forms.Form
{
    private Button btnCancel;
    private Button btnOk;
    private CheckBox chkProjectcheck;
    private CheckBox chkReport;
    private CheckBox chkCheckall;
    private Label lblProject;
    private ProgressBar pbr;

    #region Vom Windows Form-Designer generierter Code

    // <summary>
    // Required designer variable.
    // </summary>
	
    private System.ComponentModel.IContainer components = null;

	// <summary>
    // Purge used resources.
    // </ summary>
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
    // Purge used resources.
    // </ summary>
    // <param name = "disposing"> True, if managed resources
    // should be deleted; otherwise False. </ param>
	
    private void InitializeComponent()
    {
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOk = new System.Windows.Forms.Button();
        this.chkProjectcheck = new System.Windows.Forms.CheckBox();
        this.chkReport = new System.Windows.Forms.CheckBox();
        this.chkCheckall = new System.Windows.Forms.CheckBox();
        this.lblProject = new System.Windows.Forms.Label();
        this.pbr = new System.Windows.Forms.ProgressBar();
        this.SuspendLayout();
        // 
        // btnCancel
        // 
        this.btnCancel.Location = new System.Drawing.Point(207, 240);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 5;
        this.btnCancel.Text = "Abort";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // btnOk
        // 
        this.btnOk.Location = new System.Drawing.Point(126, 240);
        this.btnOk.Name = "btnOk";
        this.btnOk.Size = new System.Drawing.Size(75, 23);
        this.btnOk.TabIndex = 4;
        this.btnOk.Text = "OK";
        this.btnOk.UseVisualStyleBackColor = true;
        this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
        // 
        // chkProjectcheck
        // 
        this.chkProjectcheck.AutoSize = true;
        this.chkProjectcheck.Checked = true;
        this.chkProjectcheck.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkProjectcheck.Location = new System.Drawing.Point(12, 25);
        this.chkProjectcheck.Name = "chkProjectcheck";
        this.chkProjectcheck.Size = new System.Drawing.Size(62, 17);
        this.chkProjectcheck.TabIndex = 1;
        this.chkProjectcheck.Text = "Test run";
        this.chkProjectcheck.UseVisualStyleBackColor = true;
        // 
        // chkReport
        // 
        this.chkReport.AutoSize = true;
        this.chkReport.Checked = true;
        this.chkReport.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkReport.Location = new System.Drawing.Point(12, 48);
        this.chkReport.Name = "chkReport";
        this.chkReport.Size = new System.Drawing.Size(129, 17);
        this.chkReport.TabIndex = 2;
        this.chkReport.Text = "Generate evaluation";
        this.chkReport.UseVisualStyleBackColor = true;
        // 
        // chkCheckall
        // 
        this.chkCheckall.AutoSize = true;
        this.chkCheckall.Checked = true;
        this.chkCheckall.CheckState = System.Windows.Forms.CheckState.Checked;
        this.chkCheckall.Location = new System.Drawing.Point(12, 244);
        this.chkCheckall.Name = "chkCheckall";
        this.chkCheckall.Size = new System.Drawing.Size(92, 17);
        this.chkCheckall.TabIndex = 3;
        this.chkCheckall.Text = "Activate all";
        this.chkCheckall.UseVisualStyleBackColor = true;
        this.chkCheckall.CheckedChanged += new System.EventHandler(this.chbCheckall_CheckedChanged);
        // 
        // lblProject
        // 
        this.lblProject.AutoSize = true;
        this.lblProject.Location = new System.Drawing.Point(9, 9);
        this.lblProject.Name = "lblProject";
        this.lblProject.Size = new System.Drawing.Size(66, 13);
        this.lblProject.TabIndex = 5;
        this.lblProject.Text = "Project Name";
        // 
        // pbr
        // 
        this.pbr.Location = new System.Drawing.Point(12, 224);
        this.pbr.Name = "pbr";
        this.pbr.Size = new System.Drawing.Size(270, 10);
        this.pbr.TabIndex = 6;
        // 
        // frmButton
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(292, 273);
        this.Controls.Add(this.pbr);
        this.Controls.Add(this.lblProject);
        this.Controls.Add(this.chkCheckall);
        this.Controls.Add(this.chkReport);
        this.Controls.Add(this.chkProjectcheck);
        this.Controls.Add(this.btnOk);
        this.Controls.Add(this.btnCancel);
        this.Name = "frmButton";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Form example";
        this.Load += new System.EventHandler(this.frmButton_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    public frmButton()
    {
        InitializeComponent();
    }

    #endregion

    [Start]
    public void Function()
    {
        frmButton frm = new frmButton();
        frm.ShowDialog();

        return;
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        this.Close();

        return;
    }

    private void btnOk_Click(object sender, System.EventArgs e)
    {
        Cursor = Cursors.WaitCursor;
        
        CommandLineInterpreter oCLI = new CommandLineInterpreter();

        pbr.PerformStep();
        if (chkProjectcheck.Checked)
        {
            oCLI.Execute("AutomatedProjectCheck");
        }

        pbr.PerformStep();
        if (chkReport.Checked)
        {
            oCLI.Execute("reports");
        }
        pbr.PerformStep();
        pbr.Value = 0;

        Cursor = Cursors.Default;

        this.Close();

        return;
    }

    private void chbCheckall_CheckedChanged(
        object sender,
        System.EventArgs e
        )
    {
        if (chkCheckall.Checked)
        {
            chkProjectcheck.Checked = true;
            chkReport.Checked = true;
        }
        else
        {
            chkProjectcheck.Checked = false;
            chkReport.Checked = false;
        }

        return;
    }

    private void frmButton_Load(object sender, System.EventArgs e)
    {
        lblProject.Text = PathMap.SubstitutePath("$(PROJECTNAME)");
    }
}

