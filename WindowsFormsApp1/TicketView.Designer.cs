using System.ComponentModel;

namespace WindowsFormsApp1;

partial class TicketView
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
    this.dataGridView1 = new System.Windows.Forms.DataGridView();
    this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.availableTickets = new System.Windows.Forms.DataGridViewTextBoxColumn();
    this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
    this.textBoxBuyer = new System.Windows.Forms.TextBox();
    this.textBoxSeats = new System.Windows.Forms.TextBox();
    this.buttonBuy = new System.Windows.Forms.Button();
    this.label1 = new System.Windows.Forms.Label();
    this.label2 = new System.Windows.Forms.Label();
    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
    this.SuspendLayout();

    // FORM
    this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
    this.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

    // dataGridView1
    this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        this.id, this.artist, this.date, this.location, this.availableTickets
    });
    this.dataGridView1.Location = new System.Drawing.Point(120, 90);
    this.dataGridView1.Name = "dataGridView1";
    this.dataGridView1.Size = new System.Drawing.Size(560, 280);
    this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
    this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
    this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
    this.dataGridView1.MultiSelect = false;
    this.dataGridView1.EnableHeadersVisualStyles = false;
    this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
    this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
    this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
    this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

    // columns
    this.id.HeaderText = "ID";
    this.artist.HeaderText = "Artist";
    this.date.HeaderText = "Date";
    this.location.HeaderText = "Location";
    this.availableTickets.HeaderText = "Available Tickets";

    // dateTimePicker1
    this.dateTimePicker1.Location = new System.Drawing.Point(240, 40);
    this.dateTimePicker1.Size = new System.Drawing.Size(320, 23);
    this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);

    // label1 - Buyer
    this.label1.Location = new System.Drawing.Point(135, 380);
    this.label1.Size = new System.Drawing.Size(80, 20);
    this.label1.Text = "Buyer";
    this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

    // textBoxBuyer
    this.textBoxBuyer.Location = new System.Drawing.Point(135, 400);
    this.textBoxBuyer.Size = new System.Drawing.Size(150, 23);
    this.textBoxBuyer.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.textBoxBuyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    // label2 - Seats
    this.label2.Location = new System.Drawing.Point(330, 380);
    this.label2.Size = new System.Drawing.Size(80, 20);
    this.label2.Text = "Seats";
    this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

    // textBoxSeats
    this.textBoxSeats.Location = new System.Drawing.Point(330, 400);
    this.textBoxSeats.Size = new System.Drawing.Size(100, 23);
    this.textBoxSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
    this.textBoxSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

    // buttonBuy
    this.buttonBuy.Location = new System.Drawing.Point(500, 398);
    this.buttonBuy.Size = new System.Drawing.Size(140, 30);
    this.buttonBuy.Text = "Buy Ticket";
    this.buttonBuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
    this.buttonBuy.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
    this.buttonBuy.ForeColor = System.Drawing.Color.White;
    this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
    this.buttonBuy.FlatAppearance.BorderSize = 0;
    this.buttonBuy.Cursor = System.Windows.Forms.Cursors.Hand;
    this.buttonBuy.Click += new System.EventHandler(this.button1_Click);

    // TicketView
    this.ClientSize = new System.Drawing.Size(800, 450);
    this.Controls.Add(this.label2);
    this.Controls.Add(this.label1);
    this.Controls.Add(this.buttonBuy);
    this.Controls.Add(this.textBoxSeats);
    this.Controls.Add(this.textBoxBuyer);
    this.Controls.Add(this.dateTimePicker1);
    this.Controls.Add(this.dataGridView1);
    this.Name = "TicketView";
    this.Text = "Ticket Sales";
    this.Load += new System.EventHandler(this.TicketView_Load);

    ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
}




    private System.Windows.Forms.TextBox textBoxBuyer;
    private System.Windows.Forms.TextBox textBoxSeats;
    private System.Windows.Forms.Button buttonBuy;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn artist;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn location;
    private System.Windows.Forms.DataGridViewTextBoxColumn availableTickets;

    private System.Windows.Forms.DataGridView dataGridView1;

    #endregion
}