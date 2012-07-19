using System;
using System.IO;
using System.Windows.Forms;
using Eplan.EplApi.ApplicationFramework;
using Eplan.EplApi.Base;
using Eplan.EplApi.Scripting;

public class FrmProjektsuche : System.Windows.Forms.Form
{
    public string strProjects = string.Empty;

    #region Formular
    public FrmProjektsuche()
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

    ///
    /// Erforderliche Designervariable.
    ///
    private System.ComponentModel.IContainer components = null;

    ///
    /// Verwendete Ressourcen bereinigen.
    ///
    /// True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    ///
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    ///
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
        this.columnHeader1.Text = "Projektname";
        this.columnHeader1.Width = 76;
        // 
        // columnHeader2
        // 
        this.columnHeader2.Text = "Pfad";
        this.columnHeader2.Width = 89;
        // 
        // columnHeader3
        // 
        this.columnHeader3.Text = "Erweiterung";
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
        this.btnSearch.Text = "Suchen";
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
        this.lbl.Text = "Suchbegriff eingeben...";
        this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnCancel
        // 
        this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.btnCancel.Location = new System.Drawing.Point(555, 274);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(75, 23);
        this.btnCancel.TabIndex = 15;
        this.btnCancel.Text = "Abbrechen";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // FrmProjektsuche
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
        this.Name = "FrmProjektsuche";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Projektsuche";
        this.Load += new System.EventHandler(this.FrmProjektsuche_Load);
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
            "Projektsuche...",
            "SearchProjects",
            "Projekt(e) suchen und öffnen",
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
        FrmProjektsuche frm = new FrmProjektsuche();
        frm.StartPosition = FormStartPosition.CenterScreen;
        frm.ShowDialog();

        return;
    }

    private void FrmProjektsuche_Load(object sender, System.EventArgs e)
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
            "Projektdatei (*.el*)|*.el*|Alle Dateien anzeigen|*.*";
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

        lbl.Text = "Projekt '"
            + Path.GetFileNameWithoutExtension(FullProjectPath)
            + "' wird geöffnet...";

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

        lbl.Text = "Projekt(e) werden gesucht...";

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

        lbl.Text = "Projekte gefunden: "
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
