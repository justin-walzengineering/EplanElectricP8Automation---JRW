using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

// Goal:
// Create a new menu item and allow user to run an action from menu item
// I cannot find the location of this menu creation

// Load script in Eplan using [Utilities]>[Scripts]>[Load]
// Then choose the file from the file location. 
// The file will be a .cs extension.

public class FrmProjectsearch : System.Windows.Forms.Form
{
    public string strProjects = string.Empty;

    #region Form
    public FrmProjectsearch()
    {
        InitializeComponent();
    }

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnOpenProject;
    private System.Windows.Forms.ListView liviResult;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.StatusStrip st;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.ToolStripStatusLabel lbl;

    //
    // Required designer variable.
    //
	
    private System.ComponentModel.IContainer components = null;

    //
	// Purge used resources.
    //
    // true if you want to delete managed resources; otherwise False.
	
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    //
	// Required method for designer support.
    // The content of the method must not be changed with the code editor.
    //
	
    private void InitializeComponent()
    {
        this.btnOK = new System.Windows.Forms.Button();
        this.btnOpenProject = new System.Windows.Forms.Button();
        this.liviResult = new System.Windows.Forms.ListView();
        this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
        this.btnSearch = new System.Windows.Forms.Button();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.st = new System.Windows.Forms.StatusStrip();
        this.lbl = new System.Windows.Forms.ToolStripStatusLabel();
        this.btnCancel = new System.Windows.Forms.Button();
        this.st.SuspendLayout();
        this.SuspendLayout();
        // 
        // btnOK
        // 
        this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOK.Location = new System.Drawing.Point(474, 274);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(75, 23);
        this.btnOK.TabIndex = 6;
        this.btnOK.Text = "OK";
        this.btnOK.UseVisualStyleBackColor = true;
        this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
        // 
        // btnOpenProject
        // 
        this.btnOpenProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnOpenProject.Location = new System.Drawing.Point(606, 9);
        this.btnOpenProject.Name = "btnOpenProject";
        this.btnOpenProject.Size = new System.Drawing.Size(24, 23);
        this.btnOpenProject.TabIndex = 11;
        this.btnOpenProject.Text = "...";
        this.btnOpenProject.UseVisualStyleBackColor = true;
        this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
        // 
        // liviResult
        // 
        this.liviResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.liviResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
        this.liviResult.FullRowSelect = true;
        this.liviResult.GridLines = true;
        this.liviResult.HideSelection = false;
        this.liviResult.Location = new System.Drawing.Point(12, 39);
        this.liviResult.Name = "liviResult";
        this.liviResult.Size = new System.Drawing.Size(618, 229);
        this.liviResult.Sorting = System.Windows.Forms.SortOrder.Ascending;
        this.liviResult.TabIndex = 10;
        this.liviResult.UseCompatibleStateImageBehavior = false;
        this.liviResult.View = System.Windows.Forms.View.Details;
        this.liviResult.DoubleClick += new System.EventHandler(this.liviResult_DoubleClick);
        // 
        // columnHeader1
        // 
        this.columnHeader1.Text = "Project Name";
        this.columnHeader1.Width = 76;
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "Path";
        this.columnHeader2.Width = 89;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "Extension";
        this.columnHeader3.Width = 223;
        // 
        // btnSearch
        // 
        this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.btnSearch.Enabled = false;
        this.btnSearch.Location = new System.Drawing.Point(525, 9);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(75, 23);
        this.btnSearch.TabIndex = 9;
        this.btnSearch.Text = "Search";
        this.btnSearch.UseVisualStyleBackColor = true;
        this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
        // 
        // txtSearch
        // 
        this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
        this.txtSearch.Location = new System.Drawing.Point(12, 11);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(507, 20);
        this.txtSearch.TabIndex = 8;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // st
        // 
        this.st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl});
        this.st.Location = new System.Drawing.Point(0, 301);
        this.st.Name = "st";
        this.st.Size = new System.Drawing.Size(642, 22);
        this.st.TabIndex = 13;
        this.st.Text = "statusStrip1";
        // 
        // lbl
        // 
        this.lbl.Name = "lbl";
        this.lbl.Size = new System.Drawing.Size(627, 17);
        this.lbl.Spring = true;
        this.lbl.Text = "Enter a search term...";
        this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCancel.Location = new System.Drawing.Point(555, 274);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 15;
        this.btnCancel.Text = "Abort";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // FrmProjectsearch
        // 
        this.AcceptButton = this.btnSearch;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(642, 323);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.st);
        this.Controls.Add(this.btnOpenProject);
        this.Controls.Add(this.liviResult);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.btnOK);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.MinimumSize = new System.Drawing.Size(450, 200);
        this.Name = "FrmProjectsearch";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Project search";
        this.Load += new System.EventHandler(this.FrmProjectsearch_Load);
        this.st.ResumeLayout(false);
        this.st.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    [DeclareMenu]
    public void MenuFunction()
    {
        Eplan.EplApi.Gui.Menu oMenu = new Eplan.EplApi.Gui.Menu();
        oMenu.AddMenuItem
            (
            "Project search...",
            "SearchProjects",
            "Search and open project (s)",
            35002,
            1,
            false,
            false
            );

        return;
    }

    [DeclareAction("SearchProjects")]
    public void SearchMacrosVoid()
    {
        FrmProjectsearch frm = new FrmProjectsearch();
        frm.StartPosition = FormStartPosition.CenterScreen;
        frm.ShowDialog();

        return;
    }

    private void FrmProjectsearch_Load(object sender, System.EventArgs e)
    {
        strProjects = PathMap.SubstitutePath("$(MD_PROJECTS)");
        txtSearch.Select();

        return;
    }

    private void btnCancel_Click(object sender, System.EventArgs e)
    {
        Close();

        return;
    }

    private void btnOpenProject_Click(object sender, System.EventArgs e)
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ofd.Filter =
            "Project file (* .el *) | * .el * | show all files | *. *";
        ofd.InitialDirectory = strProjects;

        if (ofd.ShowDialog() == DialogResult.OK)
        {
            Eplan_OpenProject(ofd.FileName);
            this.Close();
        }

        return;
    }

    private void Eplan_OpenProject(string FullProjectPath)
    {
        Cursor.Current = Cursors.WaitCursor;

        lbl.Text = "Project '"
            + Path.GetFileNameWithoutExtension(FullProjectPath)
            + "' will be opened...";

        this.Update();

        CommandLineInterpreter oCli = new CommandLineInterpreter();
        ActionCallingContext acc = new ActionCallingContext();
        acc.AddParameter("Project", FullProjectPath);
        oCli.Execute("ProjectOpen", acc);

        Cursor.Current = Cursors.Default;

        return;
    }

    private void btnSearch_Click(object sender, System.EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;

        lbl.Text = "Project (s) are searched...";

        liviResult.BeginUpdate();

        GetProjects();

        liviResult.AutoResizeColumns(
            ColumnHeaderAutoResizeStyle.ColumnContent);

        liviResult.EndUpdate();

        Cursor.Current = Cursors.Default;

        return;
    }

    private void GetProjects()
    {
        liviResult.Items.Clear();

        string[] result = Directory.GetFiles(
            strProjects,
            "*" + txtSearch.Text + "*.el*",
            SearchOption.TopDirectoryOnly
            );

        foreach (string project in result)
        {
            FillListView(project);
        }

        lbl.Text = "Projects found: "
            + liviResult.Items.Count.ToString();

        return;
    }

    private void FillListView(string Fullpath)
    {
        FileInfo fi = new FileInfo(Fullpath);

        string FileNameWithoutExtension =
            Path.GetFileNameWithoutExtension(fi.FullName);
        string Directory = fi.Directory.ToString() + @"\";
        string Extension = fi.Extension.ToString();

        ListViewItem liviItem = new ListViewItem();
        liviItem.Text = FileNameWithoutExtension;
        liviItem.SubItems.Add(Directory);
        liviItem.SubItems.Add(Extension);
        liviResult.Items.Add(liviItem);

        return;
    }

    private void btnOK_Click(object sender, System.EventArgs e)
    {
        GetFileNameAndOpen();

        return;
    }

    private void liviResult_DoubleClick(object sender, EventArgs e)        
    {
        GetFileNameAndOpen();

        return;
    }

    private void GetFileNameAndOpen()
    {
        if (liviResult.SelectedItems.Count > 0)
        {
            string project = liviResult.SelectedItems[0].SubItems[1].Text
                + liviResult.SelectedItems[0].SubItems[0].Text
                + liviResult.SelectedItems[0].SubItems[2].Text;

            Eplan_OpenProject(project);
        }

        this.Close();

        return;
    }

    private void txtSearch_TextChanged(object sender, System.EventArgs e)
    {
        if (txtSearch.Text == "")
        {
            btnSearch.Enabled = false;
        }
        else
        {
            btnSearch.Enabled = true;
        }

        return;
    }

}
