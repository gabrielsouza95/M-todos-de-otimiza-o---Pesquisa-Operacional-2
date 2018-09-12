namespace PO2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.valor_M0 = new System.Windows.Forms.TextBox();
            this.valorVars = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.valor_err = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_delta = new System.Windows.Forms.TextBox();
            this.valor_b = new System.Windows.Forms.TextBox();
            this.valor_a = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.funcao = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.calcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.metodoBisseccao = new System.Windows.Forms.RadioButton();
            this.metodoNewtonSemRest = new System.Windows.Forms.RadioButton();
            this.metodoCoorCiclic = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buscaFibo = new System.Windows.Forms.RadioButton();
            this.metodoNewton = new System.Windows.Forms.RadioButton();
            this.metodoAurea = new System.Windows.Forms.RadioButton();
            this.buscaDicotomica = new System.Windows.Forms.RadioButton();
            this.buscaUniforme = new System.Windows.Forms.RadioButton();
            this.resultados = new System.Windows.Forms.GroupBox();
            this.iteracoes = new System.Windows.Forms.DataGridView();
            this.K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultado_deriv = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ex_delta = new System.Windows.Forms.Label();
            this.ex_b = new System.Windows.Forms.Label();
            this.ex_a = new System.Windows.Forms.Label();
            this.ex_err = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.exemplos = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.metodoSemDeriv = new System.Windows.Forms.TabPage();
            this.metodoComDeriv = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.iteracoes_deriv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.metodoSemRestSemDeriv = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.metodoSemRestComDeriv = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorVars)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.resultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracoes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.metodoSemDeriv.SuspendLayout();
            this.metodoComDeriv.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracoes_deriv)).BeginInit();
            this.metodoSemRestSemDeriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.valor_M0);
            this.groupBox1.Controls.Add(this.valorVars);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.valor_err);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.valor_delta);
            this.groupBox1.Controls.Add(this.valor_b);
            this.groupBox1.Controls.Add(this.valor_a);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.funcao);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "M0:";
            // 
            // valor_M0
            // 
            this.valor_M0.Enabled = false;
            this.valor_M0.Location = new System.Drawing.Point(144, 66);
            this.valor_M0.Name = "valor_M0";
            this.valor_M0.Size = new System.Drawing.Size(64, 20);
            this.valor_M0.TabIndex = 15;
            // 
            // valorVars
            // 
            this.valorVars.Enabled = false;
            this.valorVars.Location = new System.Drawing.Point(298, 67);
            this.valorVars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.valorVars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valorVars.Name = "valorVars";
            this.valorVars.ReadOnly = true;
            this.valorVars.Size = new System.Drawing.Size(63, 20);
            this.valorVars.TabIndex = 14;
            this.valorVars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "qtd de variáveis:";
            // 
            // valor_err
            // 
            this.valor_err.Enabled = false;
            this.valor_err.Location = new System.Drawing.Point(52, 66);
            this.valor_err.Name = "valor_err";
            this.valor_err.Size = new System.Drawing.Size(64, 20);
            this.valor_err.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Δ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ε:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "b:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "a:";
            // 
            // valor_delta
            // 
            this.valor_delta.Location = new System.Drawing.Point(237, 40);
            this.valor_delta.Name = "valor_delta";
            this.valor_delta.Size = new System.Drawing.Size(64, 20);
            this.valor_delta.TabIndex = 6;
            // 
            // valor_b
            // 
            this.valor_b.Location = new System.Drawing.Point(144, 40);
            this.valor_b.Name = "valor_b";
            this.valor_b.Size = new System.Drawing.Size(64, 20);
            this.valor_b.TabIndex = 5;
            // 
            // valor_a
            // 
            this.valor_a.Location = new System.Drawing.Point(52, 40);
            this.valor_a.Name = "valor_a";
            this.valor_a.Size = new System.Drawing.Size(64, 20);
            this.valor_a.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Função:";
            // 
            // funcao
            // 
            this.funcao.Location = new System.Drawing.Point(52, 13);
            this.funcao.Name = "funcao";
            this.funcao.Size = new System.Drawing.Size(309, 20);
            this.funcao.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.calcular);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(385, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 364);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // calcular
            // 
            this.calcular.Cursor = System.Windows.Forms.Cursors.Default;
            this.calcular.Location = new System.Drawing.Point(6, 338);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(159, 23);
            this.calcular.TabIndex = 1;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.metodoBisseccao);
            this.groupBox2.Controls.Add(this.metodoNewtonSemRest);
            this.groupBox2.Controls.Add(this.metodoCoorCiclic);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.buscaFibo);
            this.groupBox2.Controls.Add(this.metodoNewton);
            this.groupBox2.Controls.Add(this.metodoAurea);
            this.groupBox2.Controls.Add(this.buscaDicotomica);
            this.groupBox2.Controls.Add(this.buscaUniforme);
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 328);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Métodos com restrições sem derivada: ";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(6, 194);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 30);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Métodos sem restrições sem derivada multivariável: ";
            // 
            // metodoBisseccao
            // 
            this.metodoBisseccao.AutoSize = true;
            this.metodoBisseccao.Location = new System.Drawing.Point(6, 171);
            this.metodoBisseccao.Name = "metodoBisseccao";
            this.metodoBisseccao.Size = new System.Drawing.Size(128, 17);
            this.metodoBisseccao.TabIndex = 8;
            this.metodoBisseccao.TabStop = true;
            this.metodoBisseccao.Text = "Método da Bissecção";
            this.metodoBisseccao.UseVisualStyleBackColor = true;
            this.metodoBisseccao.CheckedChanged += new System.EventHandler(this.metodoBisseccao_CheckedChanged);
            // 
            // metodoNewtonSemRest
            // 
            this.metodoNewtonSemRest.AutoSize = true;
            this.metodoNewtonSemRest.Location = new System.Drawing.Point(6, 305);
            this.metodoNewtonSemRest.Name = "metodoNewtonSemRest";
            this.metodoNewtonSemRest.Size = new System.Drawing.Size(116, 17);
            this.metodoNewtonSemRest.TabIndex = 7;
            this.metodoNewtonSemRest.TabStop = true;
            this.metodoNewtonSemRest.Text = "Método de Newton";
            this.metodoNewtonSemRest.UseVisualStyleBackColor = true;
            this.metodoNewtonSemRest.CheckedChanged += new System.EventHandler(this.metodoNewtonSemRest_CheckedChanged);
            // 
            // metodoCoorCiclic
            // 
            this.metodoCoorCiclic.AllowDrop = true;
            this.metodoCoorCiclic.AutoSize = true;
            this.metodoCoorCiclic.Location = new System.Drawing.Point(6, 230);
            this.metodoCoorCiclic.Name = "metodoCoorCiclic";
            this.metodoCoorCiclic.Size = new System.Drawing.Size(181, 17);
            this.metodoCoorCiclic.TabIndex = 6;
            this.metodoCoorCiclic.TabStop = true;
            this.metodoCoorCiclic.Text = "Método de coordenadas cíclicas";
            this.metodoCoorCiclic.UseVisualStyleBackColor = false;
            this.metodoCoorCiclic.CheckedChanged += new System.EventHandler(this.metodoCoorCiclic_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 116);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 30);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Métodos com restrições com derivada: ";
            // 
            // buscaFibo
            // 
            this.buscaFibo.AutoSize = true;
            this.buscaFibo.Location = new System.Drawing.Point(6, 92);
            this.buscaFibo.Name = "buscaFibo";
            this.buscaFibo.Size = new System.Drawing.Size(104, 17);
            this.buscaFibo.TabIndex = 3;
            this.buscaFibo.Text = "Busca Fibonacci";
            this.buscaFibo.UseVisualStyleBackColor = true;
            this.buscaFibo.CheckedChanged += new System.EventHandler(this.buscaFibo_CheckedChanged);
            // 
            // metodoNewton
            // 
            this.metodoNewton.AutoSize = true;
            this.metodoNewton.Location = new System.Drawing.Point(6, 148);
            this.metodoNewton.Name = "metodoNewton";
            this.metodoNewton.Size = new System.Drawing.Size(116, 17);
            this.metodoNewton.TabIndex = 4;
            this.metodoNewton.TabStop = true;
            this.metodoNewton.Text = "Método de Newton";
            this.metodoNewton.UseVisualStyleBackColor = true;
            this.metodoNewton.CheckedChanged += new System.EventHandler(this.metodoNewton_CheckedChanged);
            // 
            // metodoAurea
            // 
            this.metodoAurea.AutoSize = true;
            this.metodoAurea.Location = new System.Drawing.Point(6, 69);
            this.metodoAurea.Name = "metodoAurea";
            this.metodoAurea.Size = new System.Drawing.Size(141, 17);
            this.metodoAurea.TabIndex = 2;
            this.metodoAurea.Text = "Método da Seção Áurea";
            this.metodoAurea.UseVisualStyleBackColor = true;
            this.metodoAurea.CheckedChanged += new System.EventHandler(this.metodoAurea_CheckedChanged);
            // 
            // buscaDicotomica
            // 
            this.buscaDicotomica.AutoSize = true;
            this.buscaDicotomica.Location = new System.Drawing.Point(6, 46);
            this.buscaDicotomica.Name = "buscaDicotomica";
            this.buscaDicotomica.Size = new System.Drawing.Size(111, 17);
            this.buscaDicotomica.TabIndex = 1;
            this.buscaDicotomica.Text = "Busca Dicotômica";
            this.buscaDicotomica.UseVisualStyleBackColor = true;
            this.buscaDicotomica.CheckedChanged += new System.EventHandler(this.buscaDicotomica_CheckedChanged);
            // 
            // buscaUniforme
            // 
            this.buscaUniforme.AutoSize = true;
            this.buscaUniforme.Checked = true;
            this.buscaUniforme.Location = new System.Drawing.Point(6, 26);
            this.buscaUniforme.Name = "buscaUniforme";
            this.buscaUniforme.Size = new System.Drawing.Size(100, 17);
            this.buscaUniforme.TabIndex = 0;
            this.buscaUniforme.TabStop = true;
            this.buscaUniforme.Text = "Busca Uniforme";
            this.buscaUniforme.UseVisualStyleBackColor = true;
            this.buscaUniforme.CheckedChanged += new System.EventHandler(this.buscaUniforme_CheckedChanged);
            // 
            // resultados
            // 
            this.resultados.Controls.Add(this.iteracoes);
            this.resultados.Controls.Add(this.resultado_deriv);
            this.resultados.Controls.Add(this.label6);
            this.resultados.Location = new System.Drawing.Point(0, 0);
            this.resultados.Name = "resultados";
            this.resultados.Size = new System.Drawing.Size(580, 225);
            this.resultados.TabIndex = 2;
            this.resultados.TabStop = false;
            this.resultados.Text = "Resultados: ";
            this.resultados.Enter += new System.EventHandler(this.resultados_Enter);
            // 
            // iteracoes
            // 
            this.iteracoes.AllowUserToAddRows = false;
            this.iteracoes.AllowUserToDeleteRows = false;
            this.iteracoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iteracoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iteracoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.K,
            this.a,
            this.b,
            this.p,
            this.fp,
            this.q,
            this.fq,
            this.ba});
            this.iteracoes.Location = new System.Drawing.Point(9, 47);
            this.iteracoes.Name = "iteracoes";
            this.iteracoes.ReadOnly = true;
            this.iteracoes.RowTemplate.ReadOnly = true;
            this.iteracoes.ShowEditingIcon = false;
            this.iteracoes.Size = new System.Drawing.Size(568, 161);
            this.iteracoes.TabIndex = 2;
            // 
            // K
            // 
            this.K.HeaderText = "K";
            this.K.Name = "K";
            this.K.ReadOnly = true;
            // 
            // a
            // 
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.ReadOnly = true;
            // 
            // b
            // 
            this.b.HeaderText = "b";
            this.b.Name = "b";
            this.b.ReadOnly = true;
            // 
            // p
            // 
            this.p.HeaderText = "p";
            this.p.Name = "p";
            this.p.ReadOnly = true;
            // 
            // fp
            // 
            this.fp.HeaderText = "f(p)";
            this.fp.Name = "fp";
            this.fp.ReadOnly = true;
            // 
            // q
            // 
            this.q.HeaderText = "q";
            this.q.Name = "q";
            this.q.ReadOnly = true;
            // 
            // fq
            // 
            this.fq.HeaderText = "f(q)";
            this.fq.Name = "fq";
            this.fq.ReadOnly = true;
            // 
            // ba
            // 
            this.ba.HeaderText = "b-a";
            this.ba.Name = "ba";
            this.ba.ReadOnly = true;
            // 
            // resultado_deriv
            // 
            this.resultado_deriv.AutoSize = true;
            this.resultado_deriv.Location = new System.Drawing.Point(41, 20);
            this.resultado_deriv.Name = "resultado_deriv";
            this.resultado_deriv.Size = new System.Drawing.Size(0, 13);
            this.resultado_deriv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x* =";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ex_delta);
            this.groupBox3.Controls.Add(this.ex_b);
            this.groupBox3.Controls.Add(this.ex_a);
            this.groupBox3.Controls.Add(this.ex_err);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.exemplos);
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 106);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exemplos: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Função:";
            // 
            // ex_delta
            // 
            this.ex_delta.AutoSize = true;
            this.ex_delta.Location = new System.Drawing.Point(233, 48);
            this.ex_delta.Name = "ex_delta";
            this.ex_delta.Size = new System.Drawing.Size(0, 13);
            this.ex_delta.TabIndex = 9;
            // 
            // ex_b
            // 
            this.ex_b.AutoSize = true;
            this.ex_b.Location = new System.Drawing.Point(143, 48);
            this.ex_b.Name = "ex_b";
            this.ex_b.Size = new System.Drawing.Size(0, 13);
            this.ex_b.TabIndex = 8;
            // 
            // ex_a
            // 
            this.ex_a.AutoSize = true;
            this.ex_a.Location = new System.Drawing.Point(60, 48);
            this.ex_a.Name = "ex_a";
            this.ex_a.Size = new System.Drawing.Size(0, 13);
            this.ex_a.TabIndex = 7;
            // 
            // ex_err
            // 
            this.ex_err.AutoSize = true;
            this.ex_err.Location = new System.Drawing.Point(60, 70);
            this.ex_err.Name = "ex_err";
            this.ex_err.Size = new System.Drawing.Size(0, 13);
            this.ex_err.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(213, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Δ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "b:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "ε:";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(255, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Carregar exemplo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "a:";
            // 
            // exemplos
            // 
            this.exemplos.FormattingEnabled = true;
            this.exemplos.Items.AddRange(new object[] {
            "x*x-3*x+2",
            "x*x+2*x",
            "x*x-3*x+2",
            "x*x*x*x+2*(x*x*x)-1",
            "x*x+2*x"});
            this.exemplos.Location = new System.Drawing.Point(51, 20);
            this.exemplos.Name = "exemplos";
            this.exemplos.Size = new System.Drawing.Size(309, 21);
            this.exemplos.TabIndex = 1;
            this.exemplos.SelectedIndexChanged += new System.EventHandler(this.exemplos_SelectedIndexChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.metodoSemDeriv);
            this.tabControl1.Controls.Add(this.metodoComDeriv);
            this.tabControl1.Controls.Add(this.metodoSemRestSemDeriv);
            this.tabControl1.Controls.Add(this.metodoSemRestComDeriv);
            this.tabControl1.Location = new System.Drawing.Point(12, 383);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 271);
            this.tabControl1.TabIndex = 0;
            // 
            // metodoSemDeriv
            // 
            this.metodoSemDeriv.Controls.Add(this.resultados);
            this.metodoSemDeriv.Location = new System.Drawing.Point(4, 40);
            this.metodoSemDeriv.Name = "metodoSemDeriv";
            this.metodoSemDeriv.Padding = new System.Windows.Forms.Padding(3);
            this.metodoSemDeriv.Size = new System.Drawing.Size(583, 227);
            this.metodoSemDeriv.TabIndex = 0;
            this.metodoSemDeriv.Text = "Métodos com restrições sem derivadas";
            this.metodoSemDeriv.UseVisualStyleBackColor = true;
            // 
            // metodoComDeriv
            // 
            this.metodoComDeriv.Controls.Add(this.groupBox5);
            this.metodoComDeriv.Location = new System.Drawing.Point(4, 22);
            this.metodoComDeriv.Name = "metodoComDeriv";
            this.metodoComDeriv.Padding = new System.Windows.Forms.Padding(3);
            this.metodoComDeriv.Size = new System.Drawing.Size(583, 245);
            this.metodoComDeriv.TabIndex = 1;
            this.metodoComDeriv.Text = "Métodos  com restrições com derivadas";
            this.metodoComDeriv.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.iteracoes_deriv);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(583, 225);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultados: ";
            // 
            // iteracoes_deriv
            // 
            this.iteracoes_deriv.AllowUserToAddRows = false;
            this.iteracoes_deriv.AllowUserToDeleteRows = false;
            this.iteracoes_deriv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.iteracoes_deriv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.iteracoes_deriv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.dataGridViewTextBoxColumn8});
            this.iteracoes_deriv.Location = new System.Drawing.Point(9, 47);
            this.iteracoes_deriv.Name = "iteracoes_deriv";
            this.iteracoes_deriv.ReadOnly = true;
            this.iteracoes_deriv.RowTemplate.ReadOnly = true;
            this.iteracoes_deriv.ShowEditingIcon = false;
            this.iteracoes_deriv.Size = new System.Drawing.Size(568, 161);
            this.iteracoes_deriv.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "K";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "a";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "b";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "xᵢ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "f\'(xᵢ)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "f\"(xᵢ)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "b-a";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "x* =";
            // 
            // metodoSemRestSemDeriv
            // 
            this.metodoSemRestSemDeriv.Controls.Add(this.dataGridView1);
            this.metodoSemRestSemDeriv.Controls.Add(this.label16);
            this.metodoSemRestSemDeriv.Controls.Add(this.label17);
            this.metodoSemRestSemDeriv.Location = new System.Drawing.Point(4, 40);
            this.metodoSemRestSemDeriv.Name = "metodoSemRestSemDeriv";
            this.metodoSemRestSemDeriv.Size = new System.Drawing.Size(583, 227);
            this.metodoSemRestSemDeriv.TabIndex = 2;
            this.metodoSemRestSemDeriv.Text = "Métodos  sem restrições sem derivadas multivariável";
            this.metodoSemRestSemDeriv.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dataGridView1.Location = new System.Drawing.Point(8, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(571, 161);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "K";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "a";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "b";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "p";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "f(p)";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "q";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "f(q)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "b-a";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 13);
            this.label16.TabIndex = 5;
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "x* =";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(11, 272);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(195, 30);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Métodos sem restrições com derivada multivariável: ";
            // 
            // metodoSemRestComDeriv
            // 
            this.metodoSemRestComDeriv.Location = new System.Drawing.Point(4, 40);
            this.metodoSemRestComDeriv.Name = "metodoSemRestComDeriv";
            this.metodoSemRestComDeriv.Size = new System.Drawing.Size(583, 227);
            this.metodoSemRestComDeriv.TabIndex = 3;
            this.metodoSemRestComDeriv.Text = "Métodos  sem restrições com derivadas multivariável";
            this.metodoSemRestComDeriv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Métodos de Programação Não Linear";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valorVars)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.resultados.ResumeLayout(false);
            this.resultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracoes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.metodoSemDeriv.ResumeLayout(false);
            this.metodoComDeriv.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iteracoes_deriv)).EndInit();
            this.metodoSemRestSemDeriv.ResumeLayout(false);
            this.metodoSemRestSemDeriv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox funcao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton buscaFibo;
        private System.Windows.Forms.RadioButton metodoAurea;
        private System.Windows.Forms.RadioButton buscaDicotomica;
        private System.Windows.Forms.RadioButton buscaUniforme;
        private System.Windows.Forms.TextBox valor_err;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor_delta;
        private System.Windows.Forms.TextBox valor_b;
        private System.Windows.Forms.TextBox valor_a;
        private System.Windows.Forms.GroupBox resultados;
        private System.Windows.Forms.DataGridView iteracoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn K;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn fp;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn fq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ba;
        private System.Windows.Forms.Label resultado_deriv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox exemplos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ex_delta;
        private System.Windows.Forms.Label ex_b;
        private System.Windows.Forms.Label ex_a;
        private System.Windows.Forms.Label ex_err;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton metodoNewton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton metodoCoorCiclic;
        private System.Windows.Forms.RadioButton metodoNewtonSemRest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage metodoSemDeriv;
        private System.Windows.Forms.TabPage metodoComDeriv;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView iteracoes_deriv;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton metodoBisseccao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown valorVars;
        private System.Windows.Forms.TabPage metodoSemRestSemDeriv;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox valor_M0;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage metodoSemRestComDeriv;
    }
}

