
namespace Diccionario_datos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbcMenu = new System.Windows.Forms.TabControl();
            this.tbpNumTriggers = new System.Windows.Forms.TabPage();
            this.chtVisorNumTipoTriggers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConsultarTipoTrigger = new System.Windows.Forms.Button();
            this.tbpInfoTriggers = new System.Windows.Forms.TabPage();
            this.dgvInfoTriggers = new System.Windows.Forms.DataGridView();
            this.btnInfoTriggers = new System.Windows.Forms.Button();
            this.lbInfoTriggers = new System.Windows.Forms.Label();
            this.tbpNulos = new System.Windows.Forms.TabPage();
            this.lbTituloNumColumnas = new System.Windows.Forms.Label();
            this.txtNomTable = new System.Windows.Forms.TextBox();
            this.btnNumColNull = new System.Windows.Forms.Button();
            this.lbNomTable = new System.Windows.Forms.Label();
            this.chtVisorNumColNull = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbcMenu.SuspendLayout();
            this.tbpNumTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVisorNumTipoTriggers)).BeginInit();
            this.tbpInfoTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTriggers)).BeginInit();
            this.tbpNulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVisorNumColNull)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMenu
            // 
            this.tbcMenu.Controls.Add(this.tbpNumTriggers);
            this.tbcMenu.Controls.Add(this.tbpInfoTriggers);
            this.tbcMenu.Controls.Add(this.tbpNulos);
            this.tbcMenu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMenu.Location = new System.Drawing.Point(2, 4);
            this.tbcMenu.Name = "tbcMenu";
            this.tbcMenu.SelectedIndex = 0;
            this.tbcMenu.Size = new System.Drawing.Size(704, 461);
            this.tbcMenu.TabIndex = 0;
            // 
            // tbpNumTriggers
            // 
            this.tbpNumTriggers.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpNumTriggers.Controls.Add(this.chtVisorNumTipoTriggers);
            this.tbpNumTriggers.Controls.Add(this.btnConsultarTipoTrigger);
            this.tbpNumTriggers.Location = new System.Drawing.Point(4, 27);
            this.tbpNumTriggers.Name = "tbpNumTriggers";
            this.tbpNumTriggers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNumTriggers.Size = new System.Drawing.Size(696, 430);
            this.tbpNumTriggers.TabIndex = 0;
            this.tbpNumTriggers.Text = "Número de Triggers";
            // 
            // chtVisorNumTipoTriggers
            // 
            this.chtVisorNumTipoTriggers.BackColor = System.Drawing.Color.SkyBlue;
            this.chtVisorNumTipoTriggers.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chtVisorNumTipoTriggers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtVisorNumTipoTriggers.Legends.Add(legend1);
            this.chtVisorNumTipoTriggers.Location = new System.Drawing.Point(114, 121);
            this.chtVisorNumTipoTriggers.Name = "chtVisorNumTipoTriggers";
            this.chtVisorNumTipoTriggers.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.SkyBlue;
            series1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            series1.ShadowColor = System.Drawing.Color.SkyBlue;
            this.chtVisorNumTipoTriggers.Series.Add(series1);
            this.chtVisorNumTipoTriggers.Size = new System.Drawing.Size(522, 280);
            this.chtVisorNumTipoTriggers.TabIndex = 3;
            this.chtVisorNumTipoTriggers.Text = "chart2";
            // 
            // btnConsultarTipoTrigger
            // 
            this.btnConsultarTipoTrigger.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConsultarTipoTrigger.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTipoTrigger.Location = new System.Drawing.Point(44, 58);
            this.btnConsultarTipoTrigger.Name = "btnConsultarTipoTrigger";
            this.btnConsultarTipoTrigger.Size = new System.Drawing.Size(243, 57);
            this.btnConsultarTipoTrigger.TabIndex = 0;
            this.btnConsultarTipoTrigger.Text = "Consultar Tipos de Trigger";
            this.btnConsultarTipoTrigger.UseVisualStyleBackColor = false;
            this.btnConsultarTipoTrigger.Click += new System.EventHandler(this.btnConsultarTipoTrigger_Click);
            // 
            // tbpInfoTriggers
            // 
            this.tbpInfoTriggers.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpInfoTriggers.Controls.Add(this.dgvInfoTriggers);
            this.tbpInfoTriggers.Controls.Add(this.btnInfoTriggers);
            this.tbpInfoTriggers.Controls.Add(this.lbInfoTriggers);
            this.tbpInfoTriggers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpInfoTriggers.Location = new System.Drawing.Point(4, 27);
            this.tbpInfoTriggers.Name = "tbpInfoTriggers";
            this.tbpInfoTriggers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInfoTriggers.Size = new System.Drawing.Size(696, 430);
            this.tbpInfoTriggers.TabIndex = 1;
            this.tbpInfoTriggers.Text = "Información Triggers";
            // 
            // dgvInfoTriggers
            // 
            this.dgvInfoTriggers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInfoTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoTriggers.Location = new System.Drawing.Point(62, 169);
            this.dgvInfoTriggers.Name = "dgvInfoTriggers";
            this.dgvInfoTriggers.Size = new System.Drawing.Size(566, 230);
            this.dgvInfoTriggers.TabIndex = 5;
            // 
            // btnInfoTriggers
            // 
            this.btnInfoTriggers.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInfoTriggers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoTriggers.Location = new System.Drawing.Point(210, 92);
            this.btnInfoTriggers.Name = "btnInfoTriggers";
            this.btnInfoTriggers.Size = new System.Drawing.Size(279, 54);
            this.btnInfoTriggers.TabIndex = 4;
            this.btnInfoTriggers.Text = "Consultar Información Triggers";
            this.btnInfoTriggers.UseVisualStyleBackColor = false;
            this.btnInfoTriggers.Click += new System.EventHandler(this.btnInfoTriggers_Click);
            // 
            // lbInfoTriggers
            // 
            this.lbInfoTriggers.AutoSize = true;
            this.lbInfoTriggers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfoTriggers.Location = new System.Drawing.Point(109, 54);
            this.lbInfoTriggers.Name = "lbInfoTriggers";
            this.lbInfoTriggers.Size = new System.Drawing.Size(474, 18);
            this.lbInfoTriggers.TabIndex = 3;
            this.lbInfoTriggers.Text = "Presione el botón para visualizar la informacion de los triggers:";
            // 
            // tbpNulos
            // 
            this.tbpNulos.BackColor = System.Drawing.Color.SkyBlue;
            this.tbpNulos.Controls.Add(this.lbTituloNumColumnas);
            this.tbpNulos.Controls.Add(this.txtNomTable);
            this.tbpNulos.Controls.Add(this.btnNumColNull);
            this.tbpNulos.Controls.Add(this.lbNomTable);
            this.tbpNulos.Controls.Add(this.chtVisorNumColNull);
            this.tbpNulos.Location = new System.Drawing.Point(4, 27);
            this.tbpNulos.Name = "tbpNulos";
            this.tbpNulos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNulos.Size = new System.Drawing.Size(696, 430);
            this.tbpNulos.TabIndex = 2;
            this.tbpNulos.Text = "Número de columnas nulas";
            // 
            // lbTituloNumColumnas
            // 
            this.lbTituloNumColumnas.AutoSize = true;
            this.lbTituloNumColumnas.Location = new System.Drawing.Point(204, 29);
            this.lbTituloNumColumnas.Name = "lbTituloNumColumnas";
            this.lbTituloNumColumnas.Size = new System.Drawing.Size(0, 18);
            this.lbTituloNumColumnas.TabIndex = 8;
            // 
            // txtNomTable
            // 
            this.txtNomTable.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomTable.Location = new System.Drawing.Point(340, 56);
            this.txtNomTable.Name = "txtNomTable";
            this.txtNomTable.Size = new System.Drawing.Size(219, 26);
            this.txtNomTable.TabIndex = 7;
            // 
            // btnNumColNull
            // 
            this.btnNumColNull.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNumColNull.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumColNull.Location = new System.Drawing.Point(182, 100);
            this.btnNumColNull.Name = "btnNumColNull";
            this.btnNumColNull.Size = new System.Drawing.Size(330, 58);
            this.btnNumColNull.TabIndex = 6;
            this.btnNumColNull.Text = "Consultar columnas nulas y no nulas";
            this.btnNumColNull.UseVisualStyleBackColor = false;
            this.btnNumColNull.Click += new System.EventHandler(this.btnNumColNull_Click);
            // 
            // lbNomTable
            // 
            this.lbNomTable.AutoSize = true;
            this.lbNomTable.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomTable.Location = new System.Drawing.Point(79, 59);
            this.lbNomTable.Name = "lbNomTable";
            this.lbNomTable.Size = new System.Drawing.Size(236, 18);
            this.lbNomTable.TabIndex = 5;
            this.lbNomTable.Text = " Ingrese el nombre de la tabla:";
            // 
            // chtVisorNumColNull
            // 
            chartArea2.Name = "ChartArea1";
            this.chtVisorNumColNull.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtVisorNumColNull.Legends.Add(legend2);
            this.chtVisorNumColNull.Location = new System.Drawing.Point(127, 181);
            this.chtVisorNumColNull.Name = "chtVisorNumColNull";
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.SteelBlue;
            series2.Legend = "Legend1";
            series2.LegendText = "Columnas que aceptan o no aceptan nulos";
            series2.Name = "Series1";
            this.chtVisorNumColNull.Series.Add(series2);
            this.chtVisorNumColNull.Size = new System.Drawing.Size(490, 233);
            this.chtVisorNumColNull.TabIndex = 3;
            this.chtVisorNumColNull.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 468);
            this.Controls.Add(this.tbcMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbcMenu.ResumeLayout(false);
            this.tbpNumTriggers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtVisorNumTipoTriggers)).EndInit();
            this.tbpInfoTriggers.ResumeLayout(false);
            this.tbpInfoTriggers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoTriggers)).EndInit();
            this.tbpNulos.ResumeLayout(false);
            this.tbpNulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtVisorNumColNull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMenu;
        private System.Windows.Forms.TabPage tbpNumTriggers;
        private System.Windows.Forms.TabPage tbpInfoTriggers;
        private System.Windows.Forms.Button btnConsultarTipoTrigger;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVisorNumTipoTriggers;
        private System.Windows.Forms.Button btnInfoTriggers;
        private System.Windows.Forms.Label lbInfoTriggers;
        private System.Windows.Forms.TabPage tbpNulos;
        private System.Windows.Forms.Button btnNumColNull;
        private System.Windows.Forms.Label lbNomTable;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtVisorNumColNull;
        private System.Windows.Forms.Label lbTituloNumColumnas;
        private System.Windows.Forms.TextBox txtNomTable;
        private System.Windows.Forms.DataGridView dgvInfoTriggers;
    }
}

