﻿// Decompiled with JetBrains decompiler
// Type: GaitoBotEditor.Startseite
// Assembly: GaitoBotEditor, Version=2.10.0.42867, Culture=neutral, PublicKeyToken=null
// MVID: EBD14C24-1519-4F8B-BE7E-6E5D551BEF56
// Assembly location: C:\Users\Administrator\AppData\Local\Apps\2.0\AMK4CRNH.1P0\83OD2GAZ.QLB\gait..tion_0000000000000000_0002.000a_0f204e9a356efc4e\GaitoBotEditor.exe

using GaitoBotEditor.Properties;
using GaitoBotEditor.startseite;
using GaitoBotEditorCore;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GaitoBotEditor
{
  public class Startseite : UserControl
  {
    private IContainer components = (IContainer) null;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private TableLayoutPanel tableLayoutPanel3;
    private ErsteSchritte ersteSchritte1;
    private Arbeitsbereiche arbeitsbereiche1;
    private TableLayoutPanel tableLayoutPanel4;
    private Feedback feedback1;
    private AktuelleNachrichten aktuelleNachrichten1;

    public ArbeitsbereichVerwaltung ArbeitsbereichVerwaltung
    {
      set
      {
        this.arbeitsbereiche1.ArbeitsbereichVerwaltung = value;
      }
    }

    public Startseite()
    {
      this.InitializeComponent();
      this.Load += new EventHandler(this.Startseite_Load);
    }

    private void Startseite_Load(object sender, EventArgs e)
    {
      this.SteuerElementeBeschriften();
      this.aktuelleNachrichten1.Visible = false;
      if (!Config.GlobalConfig.ErsteSchritteLaden)
        return;
      this.ersteSchritte1.Anzeigen();
    }

    private void SteuerElementeBeschriften()
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Startseite));
      this.tableLayoutPanel1 = new TableLayoutPanel();
      this.tableLayoutPanel2 = new TableLayoutPanel();
      this.arbeitsbereiche1 = new Arbeitsbereiche();
      this.tableLayoutPanel4 = new TableLayoutPanel();
      this.feedback1 = new Feedback();
      this.aktuelleNachrichten1 = new AktuelleNachrichten();
      this.tableLayoutPanel3 = new TableLayoutPanel();
      this.ersteSchritte1 = new ErsteSchritte();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.SuspendLayout();
      this.tableLayoutPanel1.BackColor = Color.FromArgb(79, 199, 252);
      this.tableLayoutPanel1.BackgroundImage = (Image) Resources.startseite2;
      componentResourceManager.ApplyResources((object) this.tableLayoutPanel1, "tableLayoutPanel1");
      this.tableLayoutPanel1.Controls.Add((Control) this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add((Control) this.tableLayoutPanel3, 0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      componentResourceManager.ApplyResources((object) this.tableLayoutPanel2, "tableLayoutPanel2");
      this.tableLayoutPanel2.Controls.Add((Control) this.arbeitsbereiche1, 0, 0);
      this.tableLayoutPanel2.Controls.Add((Control) this.tableLayoutPanel4, 1, 0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      componentResourceManager.ApplyResources((object) this.arbeitsbereiche1, "arbeitsbereiche1");
      this.arbeitsbereiche1.BackColor = Color.LightSteelBlue;
      this.arbeitsbereiche1.Name = "arbeitsbereiche1";
      componentResourceManager.ApplyResources((object) this.tableLayoutPanel4, "tableLayoutPanel4");
      this.tableLayoutPanel4.Controls.Add((Control) this.feedback1, 0, 0);
      this.tableLayoutPanel4.Controls.Add((Control) this.aktuelleNachrichten1, 0, 1);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.feedback1.BackColor = Color.LightSteelBlue;
      componentResourceManager.ApplyResources((object) this.feedback1, "feedback1");
      this.feedback1.Name = "feedback1";
      componentResourceManager.ApplyResources((object) this.aktuelleNachrichten1, "aktuelleNachrichten1");
      this.aktuelleNachrichten1.BackColor = Color.LightSteelBlue;
      this.aktuelleNachrichten1.Name = "aktuelleNachrichten1";
      this.tableLayoutPanel3.BackColor = Color.Transparent;
      componentResourceManager.ApplyResources((object) this.tableLayoutPanel3, "tableLayoutPanel3");
      this.tableLayoutPanel3.Controls.Add((Control) this.ersteSchritte1, 1, 0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.ersteSchritte1.BackColor = Color.LightSteelBlue;
      componentResourceManager.ApplyResources((object) this.ersteSchritte1, "ersteSchritte1");
      this.ersteSchritte1.Name = "ersteSchritte1";
      componentResourceManager.ApplyResources((object) this, "$this");
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(15, 132, 212);
      this.Controls.Add((Control) this.tableLayoutPanel1);
      this.Name = nameof (Startseite);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.ResumeLayout(false);
    }
  }
}
